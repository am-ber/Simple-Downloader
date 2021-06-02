using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using VideoLibrary;

namespace Video_Downloader
{
	public partial class MainForm : Form
	{
		private Button activeNavButton;
		private Settings settings;
		private TabPage previousPage;
		private List<DownloadAgent> agents;
		#region FormInitializing
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect,
			int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);
		public MainForm(Settings settings)
		{
			this.settings = settings;
			agents = new List<DownloadAgent>();
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			ContentPanelHandler(downloadTab);
			NavButtonActive(downloadButton);

			downloadLocationTextBox.Text = settings.DownloadLocation;
			loggingCheckBox.Checked = settings.LogThings;
		}
		#endregion

		#region ButtonRegion
		private void NavButtonActive(Button btn)
		{
			if (activeNavButton != null)
				NavButtonDeactivate(activeNavButton);

			panelNav.Height = btn.Height;
			panelNav.Top = btn.Top;
			panelNav.Left = btn.Left;
			btn.BackColor = Color.FromArgb(99, 110, 114);
			activeNavButton = btn;
			PanelDecider(btn);
		}
		private void NavButtonDeactivate(Button btn)
		{
			btn.BackColor = Color.Transparent;
		}
		private void Button_Click(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			if (sender.GetType().IsEquivalentTo(typeof(Button)))
			{
				Button btn = sender as Button;
				NavButtonActive(btn);
			}
		}
		private void linkButton_Click(object sender, EventArgs e)
		{
			try
			{
				YouTube youTube = YouTube.Default;
				IEnumerable<YouTubeVideo> video = youTube.GetAllVideos(linkTextBox.Text);
				AddNewDownloadJob(video);
			}
			catch (ArgumentException ae)
			{
				Program.Log($"\tLink not correct or couldn't find the video location.\n\t{ae.Message}", true, DisplayError);
			}
			catch (UnauthorizedAccessException uae)
			{
				Program.Log("\tCan't put file in that directory." +
				            "Hopefully you're ok with the default location.\n" +
				            $"\t{uae.Message}", true, DisplayError);
			}
		}
		private void errorCloseButton_Click(object sender, EventArgs e)
		{
			contentTabController.SelectedTab = previousPage;
		}
		private void downloadLocation_Click(object sender, EventArgs e)
		{
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				DialogResult result = folderDialog.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
				{
					downloadLocationTextBox.Text = folderDialog.SelectedPath;
					settings.DownloadLocation = folderDialog.SelectedPath;
					UpdateSettings();
				}
			}
		}
		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
		private void closeAppButton_Click(object sender, EventArgs e)
		{
			foreach (DownloadAgent agent in agents)
			{
				if (!agent.finished)
					agent.Stop();
			}
			Close();
		}
		private void minimizeButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		#endregion
		private void downloadLocationTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				bool incorrect = Directory.Exists(downloadLocationTextBox.Text);
				if (!incorrect)
				{
					try
					{
						Directory.CreateDirectory(downloadLocationTextBox.Text);
						settings.DownloadLocation = downloadLocationTextBox.Text;
						incorrect = true;
					}
					catch (Exception em)
					{
						Program.Log($"\tSomething is wrong with this file location...\t\n{em.Message}",
							true, (string err) => DisplayError(err));
					}
				}
				if (incorrect)
				{
					UpdateSettings();
				}
			}
		}
		private void loggingCheckBox_CheckStateChanged(object sender, EventArgs e)
		{
			settings.LogThings = loggingCheckBox.Checked;
			UpdateSettings();
		}
		private void UpdateSettings()
		{
			File.WriteAllText("config.json", JsonConvert.SerializeObject(settings));
		}
		private void PanelDecider(Button activator)
		{
			if (activator.Equals(downloadButton))
			{
				ContentPanelHandler(downloadTab);
				return;
			}

			if (activator.Equals(settingsButton))
			{
				ContentPanelHandler(settingsTab);
				return;
			}
		}
		private void ContentPanelHandler(TabPage page)
		{
			contentTabController.Region = new Region(new RectangleF(
				page.Left,
				page.Top,
				page.Width,
				page.Height)
			);
			contentTabController.SelectTab(page);
		}
		private void DisplayError(string message)
		{
			previousPage = contentTabController.SelectedTab;
			errorBodyLabel.Text = message;
			ContentPanelHandler(errorTab);
		}
		private void AddNewDownloadJob(IEnumerable<YouTubeVideo> videos)
		{
			YouTubeVideo maxResolution = videos.First(i => i.Resolution == videos.Max(j => j.Resolution));
			AddDownloadRow(new DownloadAgent(maxResolution, settings));
		}
		private void AddDownloadRow(DownloadAgent agent)
		{
			Label percentLable = new Label()
			{
				Text = "0%"
			};
			Label statusLabel = new Label()
			{
				Text = "downloading"
			};
			jobTable.RowCount = jobTable.RowCount + 1;
			jobTable.Controls.Add(new Label(){ Name = string.Concat(agent.video.Title, "Label"), Text = agent.video.Title}, 0, jobTable.RowCount - 1);
			jobTable.Controls.Add(percentLable, 1, jobTable.RowCount - 1);
			jobTable.Controls.Add(statusLabel, 2, jobTable.RowCount - 1);

			agents.Add(agent);
			agent.Start(percentLable, statusLabel);
		}
	}
}