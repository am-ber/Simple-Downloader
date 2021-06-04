using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;

namespace Video_Downloader
{
	class Agent
	{
		// private vars
		private Thread routine;
		private Settings settings;
		private RunAfterFinished runnable;
		private bool forceStop;
		private bool convertAfter;
		private FileExtensions extension;
		// Public vars
		public string fileLocation;
		public bool finished = false;
		public StringBuilder LogBuilder;
		public Label updateLabel, statusLabel;
		public YouTubeVideo video;
		public Agent(params object[] things)
		{
			foreach (object thing in things)
			{
				if (thing.GetType().IsEquivalentTo(typeof(YouTubeVideo)))
				{
					video = thing as YouTubeVideo;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(Settings)))
				{
					settings = thing as Settings;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(bool)))
				{
					convertAfter = (bool) thing;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(FileExtensions)))
				{
					extension = (FileExtensions) thing;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(string)))
				{
					fileLocation = (string) thing;
				}
			}
			LogBuilder = new StringBuilder("\n---------------------\nInitializing job.");

			if (video != null)
				routine = new Thread(new ThreadStart(() => RunDownload()));
			else
				routine = new Thread(new ThreadStart(() => RunConvert(fileLocation, extension.value)));
		}
		public delegate void RunAfterFinished(string input);
		public void Start(Label updateLabel, Label statusLabel, RunAfterFinished runnable = null)
		{
			this.updateLabel = updateLabel;
			this.statusLabel = statusLabel;
			this.runnable = runnable;

			if (routine != null)
			{
				if (!routine.IsAlive)
				{
					LogBuilder.Append($"\n\tStarting job at ({DateTime.Now})");
					routine.Start();
				}
			}
		}
		private void RunDownload()
		{
			LogBuilder.Append("\nRunning job for regular video download.");
			try
			{
				HttpClient client = new HttpClient();
				long? totalByte = 0;
				using (Stream output = File.OpenWrite(string.Concat(settings.DownloadLocation, @"\", video.FullName)))
				{
					// video
					using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
					{
						totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content
							.Headers.ContentLength;
					}

					LogBuilder.Append("\nTotal bytes: " + totalByte);
					int totalRead = 0;
					// video
					using (Stream videoInput = video.Stream())
					{
						// 16 kilobyte buffer
						byte[] buffer = new byte[16 * 1024];
						int read;
						while ((read = videoInput.Read(buffer, 0, buffer.Length)) > 0)
						{
							if (forceStop)
								return;
							output.Write(buffer, 0, read);
							totalRead += read;
							long percent = (long) (totalRead / totalByte * 100);
							updateLabel.Invoke(new Action((() =>
							{
								updateLabel.Text = string.Concat(percent, "%");
							})));
						}
					}
				}
			}
			catch (UnauthorizedAccessException uae)
			{
				LogBuilder.Append(
					$"\n\tCan't put file in that directory, hopefully you're ok with the default location.\n\t{uae.Message}");
			}
			catch (ThreadInterruptedException)
			{
				LogBuilder.Append("\n\tThread interrupted, closing immediately.");
				finished = true;
			}
			catch (Exception e)
			{
				LogBuilder.Append($"\n\tSomething happened during execution of job:\n\t{e.Message}");
			}
			LogBuilder.Append($"\nFinished downloading for:\n{video.FullName}");
			statusLabel.Invoke(new Action(() =>
			{
				statusLabel.Text = "Completed";
			}));
			finished = true;

			if (runnable != null)
				runnable(LogBuilder.ToString());
			if (convertAfter)
			{
				RunConvert(Path.Combine(settings.DownloadLocation, video.FullName), FileExtensions.mp3);
				File.Delete(Path.Combine(settings.DownloadLocation, video.FullName));
			}
		}

		private void RunConvert(string fileLocation, string extension)
		{
			LogBuilder.Append("\n\tRunning job for conversion");
			try
			{
				statusLabel.Invoke(new Action(() =>
				{
					statusLabel.Text = "Converting";
				}));
				MediaFile inputFile = new MediaFile()
				{
					Filename = fileLocation
				};
				MediaFile outputFile = new MediaFile()
				{
					Filename = string.Concat(fileLocation, extension)
				};

				using (Engine engine = new Engine())
				{
					engine.GetMetadata(inputFile);

					engine.ConvertProgressEvent += (sender, args) =>
					{
						LogBuilder.Append($"\n\tDuration: {args.TotalDuration}");
						updateLabel.Invoke(new Action((() =>
						{
							updateLabel.Text = string.Concat(args.ProcessedDuration.Minutes, ":", args.ProcessedDuration.Seconds);
						})));
					};
					engine.Convert(inputFile, outputFile);
				}
				statusLabel.Invoke(new Action(() =>
				{
					statusLabel.Text = "Converted";
				}));
			}
			catch (Exception e)
			{
				LogBuilder.Append($"\n\tSomething happened during execution of conversion job:\n\t{e.Message}");
			}
			LogBuilder.Append($"\n\tFinished conversion of {fileLocation}");
			if (runnable != null)
				runnable(LogBuilder.ToString());
		}

		public void Stop()
		{
			if (routine != null)
			{
				if (routine.IsAlive)
					routine.Join();
			}
			finished = true;
		}
		public void ForceStop()
		{
			forceStop = true;
			finished = true;
		}
	}
}