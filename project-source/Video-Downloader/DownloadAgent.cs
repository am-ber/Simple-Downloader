using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoLibrary;

namespace Video_Downloader
{
	class DownloadAgent
	{
		private Thread routine;
		private Settings settings;
		private YouTube yt;
		private string uri;

		public IEnumerable<YouTubeVideo> videos;
		public bool finished = false;
		public StringBuilder LogBuilder;
		public DownloadAgent(string uri, Settings settings)
		{
			this.uri = uri;
			this.settings = settings;

			yt = YouTube.Default;
			LogBuilder = new StringBuilder($"\n---------------------\nInitializing job for url:\n{uri}");
			routine = new Thread(new ThreadStart(() => Run()));
		}

		public void Start()
		{
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
				File.WriteAllBytes(string.Concat(settings.DownloadLocation, @"\", video.FullName), video.GetBytes());
			}
			catch (Exception e)
			{
				LogBuilder.Append($"\n\tSomething happened during execution of job:\n\t{e.Message}");
			}
			LogBuilder.Append($"\nFinished job for url:\n{uri}");
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
