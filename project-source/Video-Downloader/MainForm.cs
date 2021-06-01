using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Video_Downloader
{
	public partial class MainForm : Form
	{
		private Button activeNavButton;
		private Settings settings;
		#region FormStuff
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

			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			ContentPanelHandler(downloadTab);
			NavButtonActive(downloadButton);
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
			Close();
		}
		private void minimizeButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		#endregion
		private void Button_Click(object sender, EventArgs e)
		{
			Program.Log($"\t{sender} Button pressed");
			if (sender.GetType().IsEquivalentTo(typeof(Button)))
			{
				Button btn = sender as Button;
				NavButtonActive(btn);
			}
		}

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

		private void linkButton_Click(object sender, EventArgs e)
		{
			Program.SaveVideoToDisk(linkTextBox.Text, settings.DownloadLocation,(err) => DisplayError(err));
		}

		private void DisplayError(string message)
		{

		}
	}
}
