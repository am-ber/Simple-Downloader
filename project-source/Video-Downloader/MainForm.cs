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
		private Panel activePanel;
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
		private void Form1_Load(object sender, EventArgs e)
		{
			ContentPanelHandler(downloadPanel);
			NavButtonActive(downloadButton);
		}
		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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
				ContentPanelHandler(downloadPanel);
				return;
			}

			if (activator.Equals(settingsButton))
			{
				ContentPanelHandler(settingsPanel);
				return;
			}
		}
		private void ContentPanelHandler(Panel newPanel)
		{
			if (activePanel == null)
				activePanel = newPanel;
			activePanel.Visible = false;
			activePanel = newPanel;
			activePanel.Visible = true;
		}

		private void linkButton_Click(object sender, EventArgs e)
		{
			Program.SaveVideoToDisk(linkTextBox.Text, settings.DownloadLocation,() => DisplayError(""));
		}

		private void DisplayError(string message)
		{

		}
	}
}
