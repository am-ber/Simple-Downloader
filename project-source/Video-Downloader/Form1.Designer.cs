
namespace Video_Downloader
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.buttonContainer = new System.Windows.Forms.Panel();
			this.panelNav = new System.Windows.Forms.Panel();
			this.settingsButton = new System.Windows.Forms.Button();
			this.dashboardButton = new System.Windows.Forms.Button();
			this.iconTitlePanel = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.icon = new System.Windows.Forms.PictureBox();
			this.titleLable = new System.Windows.Forms.Label();
			this.titlebarPanel = new System.Windows.Forms.Panel();
			this.closeAppButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.leftMenuPanel.SuspendLayout();
			this.buttonContainer.SuspendLayout();
			this.iconTitlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.titlebarPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftMenuPanel
			// 
			this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
			this.leftMenuPanel.Controls.Add(this.buttonContainer);
			this.leftMenuPanel.Controls.Add(this.iconTitlePanel);
			this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.leftMenuPanel.Name = "leftMenuPanel";
			this.leftMenuPanel.Size = new System.Drawing.Size(200, 600);
			this.leftMenuPanel.TabIndex = 0;
			// 
			// buttonContainer
			// 
			this.buttonContainer.Controls.Add(this.panelNav);
			this.buttonContainer.Controls.Add(this.settingsButton);
			this.buttonContainer.Controls.Add(this.dashboardButton);
			this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonContainer.Location = new System.Drawing.Point(0, 100);
			this.buttonContainer.Name = "buttonContainer";
			this.buttonContainer.Size = new System.Drawing.Size(200, 500);
			this.buttonContainer.TabIndex = 1;
			// 
			// panelNav
			// 
			this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panelNav.Location = new System.Drawing.Point(1, 0);
			this.panelNav.Name = "panelNav";
			this.panelNav.Size = new System.Drawing.Size(3, 70);
			this.panelNav.TabIndex = 2;
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.Color.Transparent;
			this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.settingsButton.FlatAppearance.BorderSize = 0;
			this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.settingsButton.Image = global::Video_Downloader.Properties.Resources.settings;
			this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.settingsButton.Location = new System.Drawing.Point(0, 70);
			this.settingsButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(200, 70);
			this.settingsButton.TabIndex = 1;
			this.settingsButton.Text = "Settings";
			this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			this.settingsButton.Leave += new System.EventHandler(this.settingsButton_Leave);
			// 
			// dashboardButton
			// 
			this.dashboardButton.BackColor = System.Drawing.Color.Transparent;
			this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.dashboardButton.FlatAppearance.BorderSize = 0;
			this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dashboardButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.dashboardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.dashboardButton.Image = global::Video_Downloader.Properties.Resources.home;
			this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dashboardButton.Location = new System.Drawing.Point(0, 0);
			this.dashboardButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.dashboardButton.Name = "dashboardButton";
			this.dashboardButton.Size = new System.Drawing.Size(200, 70);
			this.dashboardButton.TabIndex = 0;
			this.dashboardButton.Text = "Dashboard";
			this.dashboardButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.dashboardButton.UseVisualStyleBackColor = false;
			this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
			this.dashboardButton.Leave += new System.EventHandler(this.dashboardButton_Leave);
			// 
			// iconTitlePanel
			// 
			this.iconTitlePanel.AutoSize = true;
			this.iconTitlePanel.Controls.Add(this.panel3);
			this.iconTitlePanel.Controls.Add(this.icon);
			this.iconTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconTitlePanel.Location = new System.Drawing.Point(0, 0);
			this.iconTitlePanel.MinimumSize = new System.Drawing.Size(190, 100);
			this.iconTitlePanel.Name = "iconTitlePanel";
			this.iconTitlePanel.Padding = new System.Windows.Forms.Padding(1);
			this.iconTitlePanel.Size = new System.Drawing.Size(200, 100);
			this.iconTitlePanel.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(1, 85);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 1);
			this.panel3.Size = new System.Drawing.Size(198, 14);
			this.panel3.TabIndex = 2;
			// 
			// icon
			// 
			this.icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.icon.Image = global::Video_Downloader.Properties.Resources.youtube;
			this.icon.Location = new System.Drawing.Point(1, 1);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(198, 98);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 0;
			this.icon.TabStop = false;
			// 
			// titleLable
			// 
			this.titleLable.BackColor = System.Drawing.Color.Transparent;
			this.titleLable.Dock = System.Windows.Forms.DockStyle.Top;
			this.titleLable.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.titleLable.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.titleLable.Location = new System.Drawing.Point(0, 0);
			this.titleLable.Name = "titleLable";
			this.titleLable.Padding = new System.Windows.Forms.Padding(5);
			this.titleLable.Size = new System.Drawing.Size(574, 31);
			this.titleLable.TabIndex = 1;
			this.titleLable.Text = "Simple Downloader";
			this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// titlebarPanel
			// 
			this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
			this.titlebarPanel.Controls.Add(this.titleLable);
			this.titlebarPanel.Controls.Add(this.closeAppButton);
			this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlebarPanel.Location = new System.Drawing.Point(200, 0);
			this.titlebarPanel.MinimumSize = new System.Drawing.Size(0, 32);
			this.titlebarPanel.Name = "titlebarPanel";
			this.titlebarPanel.Size = new System.Drawing.Size(600, 32);
			this.titlebarPanel.TabIndex = 1;
			// 
			// closeAppButton
			// 
			this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeAppButton.FlatAppearance.BorderSize = 0;
			this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeAppButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeAppButton.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.closeAppButton.Location = new System.Drawing.Point(574, 0);
			this.closeAppButton.Name = "closeAppButton";
			this.closeAppButton.Size = new System.Drawing.Size(26, 32);
			this.closeAppButton.TabIndex = 0;
			this.closeAppButton.Text = "X";
			this.closeAppButton.UseVisualStyleBackColor = true;
			this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
			// 
			// contentPanel
			// 
			this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
			this.contentPanel.Location = new System.Drawing.Point(223, 55);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(20);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
			this.contentPanel.Size = new System.Drawing.Size(577, 545);
			this.contentPanel.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.titlebarPanel);
			this.Controls.Add(this.leftMenuPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.leftMenuPanel.ResumeLayout(false);
			this.leftMenuPanel.PerformLayout();
			this.buttonContainer.ResumeLayout(false);
			this.iconTitlePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.titlebarPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftMenuPanel;
		private System.Windows.Forms.Panel iconTitlePanel;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label titleLable;
		private System.Windows.Forms.Panel buttonContainer;
		private System.Windows.Forms.Panel panelNav;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.Button dashboardButton;
		private System.Windows.Forms.Panel titlebarPanel;
		private System.Windows.Forms.Button closeAppButton;
		private System.Windows.Forms.Panel contentPanel;
	}
}

