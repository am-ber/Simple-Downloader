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
	public partial class Form1 : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect,
			int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public Form1()
		{
			InitializeComponent();
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void dashboardButton_Click(object sender, EventArgs e)
		{
			MovePanelNav(dashboardButton);
		}
		private void settingsButton_Click(object sender, EventArgs e)
		{
			MovePanelNav(settingsButton);
		}

		private void MovePanelNav(Button btn)
		{
			panelNav.Height = btn.Height;
			panelNav.Top = btn.Top;
			panelNav.Left = btn.Left;
			btn.BackColor = Color.FromArgb(100, 100, 175);
		}

		private void dashboardButton_Leave(object sender, EventArgs e)
		{
			dashboardButton.BackColor = Color.Transparent;
		}

		private void settingsButton_Leave(object sender, EventArgs e)
		{
			settingsButton.BackColor = Color.Transparent;
		}

		private void closeAppButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
