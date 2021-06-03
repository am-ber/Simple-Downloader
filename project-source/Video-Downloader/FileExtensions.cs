using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Downloader
{
	public class FileExtensions
	{
		public string value { get; }

		#region constants
		// update as needed from:
		// https://github.com/AydinAdn/MediaToolkit/wiki/Supported-file-formats
		// audio
		public const string aac = ".aac";
		public const string aif = ".aif";
		public const string aifc = ".aifc";
		public const string au = ".au";
		public const string flac = ".flac";
		public const string m4a = ".m4a";
		public const string mka = ".mka";
		public const string mp2 = ".mp2";
		public const string mp3 = ".mp3";
		public const string mpa = ".mpa";
		public const string ogg = ".ogg";
		public const string wav = ".wav";
		// image
		public const string bmp = ".bmp";
		public const string gif = ".gif";
		public const string jpeg = ".jpeg";
		public const string jpg = ".jpg";
		public const string png = ".png";
		public const string tiff = ".tiff";
		// video
		public const string asf = ".asf";
		public const string avi = ".avi";
		public const string f4v = ".f4v";
		public const string flv = ".flv";
		public const string m2t = ".m2t";
		public const string m2ts = ".m2ts";
		public const string mkv = ".mkv";
		public const string mov = ".mov";
		public const string mp4 = ".mp4";
		public const string mpg = ".mpg";
		public const string mts = ".mts";
		public const string nut = ".nut";
		public const string ogv = ".ogv";
		public const string ts = ".ts";
		public const string vob = ".vob";
		public const string webm = ".webm";
		public const string wmv = ".wmv";
		public const string wtv = ".wtv";
		// lists
		public static readonly string[] AudioFormats =
		{
			aac,aif,aifc,au,flac,m4a,mka,mp2,mp3,mpa,ogg,wav
		};
		public static readonly string[] ImageFormats =
		{
			bmp,gif,jpeg,jpg,png,tiff
		};
		public static readonly string[] VideoFormats =
		{
			asf,avi,f4v,flv,m2t,m2ts,mkv,mov,mp4,mpg,mts,nut,ogv,ts,vob,webm,wmv,wtv
		};
		#endregion
		public FileExtensions(string value)
		{
			this.value = value;
		}
		public override string ToString()
		{
			return value;
		}
	}
}
