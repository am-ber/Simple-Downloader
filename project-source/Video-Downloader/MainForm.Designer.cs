
namespace Video_Downloader
{
	partial class MainForm
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
			System.Windows.Forms.TabControl contentTabController;
			this.downloadTab = new System.Windows.Forms.TabPage();
			this.downloadPanel = new System.Windows.Forms.Panel();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.linkButton = new System.Windows.Forms.Button();
			this.linkTextBox = new System.Windows.Forms.TextBox();
			this.settingsTab = new System.Windows.Forms.TabPage();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.buttonContainer = new System.Windows.Forms.Panel();
			this.panelNav = new System.Windows.Forms.Panel();
			this.settingsButton = new System.Windows.Forms.Button();
			this.downloadButton = new System.Windows.Forms.Button();
			this.iconTitlePanel = new System.Windows.Forms.Panel();
			this.icon = new System.Windows.Forms.PictureBox();
			this.titleLable = new System.Windows.Forms.Label();
			this.titlebarPanel = new System.Windows.Forms.Panel();
			this.closeAppButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			contentTabController = new System.Windows.Forms.TabControl();
			contentTabController.SuspendLayout();
			this.downloadTab.SuspendLayout();
			this.downloadPanel.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.settingsTab.SuspendLayout();
			this.leftMenuPanel.SuspendLayout();
			this.buttonContainer.SuspendLayout();
			this.iconTitlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.titlebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// contentTabController
			// 
			contentTabController.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			contentTabController.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			contentTabController.Controls.Add(this.downloadTab);
			contentTabController.Controls.Add(this.settingsTab);
			contentTabController.Dock = System.Windows.Forms.DockStyle.Fill;
			contentTabController.Font = new System.Drawing.Font("Segoe UI", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			contentTabController.ItemSize = new System.Drawing.Size(1, 1);
			contentTabController.Location = new System.Drawing.Point(0, 0);
			contentTabController.Name = "contentTabController";
			contentTabController.Padding = new System.Drawing.Point(0, 0);
			contentTabController.SelectedIndex = 0;
			contentTabController.Size = new System.Drawing.Size(650, 562);
			contentTabController.TabIndex = 0;
			contentTabController.TabStop = false;
			// 
			// downloadTab
			// 
			this.downloadTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadTab.Controls.Add(this.downloadPanel);
			this.downloadTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.downloadTab.Location = new System.Drawing.Point(4, 5);
			this.downloadTab.Margin = new System.Windows.Forms.Padding(0);
			this.downloadTab.Name = "downloadTab";
			this.downloadTab.Padding = new System.Windows.Forms.Padding(10);
			this.downloadTab.Size = new System.Drawing.Size(642, 553);
			this.downloadTab.TabIndex = 0;
			// 
			// downloadPanel
			// 
			this.downloadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadPanel.Controls.Add(this.searchPanel);
			this.downloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.downloadPanel.Location = new System.Drawing.Point(10, 10);
			this.downloadPanel.Name = "downloadPanel";
			this.downloadPanel.Size = new System.Drawing.Size(622, 533);
			this.downloadPanel.TabIndex = 0;
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.linkButton);
			this.searchPanel.Controls.Add(this.linkTextBox);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.MinimumSize = new System.Drawing.Size(0, 24);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(622, 24);
			this.searchPanel.TabIndex = 1;
			// 
			// linkButton
			// 
			this.linkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.linkButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.linkButton.FlatAppearance.BorderSize = 0;
			this.linkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.linkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.linkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.linkButton.Location = new System.Drawing.Point(547, 0);
			this.linkButton.Name = "linkButton";
			this.linkButton.Size = new System.Drawing.Size(75, 24);
			this.linkButton.TabIndex = 1;
			this.linkButton.Text = "Download";
			this.linkButton.UseVisualStyleBackColor = false;
			this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
			// 
			// linkTextBox
			// 
			this.linkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.linkTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.linkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.linkTextBox.Location = new System.Drawing.Point(0, 0);
			this.linkTextBox.MinimumSize = new System.Drawing.Size(529, 24);
			this.linkTextBox.Name = "linkTextBox";
			this.linkTextBox.Size = new System.Drawing.Size(529, 25);
			this.linkTextBox.TabIndex = 0;
			// 
			// settingsTab
			// 
			this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.settingsTab.Controls.Add(this.settingsPanel);
			this.settingsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.settingsTab.Location = new System.Drawing.Point(4, 5);
			this.settingsTab.Name = "settingsTab";
			this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
			this.settingsTab.Size = new System.Drawing.Size(642, 553);
			this.settingsTab.TabIndex = 1;
			// 
			// settingsPanel
			// 
			this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsPanel.Location = new System.Drawing.Point(3, 3);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Size = new System.Drawing.Size(636, 547);
			this.settingsPanel.TabIndex = 1;
			this.settingsPanel.Visible = false;
			// 
			// leftMenuPanel
			// 
			this.leftMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.leftMenuPanel.Controls.Add(this.buttonContainer);
			this.leftMenuPanel.Controls.Add(this.iconTitlePanel);
			this.leftMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftMenuPanel.Location = new System.Drawing.Point(0, 0);
			this.leftMenuPanel.Name = "leftMenuPanel";
			this.leftMenuPanel.Size = new System.Drawing.Size(150, 600);
			this.leftMenuPanel.TabIndex = 0;
			// 
			// buttonContainer
			// 
			this.buttonContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.buttonContainer.Controls.Add(this.panelNav);
			this.buttonContainer.Controls.Add(this.settingsButton);
			this.buttonContainer.Controls.Add(this.downloadButton);
			this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonContainer.Location = new System.Drawing.Point(0, 100);
			this.buttonContainer.Name = "buttonContainer";
			this.buttonContainer.Size = new System.Drawing.Size(150, 500);
			this.buttonContainer.TabIndex = 1;
			// 
			// panelNav
			// 
			this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
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
			this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.settingsButton.Location = new System.Drawing.Point(0, 70);
			this.settingsButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(190, 70);
			this.settingsButton.TabIndex = 1;
			this.settingsButton.Text = "Settings";
			this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.Button_Click);
			// 
			// downloadButton
			// 
			this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.downloadButton.FlatAppearance.BorderSize = 0;
			this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downloadButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.downloadButton.Location = new System.Drawing.Point(0, 0);
			this.downloadButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.downloadButton.Name = "downloadButton";
			this.downloadButton.Size = new System.Drawing.Size(190, 70);
			this.downloadButton.TabIndex = 0;
			this.downloadButton.Text = "Download";
			this.downloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.downloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.downloadButton.UseVisualStyleBackColor = false;
			this.downloadButton.Click += new System.EventHandler(this.Button_Click);
			// 
			// iconTitlePanel
			// 
			this.iconTitlePanel.AutoSize = true;
			this.iconTitlePanel.BackColor = System.Drawing.Color.Transparent;
			this.iconTitlePanel.Controls.Add(this.icon);
			this.iconTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconTitlePanel.Location = new System.Drawing.Point(0, 0);
			this.iconTitlePanel.MinimumSize = new System.Drawing.Size(150, 100);
			this.iconTitlePanel.Name = "iconTitlePanel";
			this.iconTitlePanel.Padding = new System.Windows.Forms.Padding(1);
			this.iconTitlePanel.Size = new System.Drawing.Size(150, 100);
			this.iconTitlePanel.TabIndex = 0;
			// 
			// icon
			// 
			this.icon.BackColor = System.Drawing.Color.Transparent;
			this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.icon.Image = global::Video_Downloader.Properties.Resources.logo1;
			this.icon.Location = new System.Drawing.Point(1, 1);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(148, 98);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 0;
			this.icon.TabStop = false;
			// 
			// titleLable
			// 
			this.titleLable.BackColor = System.Drawing.Color.Transparent;
			this.titleLable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titleLable.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.titleLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.titleLable.Location = new System.Drawing.Point(0, 0);
			this.titleLable.Name = "titleLable";
			this.titleLable.Padding = new System.Windows.Forms.Padding(5);
			this.titleLable.Size = new System.Drawing.Size(624, 38);
			this.titleLable.TabIndex = 1;
			this.titleLable.Text = "Simple Downloader";
			this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titleLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// titlebarPanel
			// 
			this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.titlebarPanel.Controls.Add(this.titleLable);
			this.titlebarPanel.Controls.Add(this.closeAppButton);
			this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlebarPanel.Location = new System.Drawing.Point(150, 0);
			this.titlebarPanel.MinimumSize = new System.Drawing.Size(0, 38);
			this.titlebarPanel.Name = "titlebarPanel";
			this.titlebarPanel.Size = new System.Drawing.Size(650, 38);
			this.titlebarPanel.TabIndex = 1;
			this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			// 
			// closeAppButton
			// 
			this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeAppButton.FlatAppearance.BorderSize = 0;
			this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeAppButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.closeAppButton.Location = new System.Drawing.Point(624, 0);
			this.closeAppButton.Name = "closeAppButton";
			this.closeAppButton.Size = new System.Drawing.Size(26, 38);
			this.closeAppButton.TabIndex = 0;
			this.closeAppButton.Text = "X";
			this.closeAppButton.UseVisualStyleBackColor = true;
			this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
			// 
			// contentPanel
			// 
			this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.contentPanel.Controls.Add(contentTabController);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(150, 38);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(20);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(650, 562);
			this.contentPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.titlebarPanel);
			this.Controls.Add(this.leftMenuPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			contentTabController.ResumeLayout(false);
			this.downloadTab.ResumeLayout(false);
			this.downloadPanel.ResumeLayout(false);
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.settingsTab.ResumeLayout(false);
			this.leftMenuPanel.ResumeLayout(false);
			this.leftMenuPanel.PerformLayout();
			this.buttonContainer.ResumeLayout(false);
			this.iconTitlePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.titlebarPanel.ResumeLayout(false);
			this.contentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftMenuPanel;
		private System.Windows.Forms.Panel iconTitlePanel;
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Label titleLable;
		private System.Windows.Forms.Panel buttonContainer;
		private System.Windows.Forms.Panel panelNav;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.Button downloadButton;
		private System.Windows.Forms.Panel titlebarPanel;
		private System.Windows.Forms.Button closeAppButton;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Panel downloadPanel;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.TextBox linkTextBox;
		private System.Windows.Forms.Button linkButton;
		private System.Windows.Forms.TabControl contentTabController;
		private System.Windows.Forms.TabPage downloadTab;
		private System.Windows.Forms.TabPage settingsTab;
	}
}

