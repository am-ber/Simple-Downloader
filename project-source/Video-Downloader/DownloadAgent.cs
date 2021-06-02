using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Video_Downloader
{
	class DownloadAgent
	{
		// private vars
		private Thread routine;
		private Settings settings;
		// Public vars
		public bool finished = false;
		public StringBuilder LogBuilder;
		public Label updateLabel, statusLabel;
		public YouTubeVideo video;
		public DownloadAgent(YouTubeVideo video, Settings settings)
		{
			this.video = video;
			this.settings = settings;
			
			LogBuilder = new StringBuilder($"\n---------------------\nInitializing job for:\n{video.FullName}");
			routine = new Thread(new ThreadStart(() => Run()));
		}
		public void Start(Label updateLabel, Label statusLabel)
		{
			this.updateLabel = updateLabel;
			this.statusLabel = statusLabel;
			if (!routine.IsAlive)
			{
				LogBuilder.Append($"\n\tStarting job at ({DateTime.Now})");
				routine.Start();
			}
		}
		private void Run()
		{
			try
			{
				HttpClient client = new HttpClient();
				long? totalByte = 0;
				File.WriteAllBytes(string.Concat(settings.DownloadLocation, @"\", video.FullName), video.GetBytes());
				using (Stream output = File.OpenWrite(string.Concat(settings.DownloadLocation, @"\", video.FullName)))
				{
					using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Head, video.Uri))
					{
						totalByte = client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).Result.Content.Headers.ContentLength;
					}
					using (Stream input = client.GetStreamAsync(video.Uri).Result)
					{
						byte[] buffer = new byte[16 * 1024];
						int read;
						int totalRead = 0;
						Console.WriteLine("Download Started");
						while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
						{
							output.Write(buffer, 0, read);
							totalRead += read;
							long percent = (long)((totalRead / totalByte) * 100);
							updateLabel.Text = string.Concat(percent.ToString("###"), "%");
						}
					}
				}
			}
			catch (UnauthorizedAccessException uae)
			{
				LogBuilder.Append($"\tCan't put file in that directory, hopefully you're ok with the default location.\n\t{uae.Message}");
			}
			catch (Exception e)
			{
				LogBuilder.Append($"\n\tSomething happened during execution of job:\n\t{e.Message}");
			}
			LogBuilder.Append($"\nFinished job for:\n{video.FullName}");
			statusLabel.Text = "Completed";
			finished = true;
		}
		public void Stop()
		{
			if (routine.IsAlive)
				routine.Join();
			finished = true;
		}
	}
}