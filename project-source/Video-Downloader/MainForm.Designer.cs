
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.contentTabController = new System.Windows.Forms.TabControl();
			this.settingsTab = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.settingsTabLabel = new System.Windows.Forms.Label();
			this.downloadButton = new System.Windows.Forms.Button();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.versionLabel = new System.Windows.Forms.Label();
			this.downloadLocationLabel = new System.Windows.Forms.Label();
			this.otherSettingsLabel = new System.Windows.Forms.Label();
			this.logSettingsPanel = new System.Windows.Forms.Panel();
			this.loggingCheckBox = new System.Windows.Forms.CheckBox();
			this.downloadLocationPanel = new System.Windows.Forms.Panel();
			this.downloadLocation = new System.Windows.Forms.Button();
			this.downloadLocationTextBox = new System.Windows.Forms.TextBox();
			this.downloadTab = new System.Windows.Forms.TabPage();
			this.downloadPanel = new System.Windows.Forms.Panel();
			this.jobTable = new System.Windows.Forms.TableLayoutPanel();
			this.tableJobProgressLabel = new System.Windows.Forms.Label();
			this.tableJobPercentLabel = new System.Windows.Forms.Label();
			this.tableJobTitleLabel = new System.Windows.Forms.Label();
			this.forceCloseJobTableLabel = new System.Windows.Forms.Label();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.settingsButton = new System.Windows.Forms.Button();
			this.linkButton = new System.Windows.Forms.Button();
			this.linkTextBox = new System.Windows.Forms.TextBox();
			this.errorTab = new System.Windows.Forms.TabPage();
			this.errorContentPanel = new System.Windows.Forms.Panel();
			this.errorBodyLabel = new System.Windows.Forms.Label();
			this.errorTitlePanel = new System.Windows.Forms.Panel();
			this.errorTitle = new System.Windows.Forms.Label();
			this.errorCloseButton = new System.Windows.Forms.Button();
			this.icon = new System.Windows.Forms.PictureBox();
			this.titlebarPanel = new System.Windows.Forms.Panel();
			this.mainTitleLabel = new System.Windows.Forms.Label();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.closeAppButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.contentTabController.SuspendLayout();
			this.settingsTab.SuspendLayout();
			this.panel1.SuspendLayout();
			this.settingsPanel.SuspendLayout();
			this.logSettingsPanel.SuspendLayout();
			this.downloadLocationPanel.SuspendLayout();
			this.downloadTab.SuspendLayout();
			this.downloadPanel.SuspendLayout();
			this.jobTable.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.errorTab.SuspendLayout();
			this.errorContentPanel.SuspendLayout();
			this.errorTitlePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
			this.titlebarPanel.SuspendLayout();
			this.contentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// contentTabController
			// 
			this.contentTabController.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.contentTabController.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.contentTabController.Controls.Add(this.settingsTab);
			this.contentTabController.Controls.Add(this.downloadTab);
			this.contentTabController.Controls.Add(this.errorTab);
			this.contentTabController.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentTabController.Font = new System.Drawing.Font("Segoe UI", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.contentTabController.ItemSize = new System.Drawing.Size(0, 1);
			this.contentTabController.Location = new System.Drawing.Point(0, 0);
			this.contentTabController.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
			this.contentTabController.Multiline = true;
			this.contentTabController.Name = "contentTabController";
			this.contentTabController.Padding = new System.Drawing.Point(100, 100);
			this.contentTabController.SelectedIndex = 0;
			this.contentTabController.Size = new System.Drawing.Size(800, 424);
			this.contentTabController.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.contentTabController.TabIndex = 0;
			this.contentTabController.TabStop = false;
			// 
			// settingsTab
			// 
			this.settingsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.settingsTab.Controls.Add(this.panel1);
			this.settingsTab.Controls.Add(this.settingsPanel);
			this.settingsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.settingsTab.Location = new System.Drawing.Point(4, 5);
			this.settingsTab.Name = "settingsTab";
			this.settingsTab.Padding = new System.Windows.Forms.Padding(10);
			this.settingsTab.Size = new System.Drawing.Size(792, 415);
			this.settingsTab.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.settingsTabLabel);
			this.panel1.Controls.Add(this.downloadButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(772, 35);
			this.panel1.TabIndex = 0;
			// 
			// settingsTabLabel
			// 
			this.settingsTabLabel.AutoSize = true;
			this.settingsTabLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsTabLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.settingsTabLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.settingsTabLabel.Location = new System.Drawing.Point(0, 0);
			this.settingsTabLabel.MinimumSize = new System.Drawing.Size(700, 0);
			this.settingsTabLabel.Name = "settingsTabLabel";
			this.settingsTabLabel.Size = new System.Drawing.Size(700, 33);
			this.settingsTabLabel.TabIndex = 0;
			this.settingsTabLabel.Text = "            Settings";
			this.settingsTabLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// downloadButton
			// 
			this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.downloadButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.downloadButton.FlatAppearance.BorderSize = 0;
			this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downloadButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.downloadButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.downloadButton.Location = new System.Drawing.Point(703, 0);
			this.downloadButton.MinimumSize = new System.Drawing.Size(45, 30);
			this.downloadButton.Name = "downloadButton";
			this.downloadButton.Size = new System.Drawing.Size(69, 35);
			this.downloadButton.TabIndex = 1;
			this.downloadButton.Text = "Back";
			this.downloadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.downloadButton.UseVisualStyleBackColor = false;
			this.downloadButton.Click += new System.EventHandler(this.NavButtonClick);
			// 
			// settingsPanel
			// 
			this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.settingsPanel.Controls.Add(this.versionLabel);
			this.settingsPanel.Controls.Add(this.downloadLocationLabel);
			this.settingsPanel.Controls.Add(this.otherSettingsLabel);
			this.settingsPanel.Controls.Add(this.logSettingsPanel);
			this.settingsPanel.Controls.Add(this.downloadLocationPanel);
			this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.settingsPanel.Location = new System.Drawing.Point(10, 7);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Padding = new System.Windows.Forms.Padding(10);
			this.settingsPanel.Size = new System.Drawing.Size(772, 398);
			this.settingsPanel.TabIndex = 1;
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.versionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.versionLabel.Location = new System.Drawing.Point(10, 369);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(36, 19);
			this.versionLabel.TabIndex = 4;
			this.versionLabel.Text = "v0.1";
			// 
			// downloadLocationLabel
			// 
			this.downloadLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.downloadLocationLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.downloadLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.downloadLocationLabel.Location = new System.Drawing.Point(10, 10);
			this.downloadLocationLabel.Name = "downloadLocationLabel";
			this.downloadLocationLabel.Size = new System.Drawing.Size(752, 31);
			this.downloadLocationLabel.TabIndex = 0;
			this.downloadLocationLabel.Text = "Download Location";
			this.downloadLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// otherSettingsLabel
			// 
			this.otherSettingsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.otherSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.otherSettingsLabel.Location = new System.Drawing.Point(10, 71);
			this.otherSettingsLabel.Name = "otherSettingsLabel";
			this.otherSettingsLabel.Size = new System.Drawing.Size(616, 31);
			this.otherSettingsLabel.TabIndex = 3;
			this.otherSettingsLabel.Text = "Other Settings";
			this.otherSettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logSettingsPanel
			// 
			this.logSettingsPanel.Controls.Add(this.loggingCheckBox);
			this.logSettingsPanel.Location = new System.Drawing.Point(10, 100);
			this.logSettingsPanel.Name = "logSettingsPanel";
			this.logSettingsPanel.Padding = new System.Windows.Forms.Padding(10);
			this.logSettingsPanel.Size = new System.Drawing.Size(616, 43);
			this.logSettingsPanel.TabIndex = 2;
			// 
			// loggingCheckBox
			// 
			this.loggingCheckBox.AutoSize = true;
			this.loggingCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.loggingCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.loggingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loggingCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loggingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.loggingCheckBox.Location = new System.Drawing.Point(10, 10);
			this.loggingCheckBox.Name = "loggingCheckBox";
			this.loggingCheckBox.Size = new System.Drawing.Size(118, 23);
			this.loggingCheckBox.TabIndex = 1;
			this.loggingCheckBox.Text = "Keep Log Files";
			this.loggingCheckBox.UseVisualStyleBackColor = false;
			this.loggingCheckBox.CheckStateChanged += new System.EventHandler(this.loggingCheckBox_CheckStateChanged);
			// 
			// downloadLocationPanel
			// 
			this.downloadLocationPanel.Controls.Add(this.downloadLocation);
			this.downloadLocationPanel.Controls.Add(this.downloadLocationTextBox);
			this.downloadLocationPanel.Location = new System.Drawing.Point(10, 44);
			this.downloadLocationPanel.Name = "downloadLocationPanel";
			this.downloadLocationPanel.Size = new System.Drawing.Size(616, 26);
			this.downloadLocationPanel.TabIndex = 1;
			// 
			// downloadLocation
			// 
			this.downloadLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadLocation.Dock = System.Windows.Forms.DockStyle.Right;
			this.downloadLocation.FlatAppearance.BorderSize = 0;
			this.downloadLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downloadLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.downloadLocation.Location = new System.Drawing.Point(485, 0);
			this.downloadLocation.Margin = new System.Windows.Forms.Padding(0);
			this.downloadLocation.Name = "downloadLocation";
			this.downloadLocation.Size = new System.Drawing.Size(131, 26);
			this.downloadLocation.TabIndex = 1;
			this.downloadLocation.Text = "Change Location";
			this.downloadLocation.UseVisualStyleBackColor = false;
			this.downloadLocation.Click += new System.EventHandler(this.downloadLocation_Click);
			// 
			// downloadLocationTextBox
			// 
			this.downloadLocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.downloadLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.downloadLocationTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.downloadLocationTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.downloadLocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.downloadLocationTextBox.Location = new System.Drawing.Point(0, 0);
			this.downloadLocationTextBox.Name = "downloadLocationTextBox";
			this.downloadLocationTextBox.Size = new System.Drawing.Size(486, 26);
			this.downloadLocationTextBox.TabIndex = 0;
			this.downloadLocationTextBox.Text = "Download Location";
			this.downloadLocationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downloadLocationTextBox_KeyDown);
			// 
			// downloadTab
			// 
			this.downloadTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.downloadTab.Controls.Add(this.downloadPanel);
			this.downloadTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.downloadTab.Location = new System.Drawing.Point(4, 5);
			this.downloadTab.Margin = new System.Windows.Forms.Padding(0);
			this.downloadTab.Name = "downloadTab";
			this.downloadTab.Padding = new System.Windows.Forms.Padding(10);
			this.downloadTab.Size = new System.Drawing.Size(792, 415);
			this.downloadTab.TabIndex = 0;
			// 
			// downloadPanel
			// 
			this.downloadPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.downloadPanel.Controls.Add(this.jobTable);
			this.downloadPanel.Controls.Add(this.searchPanel);
			this.downloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.downloadPanel.Location = new System.Drawing.Point(10, 10);
			this.downloadPanel.Name = "downloadPanel";
			this.downloadPanel.Size = new System.Drawing.Size(772, 395);
			this.downloadPanel.TabIndex = 0;
			// 
			// jobTable
			// 
			this.jobTable.AutoScroll = true;
			this.jobTable.BackColor = System.Drawing.Color.Transparent;
			this.jobTable.ColumnCount = 4;
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.jobTable.Controls.Add(this.tableJobProgressLabel, 2, 0);
			this.jobTable.Controls.Add(this.tableJobPercentLabel, 1, 0);
			this.jobTable.Controls.Add(this.tableJobTitleLabel, 0, 0);
			this.jobTable.Controls.Add(this.forceCloseJobTableLabel, 3, 0);
			this.jobTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jobTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.jobTable.Location = new System.Drawing.Point(0, 28);
			this.jobTable.Margin = new System.Windows.Forms.Padding(0);
			this.jobTable.MinimumSize = new System.Drawing.Size(500, 100);
			this.jobTable.Name = "jobTable";
			this.jobTable.RowCount = 2;
			this.jobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.jobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.jobTable.Size = new System.Drawing.Size(772, 367);
			this.jobTable.TabIndex = 2;
			// 
			// tableJobProgressLabel
			// 
			this.tableJobProgressLabel.AutoSize = true;
			this.tableJobProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.tableJobProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobProgressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobProgressLabel.Location = new System.Drawing.Point(580, 0);
			this.tableJobProgressLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tableJobProgressLabel.Name = "tableJobProgressLabel";
			this.tableJobProgressLabel.Size = new System.Drawing.Size(110, 32);
			this.tableJobProgressLabel.TabIndex = 2;
			this.tableJobProgressLabel.Text = "Progress";
			this.tableJobProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableJobPercentLabel
			// 
			this.tableJobPercentLabel.AutoSize = true;
			this.tableJobPercentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.tableJobPercentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobPercentLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobPercentLabel.Location = new System.Drawing.Point(500, 0);
			this.tableJobPercentLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tableJobPercentLabel.Name = "tableJobPercentLabel";
			this.tableJobPercentLabel.Size = new System.Drawing.Size(80, 32);
			this.tableJobPercentLabel.TabIndex = 1;
			this.tableJobPercentLabel.Text = "Percent";
			this.tableJobPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableJobTitleLabel
			// 
			this.tableJobTitleLabel.AutoSize = true;
			this.tableJobTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.tableJobTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobTitleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobTitleLabel.Location = new System.Drawing.Point(0, 0);
			this.tableJobTitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tableJobTitleLabel.Name = "tableJobTitleLabel";
			this.tableJobTitleLabel.Size = new System.Drawing.Size(500, 32);
			this.tableJobTitleLabel.TabIndex = 0;
			this.tableJobTitleLabel.Text = "Video Title";
			this.tableJobTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// forceCloseJobTableLabel
			// 
			this.forceCloseJobTableLabel.AutoSize = true;
			this.forceCloseJobTableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.forceCloseJobTableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forceCloseJobTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.forceCloseJobTableLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.forceCloseJobTableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.forceCloseJobTableLabel.Location = new System.Drawing.Point(690, 0);
			this.forceCloseJobTableLabel.Margin = new System.Windows.Forms.Padding(0);
			this.forceCloseJobTableLabel.Name = "forceCloseJobTableLabel";
			this.forceCloseJobTableLabel.Size = new System.Drawing.Size(82, 32);
			this.forceCloseJobTableLabel.TabIndex = 3;
			this.forceCloseJobTableLabel.Text = "Close";
			this.forceCloseJobTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// searchPanel
			// 
			this.searchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.searchPanel.Controls.Add(this.settingsButton);
			this.searchPanel.Controls.Add(this.linkButton);
			this.searchPanel.Controls.Add(this.linkTextBox);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
			this.searchPanel.MinimumSize = new System.Drawing.Size(0, 24);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(772, 28);
			this.searchPanel.TabIndex = 1;
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.settingsButton.BackgroundImage = global::Video_Downloader.Properties.Resources.gear;
			this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.settingsButton.FlatAppearance.BorderSize = 0;
			this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.settingsButton.Location = new System.Drawing.Point(744, 0);
			this.settingsButton.MinimumSize = new System.Drawing.Size(28, 28);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(28, 28);
			this.settingsButton.TabIndex = 1;
			this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.NavButtonClick);
			// 
			// linkButton
			// 
			this.linkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.linkButton.FlatAppearance.BorderSize = 0;
			this.linkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.linkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.linkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.linkButton.Location = new System.Drawing.Point(663, 0);
			this.linkButton.Name = "linkButton";
			this.linkButton.Size = new System.Drawing.Size(75, 28);
			this.linkButton.TabIndex = 1;
			this.linkButton.Text = "Download";
			this.linkButton.UseVisualStyleBackColor = false;
			this.linkButton.Click += new System.EventHandler(this.linkButton_Click);
			// 
			// linkTextBox
			// 
			this.linkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.linkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.linkTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.linkTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.linkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.linkTextBox.Location = new System.Drawing.Point(0, 0);
			this.linkTextBox.MinimumSize = new System.Drawing.Size(480, 30);
			this.linkTextBox.Name = "linkTextBox";
			this.linkTextBox.Size = new System.Drawing.Size(667, 30);
			this.linkTextBox.TabIndex = 0;
			// 
			// errorTab
			// 
			this.errorTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
			this.errorTab.Controls.Add(this.errorContentPanel);
			this.errorTab.Controls.Add(this.errorTitlePanel);
			this.errorTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.errorTab.Location = new System.Drawing.Point(4, 5);
			this.errorTab.Name = "errorTab";
			this.errorTab.Padding = new System.Windows.Forms.Padding(3);
			this.errorTab.Size = new System.Drawing.Size(792, 415);
			this.errorTab.TabIndex = 2;
			this.errorTab.Text = "tabPage1";
			// 
			// errorContentPanel
			// 
			this.errorContentPanel.BackColor = System.Drawing.Color.Transparent;
			this.errorContentPanel.Controls.Add(this.errorBodyLabel);
			this.errorContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorContentPanel.Location = new System.Drawing.Point(3, 39);
			this.errorContentPanel.Name = "errorContentPanel";
			this.errorContentPanel.Padding = new System.Windows.Forms.Padding(20);
			this.errorContentPanel.Size = new System.Drawing.Size(786, 373);
			this.errorContentPanel.TabIndex = 3;
			// 
			// errorBodyLabel
			// 
			this.errorBodyLabel.AutoSize = true;
			this.errorBodyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorBodyLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.errorBodyLabel.Location = new System.Drawing.Point(20, 20);
			this.errorBodyLabel.Name = "errorBodyLabel";
			this.errorBodyLabel.Size = new System.Drawing.Size(376, 23);
			this.errorBodyLabel.TabIndex = 0;
			this.errorBodyLabel.Text = "This is an example of something bad happening.";
			// 
			// errorTitlePanel
			// 
			this.errorTitlePanel.BackColor = System.Drawing.Color.Transparent;
			this.errorTitlePanel.Controls.Add(this.errorTitle);
			this.errorTitlePanel.Controls.Add(this.errorCloseButton);
			this.errorTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.errorTitlePanel.Location = new System.Drawing.Point(3, 3);
			this.errorTitlePanel.Name = "errorTitlePanel";
			this.errorTitlePanel.Size = new System.Drawing.Size(786, 36);
			this.errorTitlePanel.TabIndex = 2;
			// 
			// errorTitle
			// 
			this.errorTitle.BackColor = System.Drawing.Color.Transparent;
			this.errorTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.errorTitle.Location = new System.Drawing.Point(0, 0);
			this.errorTitle.Name = "errorTitle";
			this.errorTitle.Size = new System.Drawing.Size(741, 36);
			this.errorTitle.TabIndex = 0;
			this.errorTitle.Text = "Hey, something happened...";
			this.errorTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorCloseButton
			// 
			this.errorCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.errorCloseButton.FlatAppearance.BorderSize = 0;
			this.errorCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.errorCloseButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.errorCloseButton.Location = new System.Drawing.Point(741, 0);
			this.errorCloseButton.Margin = new System.Windows.Forms.Padding(0);
			this.errorCloseButton.Name = "errorCloseButton";
			this.errorCloseButton.Size = new System.Drawing.Size(45, 36);
			this.errorCloseButton.TabIndex = 1;
			this.errorCloseButton.Text = "X";
			this.errorCloseButton.UseVisualStyleBackColor = true;
			this.errorCloseButton.Click += new System.EventHandler(this.errorCloseButton_Click);
			// 
			// icon
			// 
			this.icon.BackColor = System.Drawing.Color.Transparent;
			this.icon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.icon.Image = global::Video_Downloader.Properties.Resources.logo1;
			this.icon.Location = new System.Drawing.Point(0, 38);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(800, 138);
			this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.icon.TabIndex = 0;
			this.icon.TabStop = false;
			// 
			// titlebarPanel
			// 
			this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.titlebarPanel.Controls.Add(this.mainTitleLabel);
			this.titlebarPanel.Controls.Add(this.minimizeButton);
			this.titlebarPanel.Controls.Add(this.closeAppButton);
			this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
			this.titlebarPanel.MinimumSize = new System.Drawing.Size(0, 38);
			this.titlebarPanel.Name = "titlebarPanel";
			this.titlebarPanel.Size = new System.Drawing.Size(800, 38);
			this.titlebarPanel.TabIndex = 1;
			this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// mainTitleLabel
			// 
			this.mainTitleLabel.AutoSize = true;
			this.mainTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTitleLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.mainTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.mainTitleLabel.Location = new System.Drawing.Point(0, 0);
			this.mainTitleLabel.MinimumSize = new System.Drawing.Size(750, 0);
			this.mainTitleLabel.Name = "mainTitleLabel";
			this.mainTitleLabel.Size = new System.Drawing.Size(750, 39);
			this.mainTitleLabel.TabIndex = 0;
			this.mainTitleLabel.Text = "         Simple Downloader";
			this.mainTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mainTitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// minimizeButton
			// 
			this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.minimizeButton.Location = new System.Drawing.Point(748, 0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(26, 38);
			this.minimizeButton.TabIndex = 1;
			this.minimizeButton.Text = "-";
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
			// 
			// closeAppButton
			// 
			this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeAppButton.FlatAppearance.BorderSize = 0;
			this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeAppButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.closeAppButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.closeAppButton.Location = new System.Drawing.Point(774, 0);
			this.closeAppButton.Name = "closeAppButton";
			this.closeAppButton.Size = new System.Drawing.Size(26, 38);
			this.closeAppButton.TabIndex = 1;
			this.closeAppButton.Text = "X";
			this.closeAppButton.UseVisualStyleBackColor = true;
			this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
			// 
			// contentPanel
			// 
			this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.contentPanel.Controls.Add(this.contentTabController);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.contentPanel.Location = new System.Drawing.Point(0, 176);
			this.contentPanel.Margin = new System.Windows.Forms.Padding(20);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(800, 424);
			this.contentPanel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.icon);
			this.Controls.Add(this.contentPanel);
			this.Controls.Add(this.titlebarPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleDownloader";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contentTabController.ResumeLayout(false);
			this.settingsTab.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.settingsPanel.ResumeLayout(false);
			this.settingsPanel.PerformLayout();
			this.logSettingsPanel.ResumeLayout(false);
			this.logSettingsPanel.PerformLayout();
			this.downloadLocationPanel.ResumeLayout(false);
			this.downloadLocationPanel.PerformLayout();
			this.downloadTab.ResumeLayout(false);
			this.downloadPanel.ResumeLayout(false);
			this.jobTable.ResumeLayout(false);
			this.jobTable.PerformLayout();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.errorTab.ResumeLayout(false);
			this.errorContentPanel.ResumeLayout(false);
			this.errorContentPanel.PerformLayout();
			this.errorTitlePanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
			this.titlebarPanel.ResumeLayout(false);
			this.titlebarPanel.PerformLayout();
			this.contentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox icon;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.Panel titlebarPanel;
		private System.Windows.Forms.Button closeAppButton;
		private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Panel downloadPanel;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Panel searchPanel;
		private System.Windows.Forms.TextBox linkTextBox;
		private System.Windows.Forms.Button linkButton;
		private System.Windows.Forms.TabPage downloadTab;
		private System.Windows.Forms.TabPage settingsTab;
		private System.Windows.Forms.TabControl contentTabController;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.TabPage errorTab;
		private System.Windows.Forms.Label errorTitle;
		private System.Windows.Forms.Panel errorTitlePanel;
		private System.Windows.Forms.Button errorCloseButton;
		private System.Windows.Forms.Panel errorContentPanel;
		private System.Windows.Forms.Label errorBodyLabel;
		private System.Windows.Forms.Panel downloadLocationPanel;
		private System.Windows.Forms.TextBox downloadLocationTextBox;
		private System.Windows.Forms.Button downloadLocation;
		private System.Windows.Forms.Panel logSettingsPanel;
		private System.Windows.Forms.CheckBox loggingCheckBox;
		private System.Windows.Forms.TableLayoutPanel jobTable;
		private System.Windows.Forms.Label tableJobProgressLabel;
		private System.Windows.Forms.Label tableJobPercentLabel;
		private System.Windows.Forms.Label tableJobTitleLabel;
		private System.Windows.Forms.Label forceCloseJobTableLabel;
		private System.Windows.Forms.Label downloadLocationLabel;
		private System.Windows.Forms.Label otherSettingsLabel;
		private System.Windows.Forms.Button downloadButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label mainTitleLabel;
		private System.Windows.Forms.Label settingsTabLabel;
		private System.Windows.Forms.Label versionLabel;
	}
}

