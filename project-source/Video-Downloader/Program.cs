using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace Video_Downloader
{
	static class Program
	{
		private static StreamWriter currentLogFile;
		private static string logFileName = "";
		[STAThread]
		static void Main()
		{
			InitLogFile();

			Log($"Simple Downloader starting execution({DateTime.Now})...");
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());

			Close();
		}

		private static void InitLogFile()
		{
			// Initialize log file
			string cleanDateTime = DateTime.Now.ToString("M-dd-yy--HH-mm-ss");
			string logFileName = "sdlog_" + cleanDateTime + ".log";
			FileStream f = File.Create(logFileName);
			f.Close();
			currentLogFile = File.AppendText(logFileName);
		}
		public static void SaveVideoToDisk(string link, GenericErrorMethod gem = null)
		{
			try
			{
				YouTube youTube = YouTube.Default;
				YouTubeVideo video = youTube.GetVideo(link);
				File.WriteAllBytes(KnownFolders.GetPath(KnownFolder.Downloads) + video.FullName, video.GetBytes());
			}
			catch (ArgumentException ae)
			{
				Log($"\tLink not correct or couldn't find the video location.\n\t{ae.Message}", true, gem);
			}
			catch (UnauthorizedAccessException uae)
			{
				Log($"\tCan't put file in that directory, hopefully you're ok with the default location.\n\t{uae.Message}", true, gem);

			}
		}

		public delegate void GenericErrorMethod();
		public static void Log(string msg, bool error = false, GenericErrorMethod gem = null)
		{
			StringBuilder sb = new StringBuilder();
			// error handling
			if (error)
			{
				sb.Append("\n\t\t---------------------ERROR-------------------------\n");
				sb.Append(msg);
				sb.Append("\n\t\t-----------------ENDOFERROR-------------------------\n");
			}
			else
			{
				sb.Append(msg);
				sb.Append("\n");
			}
			// Prints built message in designated locations
			Console.WriteLine(sb.ToString());
			try
			{
				lock (currentLogFile)
				{
					currentLogFile.Write(sb.ToString());
					currentLogFile.Flush();
				}
			}
			catch (ObjectDisposedException ode)
			{
				Console.WriteLine($"Stream was closed... Couldn't write to file.\n{ode.Message}");
			}
			catch (System.Exception e)
			{
				Console.WriteLine($"Something else happened...\n{e.Message}");
			}

			try
			{
				if (gem != null)
					gem();
			}
			catch (Exception e)
			{
				Console.WriteLine($"Something happened while running the method for handling an error...\n{e.Message}");
			}
		}

		public static void Close()
		{
			Log($"Ending Execution... ({DateTime.Now})");
			try
			{
				currentLogFile.Close();
			}
			catch (Exception)
			{
				// do nothing because the file is probably already closed
			}
		}
	}
}
