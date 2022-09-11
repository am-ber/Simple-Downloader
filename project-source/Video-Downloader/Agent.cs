using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
		// Public vars
		public string fileLocation;
		public bool finished = false;
		public StringBuilder LogBuilder;
		public Label updateLabel, statusLabel;
		public VideoTuple video;
		public struct VideoTuple
		{
			public YouTubeVideo video { get; set; }
			public YouTubeVideo audio { get; set; }
		}
		public Agent(params object[] things)
		{
			foreach (object thing in things)
			{
				if (thing.GetType().IsEquivalentTo(typeof(VideoTuple)))
				{
					video = (VideoTuple) thing;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(Settings)))
				{
					settings = thing as Settings;
					continue;
				}
				if (thing.GetType().IsEquivalentTo(typeof(string)))
				{
					fileLocation = (string) thing;
					continue;
				}
			}
			LogBuilder = new StringBuilder("\n---------------------\nInitializing job.");

			if (video.video != null)
				routine = new Thread(new ThreadStart(() => RunDownload()));
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
		private async Task RunDownload()
		{
			LogBuilder.Append("\nRunning job for regular video download.");
			try
			{
				HttpClient client = new HttpClient();
				long? totalByte = 0;
				using (Stream output = File.OpenWrite(string.Concat(settings.DownloadLocation, @"\", video.video.FullName)))
				{
					// video
					using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, video.video.Uri))
					{
						totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content
							.Headers.ContentLength;
					}

					LogBuilder.Append("\nTotal bytes: " + totalByte);
					int totalRead = 0;
					// video
					using (Stream videoInput = video.video.Stream())
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
			LogBuilder.Append($"\nFinished downloading for:\n{video.video.FullName}");
			statusLabel.Invoke(new Action(() =>
			{
				statusLabel.Text = "Completed";
			}));
			finished = true;

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