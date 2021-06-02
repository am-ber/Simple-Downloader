using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Downloader
{
	public class Settings
	{
		public string DownloadLocation { get; set; }
		public bool LogThings { get; set; }
		public string LastVideoDownloaded { get; set; }
		public string LastExtension { get; set; }
	}
}
