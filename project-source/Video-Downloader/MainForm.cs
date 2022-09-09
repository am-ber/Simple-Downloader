using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
		private List<Agent> agents;
		private StringBuilder convertExtensionFilterBuilder;
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
			agents = new List<Agent>();
			InitializeComponent();
			InitConvertFilterBuilder();
			Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			ContentPanelHandler(downloadTab);
			NavButtonActive(downloadButton);
			InitFormControllers();
		}
		private void InitFormControllers()
		{
			formatDownloadComboBox.Items.Add(".mp4");
			formatDownloadComboBox.Items.Add(".mp3");
			formatDownloadComboBox.Text = settings.LastExtension;
			downloadLocationTextBox.Text = settings.DownloadLocation;
			linkTextBox.Text = settings.LastVideoDownloaded;
			convertOutputLocationTextBox.Text = settings.DownloadLocation;
			loggingCheckBox.Checked = settings.LogThings;

			convertExtensionComboBox.Items.AddRange(FileExtensions.AudioFormats);
			convertExtensionComboBox.Items.AddRange(FileExtensions.VideoFormats);
			convertExtensionComboBox.Text = FileExtensions.mp3;
		}
		private void InitConvertFilterBuilder()
		{
			convertExtensionFilterBuilder = new StringBuilder("Video Files|");
			foreach (string extension in FileExtensions.VideoFormats)
			{
				convertExtensionFilterBuilder.Append($"*{extension};");
			}
			convertExtensionFilterBuilder.Append("|Audio Files|");
			foreach (string extension in FileExtensions.AudioFormats)
			{
				convertExtensionFilterBuilder.Append($"*{extension};");
			}
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
		private void NavButtonClick(object sender, EventArgs e)
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
			Program.Log($"\t{sender} Button pressed");
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
			Program.Log($"\t{sender} Button pressed");
			contentTabController.SelectedTab = previousPage;
		}
		private void downloadLocation_Click(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
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
			Program.Log($"\t{sender} Button pressed");
			foreach (Agent agent in agents)
			{
				if (!agent.finished)
					agent.ForceStop();
			}
			UpdateSettings();
			Close();
		}
		private void minimizeButton_Click(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			WindowState = FormWindowState.Minimized;
		}
		private void convertInputSelectFileButtonClick(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			OpenFileDialog dialog = new OpenFileDialog()
			{
				Filter = convertExtensionFilterBuilder.ToString(),
				InitialDirectory = settings.DownloadLocation,
				Title = "Select a file to convert."
			};
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				convertInputFileLocationTextBox.Text = dialog.FileName;
			}
		}
		private void convertOutputLocationButtonClick(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
			{
				DialogResult result = folderDialog.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
				{
					convertOutputLocationTextBox.Text = folderDialog.SelectedPath;
				}
			}
		}
		private void convertStartButtonClick(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			try
			{
				AddJobRow(new Agent(convertInputFileLocationTextBox.Text,
						new FileExtensions(convertExtensionComboBox.Text)),
					convertJobTable);
			}
			catch (Exception ex)
			{
				DisplayError($"***shruging***\n{ex.Message}");
			}
		}
		#endregion
		private void downloadLocationTextBox_KeyDown(object sender, KeyEventArgs e)
		{
			Program.Log($"\tUser pressed enter on {sender}");
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
			Program.Log("\tUser toggled logging.");
			settings.LogThings = loggingCheckBox.Checked;
			UpdateSettings();
		}
		private void UpdateSettings()
		{
			Program.Log("Updating settings file.");
			settings.LastVideoDownloaded = linkTextBox.Text;
			settings.LastExtension = formatDownloadComboBox.Text;
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

			if (activator.Equals(convertNavButton))
			{
				ContentPanelHandler(convertTab);
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
			Program.Log($"\tDisplaying Error message: {message}");
			previousPage = contentTabController.SelectedTab;
			errorBodyLabel.Text = message;
			ContentPanelHandler(errorTab);
		}
		private void AddNewDownloadJob(IEnumerable<YouTubeVideo> videos)
		{
			YouTubeVideo maxQualityVideo = videos.First();
			foreach (YouTubeVideo v in videos)
			{
				if (v.Resolution > maxQualityVideo.Resolution && v.AudioBitrate > maxQualityVideo.AudioBitrate)
				{
					maxQualityVideo = v;
				}
			}

			YouTubeVideo maxBitrate = videos.First(i => i.AudioBitrate == videos.Max(j => j.AudioBitrate));
			switch (formatDownloadComboBox.Text)
			{
				case (FileExtensions.mp4):
					AddJobRow(new Agent(maxQualityVideo, settings), jobTable);
					break;
				case (FileExtensions.mp3):
					AddJobRow(new Agent(maxBitrate, settings, true), jobTable);
					break;
			}
		}
		private void AddJobRow(Agent agent, TableLayoutPanel panel)
		{
			Label titleLabel = new Label();
			if (agent.video.video != null)
				titleLabel.Text = agent.video.video.FullName;
			else
				titleLabel.Text = agent.fileLocation;
			Label percentLable = new Label()
			{
				Text = "0%"
			};
			Label statusLabel = new Label()
			{
				Text = "Starting"
			};
			Button forceEndButton = new Button()
			{
				Text = "X",
				FlatStyle = FlatStyle.Flat,
				BackColor = Color.FromArgb(178, 190, 195),
				ForeColor = Color.FromArgb(45, 52, 54)
			};
			forceEndButton.Click += ((sender, args) =>
			{
				if (!agent.finished)
				{
					agent.ForceStop();
					forceEndButton.Visible = false;
					statusLabel.Text = "Canceled";
					titleLabel.ForeColor = Color.FromArgb(255, 118, 117);
					statusLabel.ForeColor = Color.FromArgb(255, 118, 117);
					percentLable.ForeColor = Color.FromArgb(255, 118, 117);
				}
			});
			panel.RowCount = panel.RowCount + 1;
			panel.Controls.Add(titleLabel, 0, panel.RowCount - 1);
			panel.Controls.Add(percentLable, 1, panel.RowCount - 1);
			panel.Controls.Add(statusLabel, 2, panel.RowCount - 1);
			panel.Controls.Add(forceEndButton, 3, panel.RowCount - 1);
			agents.Add(agent);
			agent.Start(percentLable, statusLabel, PrintToLog);
		}
		private void PrintToLog(string message)
		{
			Program.Log(message);
		}
	}
}