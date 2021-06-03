
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
			this.downloadTab = new System.Windows.Forms.TabPage();
			this.downloadPanel = new System.Windows.Forms.Panel();
			this.jobTable = new System.Windows.Forms.TableLayoutPanel();
			this.tableJobProgressLabel = new System.Windows.Forms.Label();
			this.tableJobPercentLabel = new System.Windows.Forms.Label();
			this.tableJobTitleLabel = new System.Windows.Forms.Label();
			this.forceCloseJobTableLabel = new System.Windows.Forms.Label();
			this.searchPanel = new System.Windows.Forms.Panel();
			this.linkButton = new System.Windows.Forms.Button();
			this.linkTextBox = new System.Windows.Forms.TextBox();
			this.formatDownloadComboBox = new System.Windows.Forms.ComboBox();
			this.settingsTab = new System.Windows.Forms.TabPage();
			this.settingsPanel = new System.Windows.Forms.Panel();
			this.downloadLocationLabel = new System.Windows.Forms.Label();
			this.otherSettingsLabel = new System.Windows.Forms.Label();
			this.logSettingsPanel = new System.Windows.Forms.Panel();
			this.loggingCheckBox = new System.Windows.Forms.CheckBox();
			this.downloadLocationPanel = new System.Windows.Forms.Panel();
			this.downloadLocation = new System.Windows.Forms.Button();
			this.downloadLocationTextBox = new System.Windows.Forms.TextBox();
			this.errorTab = new System.Windows.Forms.TabPage();
			this.errorContentPanel = new System.Windows.Forms.Panel();
			this.errorBodyLabel = new System.Windows.Forms.Label();
			this.errorTitlePanel = new System.Windows.Forms.Panel();
			this.errorTitle = new System.Windows.Forms.Label();
			this.errorCloseButton = new System.Windows.Forms.Button();
			this.convertTab = new System.Windows.Forms.TabPage();
			this.convertContentPanel = new System.Windows.Forms.Panel();
			this.convertOutputPanel = new System.Windows.Forms.Panel();
			this.convertStartButton = new System.Windows.Forms.Button();
			this.convertExtensionComboBox = new System.Windows.Forms.ComboBox();
			this.convertOutputLocationPanel = new System.Windows.Forms.Panel();
			this.convertOutputLocationButton = new System.Windows.Forms.Button();
			this.convertOutputLocationTextBox = new System.Windows.Forms.TextBox();
			this.convertOutputLabel = new System.Windows.Forms.Label();
			this.convertInputPanel = new System.Windows.Forms.Panel();
			this.convertInputLocationPanel = new System.Windows.Forms.Panel();
			this.convertInputSelectFileButton = new System.Windows.Forms.Button();
			this.convertInputFileLocationTextBox = new System.Windows.Forms.TextBox();
			this.convertInputLabel = new System.Windows.Forms.Label();
			this.convertJobTable = new System.Windows.Forms.TableLayoutPanel();
			this.convertJobStatusLabel = new System.Windows.Forms.Label();
			this.convertJobTimeLabel = new System.Windows.Forms.Label();
			this.convertJobTitleLabel = new System.Windows.Forms.Label();
			this.convertJobCancelLabel = new System.Windows.Forms.Label();
			this.leftMenuPanel = new System.Windows.Forms.Panel();
			this.buttonContainer = new System.Windows.Forms.Panel();
			this.settingsButton = new System.Windows.Forms.Button();
			this.convertNavButton = new System.Windows.Forms.Button();
			this.panelNav = new System.Windows.Forms.Panel();
			this.downloadButton = new System.Windows.Forms.Button();
			this.iconTitlePanel = new System.Windows.Forms.Panel();
			this.icon = new System.Windows.Forms.PictureBox();
			this.titleLable = new System.Windows.Forms.Label();
			this.titlebarPanel = new System.Windows.Forms.Panel();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.closeAppButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.contentTabController.SuspendLayout();
			this.downloadTab.SuspendLayout();
			this.downloadPanel.SuspendLayout();
			this.jobTable.SuspendLayout();
			this.searchPanel.SuspendLayout();
			this.settingsTab.SuspendLayout();
			this.settingsPanel.SuspendLayout();
			this.logSettingsPanel.SuspendLayout();
			this.downloadLocationPanel.SuspendLayout();
			this.errorTab.SuspendLayout();
			this.errorContentPanel.SuspendLayout();
			this.errorTitlePanel.SuspendLayout();
			this.convertTab.SuspendLayout();
			this.convertContentPanel.SuspendLayout();
			this.convertOutputPanel.SuspendLayout();
			this.convertOutputLocationPanel.SuspendLayout();
			this.convertInputPanel.SuspendLayout();
			this.convertInputLocationPanel.SuspendLayout();
			this.convertJobTable.SuspendLayout();
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
			this.contentTabController.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.contentTabController.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.contentTabController.Controls.Add(this.downloadTab);
			this.contentTabController.Controls.Add(this.settingsTab);
			this.contentTabController.Controls.Add(this.errorTab);
			this.contentTabController.Controls.Add(this.convertTab);
			this.contentTabController.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentTabController.Font = new System.Drawing.Font("Segoe UI", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.contentTabController.ItemSize = new System.Drawing.Size(0, 1);
			this.contentTabController.Location = new System.Drawing.Point(0, 0);
			this.contentTabController.Multiline = true;
			this.contentTabController.Name = "contentTabController";
			this.contentTabController.Padding = new System.Drawing.Point(0, 0);
			this.contentTabController.SelectedIndex = 0;
			this.contentTabController.Size = new System.Drawing.Size(650, 562);
			this.contentTabController.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.contentTabController.TabIndex = 0;
			this.contentTabController.TabStop = false;
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
			this.downloadPanel.Controls.Add(this.jobTable);
			this.downloadPanel.Controls.Add(this.searchPanel);
			this.downloadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.downloadPanel.Location = new System.Drawing.Point(10, 10);
			this.downloadPanel.Name = "downloadPanel";
			this.downloadPanel.Size = new System.Drawing.Size(622, 533);
			this.downloadPanel.TabIndex = 0;
			// 
			// jobTable
			// 
			this.jobTable.AutoScroll = true;
			this.jobTable.BackColor = System.Drawing.Color.Transparent;
			this.jobTable.ColumnCount = 4;
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.jobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.jobTable.Controls.Add(this.tableJobProgressLabel, 2, 0);
			this.jobTable.Controls.Add(this.tableJobPercentLabel, 1, 0);
			this.jobTable.Controls.Add(this.tableJobTitleLabel, 0, 0);
			this.jobTable.Controls.Add(this.forceCloseJobTableLabel, 3, 0);
			this.jobTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jobTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.jobTable.Location = new System.Drawing.Point(0, 27);
			this.jobTable.Margin = new System.Windows.Forms.Padding(0);
			this.jobTable.MinimumSize = new System.Drawing.Size(622, 500);
			this.jobTable.Name = "jobTable";
			this.jobTable.RowCount = 2;
			this.jobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.jobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.jobTable.Size = new System.Drawing.Size(622, 506);
			this.jobTable.TabIndex = 2;
			// 
			// tableJobProgressLabel
			// 
			this.tableJobProgressLabel.AutoSize = true;
			this.tableJobProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.tableJobProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobProgressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobProgressLabel.Location = new System.Drawing.Point(440, 0);
			this.tableJobProgressLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tableJobProgressLabel.Name = "tableJobProgressLabel";
			this.tableJobProgressLabel.Size = new System.Drawing.Size(120, 32);
			this.tableJobProgressLabel.TabIndex = 2;
			this.tableJobProgressLabel.Text = "Progress";
			this.tableJobProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableJobPercentLabel
			// 
			this.tableJobPercentLabel.AutoSize = true;
			this.tableJobPercentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.tableJobPercentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobPercentLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobPercentLabel.Location = new System.Drawing.Point(360, 0);
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
			this.tableJobTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.tableJobTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableJobTitleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.tableJobTitleLabel.Location = new System.Drawing.Point(0, 0);
			this.tableJobTitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.tableJobTitleLabel.Name = "tableJobTitleLabel";
			this.tableJobTitleLabel.Size = new System.Drawing.Size(360, 32);
			this.tableJobTitleLabel.TabIndex = 0;
			this.tableJobTitleLabel.Text = "Video Title";
			this.tableJobTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// forceCloseJobTableLabel
			// 
			this.forceCloseJobTableLabel.AutoSize = true;
			this.forceCloseJobTableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.forceCloseJobTableLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.forceCloseJobTableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.forceCloseJobTableLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.forceCloseJobTableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.forceCloseJobTableLabel.Location = new System.Drawing.Point(560, 0);
			this.forceCloseJobTableLabel.Margin = new System.Windows.Forms.Padding(0);
			this.forceCloseJobTableLabel.Name = "forceCloseJobTableLabel";
			this.forceCloseJobTableLabel.Size = new System.Drawing.Size(62, 32);
			this.forceCloseJobTableLabel.TabIndex = 3;
			this.forceCloseJobTableLabel.Text = "Close";
			this.forceCloseJobTableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// searchPanel
			// 
			this.searchPanel.Controls.Add(this.linkButton);
			this.searchPanel.Controls.Add(this.linkTextBox);
			this.searchPanel.Controls.Add(this.formatDownloadComboBox);
			this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchPanel.Location = new System.Drawing.Point(0, 0);
			this.searchPanel.Margin = new System.Windows.Forms.Padding(0);
			this.searchPanel.MinimumSize = new System.Drawing.Size(0, 24);
			this.searchPanel.Name = "searchPanel";
			this.searchPanel.Size = new System.Drawing.Size(622, 27);
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
			this.linkButton.Size = new System.Drawing.Size(75, 27);
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
			this.linkTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.linkTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.linkTextBox.Location = new System.Drawing.Point(0, 0);
			this.linkTextBox.MinimumSize = new System.Drawing.Size(480, 24);
			this.linkTextBox.Name = "linkTextBox";
			this.linkTextBox.Size = new System.Drawing.Size(480, 26);
			this.linkTextBox.TabIndex = 0;
			// 
			// formatDownloadComboBox
			// 
			this.formatDownloadComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.formatDownloadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.formatDownloadComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.formatDownloadComboBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.formatDownloadComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.formatDownloadComboBox.FormattingEnabled = true;
			this.formatDownloadComboBox.Location = new System.Drawing.Point(486, 1);
			this.formatDownloadComboBox.Name = "formatDownloadComboBox";
			this.formatDownloadComboBox.Size = new System.Drawing.Size(55, 26);
			this.formatDownloadComboBox.TabIndex = 2;
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
			this.settingsPanel.Controls.Add(this.downloadLocationLabel);
			this.settingsPanel.Controls.Add(this.otherSettingsLabel);
			this.settingsPanel.Controls.Add(this.logSettingsPanel);
			this.settingsPanel.Controls.Add(this.downloadLocationPanel);
			this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.settingsPanel.Location = new System.Drawing.Point(3, 3);
			this.settingsPanel.Name = "settingsPanel";
			this.settingsPanel.Padding = new System.Windows.Forms.Padding(10);
			this.settingsPanel.Size = new System.Drawing.Size(636, 547);
			this.settingsPanel.TabIndex = 1;
			// 
			// downloadLocationLabel
			// 
			this.downloadLocationLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.downloadLocationLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.downloadLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.downloadLocationLabel.Location = new System.Drawing.Point(10, 10);
			this.downloadLocationLabel.Name = "downloadLocationLabel";
			this.downloadLocationLabel.Size = new System.Drawing.Size(616, 31);
			this.downloadLocationLabel.TabIndex = 0;
			this.downloadLocationLabel.Text = "Download Location";
			this.downloadLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// otherSettingsLabel
			// 
			this.otherSettingsLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.otherSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
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
			this.loggingCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.loggingCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.loggingCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loggingCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loggingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
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
			this.downloadLocationPanel.Size = new System.Drawing.Size(616, 27);
			this.downloadLocationPanel.TabIndex = 1;
			// 
			// downloadLocation
			// 
			this.downloadLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.downloadLocation.Dock = System.Windows.Forms.DockStyle.Right;
			this.downloadLocation.FlatAppearance.BorderSize = 0;
			this.downloadLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.downloadLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.downloadLocation.Location = new System.Drawing.Point(485, 0);
			this.downloadLocation.Margin = new System.Windows.Forms.Padding(0);
			this.downloadLocation.Name = "downloadLocation";
			this.downloadLocation.Size = new System.Drawing.Size(131, 27);
			this.downloadLocation.TabIndex = 1;
			this.downloadLocation.Text = "Change Location";
			this.downloadLocation.UseVisualStyleBackColor = false;
			this.downloadLocation.Click += new System.EventHandler(this.downloadLocation_Click);
			// 
			// downloadLocationTextBox
			// 
			this.downloadLocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.downloadLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.downloadLocationTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.downloadLocationTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.downloadLocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.downloadLocationTextBox.Location = new System.Drawing.Point(0, 0);
			this.downloadLocationTextBox.Name = "downloadLocationTextBox";
			this.downloadLocationTextBox.Size = new System.Drawing.Size(479, 26);
			this.downloadLocationTextBox.TabIndex = 0;
			this.downloadLocationTextBox.Text = "Download Location";
			this.downloadLocationTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.downloadLocationTextBox_KeyDown);
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
			this.errorTab.Size = new System.Drawing.Size(642, 553);
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
			this.errorContentPanel.Size = new System.Drawing.Size(636, 511);
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
			this.errorTitlePanel.Size = new System.Drawing.Size(636, 36);
			this.errorTitlePanel.TabIndex = 2;
			// 
			// errorTitle
			// 
			this.errorTitle.BackColor = System.Drawing.Color.Transparent;
			this.errorTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.errorTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.errorTitle.Location = new System.Drawing.Point(0, 0);
			this.errorTitle.Name = "errorTitle";
			this.errorTitle.Size = new System.Drawing.Size(591, 36);
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
			this.errorCloseButton.Location = new System.Drawing.Point(591, 0);
			this.errorCloseButton.Margin = new System.Windows.Forms.Padding(0);
			this.errorCloseButton.Name = "errorCloseButton";
			this.errorCloseButton.Size = new System.Drawing.Size(45, 36);
			this.errorCloseButton.TabIndex = 1;
			this.errorCloseButton.Text = "X";
			this.errorCloseButton.UseVisualStyleBackColor = true;
			this.errorCloseButton.Click += new System.EventHandler(this.errorCloseButton_Click);
			// 
			// convertTab
			// 
			this.convertTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.convertTab.Controls.Add(this.convertContentPanel);
			this.convertTab.Controls.Add(this.convertJobTable);
			this.convertTab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.convertTab.Location = new System.Drawing.Point(4, 5);
			this.convertTab.Name = "convertTab";
			this.convertTab.Padding = new System.Windows.Forms.Padding(3);
			this.convertTab.Size = new System.Drawing.Size(642, 553);
			this.convertTab.TabIndex = 3;
			// 
			// convertContentPanel
			// 
			this.convertContentPanel.Controls.Add(this.convertOutputPanel);
			this.convertContentPanel.Controls.Add(this.convertInputPanel);
			this.convertContentPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertContentPanel.Location = new System.Drawing.Point(3, 3);
			this.convertContentPanel.Name = "convertContentPanel";
			this.convertContentPanel.Size = new System.Drawing.Size(636, 244);
			this.convertContentPanel.TabIndex = 4;
			// 
			// convertOutputPanel
			// 
			this.convertOutputPanel.Controls.Add(this.convertStartButton);
			this.convertOutputPanel.Controls.Add(this.convertExtensionComboBox);
			this.convertOutputPanel.Controls.Add(this.convertOutputLocationPanel);
			this.convertOutputPanel.Controls.Add(this.convertOutputLabel);
			this.convertOutputPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.convertOutputPanel.Location = new System.Drawing.Point(0, 63);
			this.convertOutputPanel.Name = "convertOutputPanel";
			this.convertOutputPanel.Size = new System.Drawing.Size(636, 181);
			this.convertOutputPanel.TabIndex = 1;
			// 
			// convertStartButton
			// 
			this.convertStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertStartButton.FlatAppearance.BorderSize = 0;
			this.convertStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertStartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertStartButton.Location = new System.Drawing.Point(105, 88);
			this.convertStartButton.Margin = new System.Windows.Forms.Padding(0);
			this.convertStartButton.Name = "convertStartButton";
			this.convertStartButton.Size = new System.Drawing.Size(129, 27);
			this.convertStartButton.TabIndex = 4;
			this.convertStartButton.Text = "Start Conversion";
			this.convertStartButton.UseVisualStyleBackColor = false;
			this.convertStartButton.Click += new System.EventHandler(this.convertStartButtonClick);
			// 
			// convertExtensionComboBox
			// 
			this.convertExtensionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.convertExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.convertExtensionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertExtensionComboBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertExtensionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertExtensionComboBox.FormattingEnabled = true;
			this.convertExtensionComboBox.Location = new System.Drawing.Point(13, 88);
			this.convertExtensionComboBox.Name = "convertExtensionComboBox";
			this.convertExtensionComboBox.Size = new System.Drawing.Size(64, 26);
			this.convertExtensionComboBox.TabIndex = 3;
			// 
			// convertOutputLocationPanel
			// 
			this.convertOutputLocationPanel.Controls.Add(this.convertOutputLocationButton);
			this.convertOutputLocationPanel.Controls.Add(this.convertOutputLocationTextBox);
			this.convertOutputLocationPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertOutputLocationPanel.Location = new System.Drawing.Point(0, 31);
			this.convertOutputLocationPanel.Name = "convertOutputLocationPanel";
			this.convertOutputLocationPanel.Size = new System.Drawing.Size(636, 27);
			this.convertOutputLocationPanel.TabIndex = 2;
			// 
			// convertOutputLocationButton
			// 
			this.convertOutputLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertOutputLocationButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.convertOutputLocationButton.FlatAppearance.BorderSize = 0;
			this.convertOutputLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertOutputLocationButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertOutputLocationButton.Location = new System.Drawing.Point(536, 0);
			this.convertOutputLocationButton.Margin = new System.Windows.Forms.Padding(0);
			this.convertOutputLocationButton.Name = "convertOutputLocationButton";
			this.convertOutputLocationButton.Size = new System.Drawing.Size(100, 27);
			this.convertOutputLocationButton.TabIndex = 1;
			this.convertOutputLocationButton.Text = "Select Folder";
			this.convertOutputLocationButton.UseVisualStyleBackColor = false;
			this.convertOutputLocationButton.Click += new System.EventHandler(this.convertOutputLocationButtonClick);
			// 
			// convertOutputLocationTextBox
			// 
			this.convertOutputLocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.convertOutputLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.convertOutputLocationTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.convertOutputLocationTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertOutputLocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertOutputLocationTextBox.Location = new System.Drawing.Point(0, 0);
			this.convertOutputLocationTextBox.Name = "convertOutputLocationTextBox";
			this.convertOutputLocationTextBox.Size = new System.Drawing.Size(523, 26);
			this.convertOutputLocationTextBox.TabIndex = 0;
			this.convertOutputLocationTextBox.Text = "Output Folder Location";
			// 
			// convertOutputLabel
			// 
			this.convertOutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertOutputLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.convertOutputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertOutputLabel.Location = new System.Drawing.Point(0, 0);
			this.convertOutputLabel.Name = "convertOutputLabel";
			this.convertOutputLabel.Size = new System.Drawing.Size(636, 31);
			this.convertOutputLabel.TabIndex = 1;
			this.convertOutputLabel.Text = "Output";
			this.convertOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// convertInputPanel
			// 
			this.convertInputPanel.Controls.Add(this.convertInputLocationPanel);
			this.convertInputPanel.Controls.Add(this.convertInputLabel);
			this.convertInputPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertInputPanel.Location = new System.Drawing.Point(0, 0);
			this.convertInputPanel.Name = "convertInputPanel";
			this.convertInputPanel.Size = new System.Drawing.Size(636, 60);
			this.convertInputPanel.TabIndex = 0;
			// 
			// convertInputLocationPanel
			// 
			this.convertInputLocationPanel.Controls.Add(this.convertInputSelectFileButton);
			this.convertInputLocationPanel.Controls.Add(this.convertInputFileLocationTextBox);
			this.convertInputLocationPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertInputLocationPanel.Location = new System.Drawing.Point(0, 31);
			this.convertInputLocationPanel.Name = "convertInputLocationPanel";
			this.convertInputLocationPanel.Size = new System.Drawing.Size(636, 27);
			this.convertInputLocationPanel.TabIndex = 1;
			// 
			// convertInputSelectFileButton
			// 
			this.convertInputSelectFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertInputSelectFileButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.convertInputSelectFileButton.FlatAppearance.BorderSize = 0;
			this.convertInputSelectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertInputSelectFileButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertInputSelectFileButton.Location = new System.Drawing.Point(548, 0);
			this.convertInputSelectFileButton.Margin = new System.Windows.Forms.Padding(0);
			this.convertInputSelectFileButton.Name = "convertInputSelectFileButton";
			this.convertInputSelectFileButton.Size = new System.Drawing.Size(88, 27);
			this.convertInputSelectFileButton.TabIndex = 1;
			this.convertInputSelectFileButton.Text = "Select File";
			this.convertInputSelectFileButton.UseVisualStyleBackColor = false;
			this.convertInputSelectFileButton.Click += new System.EventHandler(this.convertInputSelectFileButtonClick);
			// 
			// convertInputFileLocationTextBox
			// 
			this.convertInputFileLocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.convertInputFileLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.convertInputFileLocationTextBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.convertInputFileLocationTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertInputFileLocationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertInputFileLocationTextBox.Location = new System.Drawing.Point(0, 0);
			this.convertInputFileLocationTextBox.Name = "convertInputFileLocationTextBox";
			this.convertInputFileLocationTextBox.Size = new System.Drawing.Size(523, 26);
			this.convertInputFileLocationTextBox.TabIndex = 0;
			this.convertInputFileLocationTextBox.Text = "Input File Location";
			// 
			// convertInputLabel
			// 
			this.convertInputLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertInputLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.convertInputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertInputLabel.Location = new System.Drawing.Point(0, 0);
			this.convertInputLabel.Name = "convertInputLabel";
			this.convertInputLabel.Size = new System.Drawing.Size(636, 31);
			this.convertInputLabel.TabIndex = 0;
			this.convertInputLabel.Text = "Input";
			this.convertInputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// convertJobTable
			// 
			this.convertJobTable.AutoScroll = true;
			this.convertJobTable.BackColor = System.Drawing.Color.Transparent;
			this.convertJobTable.ColumnCount = 4;
			this.convertJobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
			this.convertJobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.convertJobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.convertJobTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
			this.convertJobTable.Controls.Add(this.convertJobStatusLabel, 2, 0);
			this.convertJobTable.Controls.Add(this.convertJobTimeLabel, 1, 0);
			this.convertJobTable.Controls.Add(this.convertJobTitleLabel, 0, 0);
			this.convertJobTable.Controls.Add(this.convertJobCancelLabel, 3, 0);
			this.convertJobTable.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.convertJobTable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertJobTable.Location = new System.Drawing.Point(3, 250);
			this.convertJobTable.Margin = new System.Windows.Forms.Padding(0);
			this.convertJobTable.MinimumSize = new System.Drawing.Size(622, 300);
			this.convertJobTable.Name = "convertJobTable";
			this.convertJobTable.RowCount = 2;
			this.convertJobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.convertJobTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.convertJobTable.Size = new System.Drawing.Size(636, 300);
			this.convertJobTable.TabIndex = 3;
			// 
			// convertJobStatusLabel
			// 
			this.convertJobStatusLabel.AutoSize = true;
			this.convertJobStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertJobStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.convertJobStatusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertJobStatusLabel.Location = new System.Drawing.Point(440, 0);
			this.convertJobStatusLabel.Margin = new System.Windows.Forms.Padding(0);
			this.convertJobStatusLabel.Name = "convertJobStatusLabel";
			this.convertJobStatusLabel.Size = new System.Drawing.Size(120, 32);
			this.convertJobStatusLabel.TabIndex = 2;
			this.convertJobStatusLabel.Text = "Status";
			this.convertJobStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// convertJobTimeLabel
			// 
			this.convertJobTimeLabel.AutoSize = true;
			this.convertJobTimeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertJobTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.convertJobTimeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertJobTimeLabel.Location = new System.Drawing.Point(360, 0);
			this.convertJobTimeLabel.Margin = new System.Windows.Forms.Padding(0);
			this.convertJobTimeLabel.Name = "convertJobTimeLabel";
			this.convertJobTimeLabel.Size = new System.Drawing.Size(80, 32);
			this.convertJobTimeLabel.TabIndex = 1;
			this.convertJobTimeLabel.Text = "Time";
			this.convertJobTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// convertJobTitleLabel
			// 
			this.convertJobTitleLabel.AutoSize = true;
			this.convertJobTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertJobTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.convertJobTitleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertJobTitleLabel.Location = new System.Drawing.Point(0, 0);
			this.convertJobTitleLabel.Margin = new System.Windows.Forms.Padding(0);
			this.convertJobTitleLabel.Name = "convertJobTitleLabel";
			this.convertJobTitleLabel.Size = new System.Drawing.Size(360, 32);
			this.convertJobTitleLabel.TabIndex = 0;
			this.convertJobTitleLabel.Text = "File Name";
			this.convertJobTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// convertJobCancelLabel
			// 
			this.convertJobCancelLabel.AutoSize = true;
			this.convertJobCancelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.convertJobCancelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.convertJobCancelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertJobCancelLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.convertJobCancelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
			this.convertJobCancelLabel.Location = new System.Drawing.Point(560, 0);
			this.convertJobCancelLabel.Margin = new System.Windows.Forms.Padding(0);
			this.convertJobCancelLabel.Name = "convertJobCancelLabel";
			this.convertJobCancelLabel.Size = new System.Drawing.Size(76, 32);
			this.convertJobCancelLabel.TabIndex = 3;
			this.convertJobCancelLabel.Text = "Cancel";
			this.convertJobCancelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.buttonContainer.Controls.Add(this.settingsButton);
			this.buttonContainer.Controls.Add(this.convertNavButton);
			this.buttonContainer.Controls.Add(this.panelNav);
			this.buttonContainer.Controls.Add(this.downloadButton);
			this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonContainer.Location = new System.Drawing.Point(0, 100);
			this.buttonContainer.Name = "buttonContainer";
			this.buttonContainer.Size = new System.Drawing.Size(150, 500);
			this.buttonContainer.TabIndex = 1;
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
			this.settingsButton.Location = new System.Drawing.Point(0, 140);
			this.settingsButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(190, 70);
			this.settingsButton.TabIndex = 1;
			this.settingsButton.Text = "Settings";
			this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.NavButtonClick);
			// 
			// convertNavButton
			// 
			this.convertNavButton.BackColor = System.Drawing.Color.Transparent;
			this.convertNavButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.convertNavButton.FlatAppearance.BorderSize = 0;
			this.convertNavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.convertNavButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.convertNavButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.convertNavButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.convertNavButton.Location = new System.Drawing.Point(0, 70);
			this.convertNavButton.MinimumSize = new System.Drawing.Size(190, 70);
			this.convertNavButton.Name = "convertNavButton";
			this.convertNavButton.Size = new System.Drawing.Size(190, 70);
			this.convertNavButton.TabIndex = 3;
			this.convertNavButton.Text = "Convert";
			this.convertNavButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.convertNavButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.convertNavButton.UseVisualStyleBackColor = false;
			this.convertNavButton.Click += new System.EventHandler(this.NavButtonClick);
			// 
			// panelNav
			// 
			this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
			this.panelNav.Location = new System.Drawing.Point(1, 0);
			this.panelNav.Name = "panelNav";
			this.panelNav.Size = new System.Drawing.Size(3, 70);
			this.panelNav.TabIndex = 2;
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
			this.downloadButton.Click += new System.EventHandler(this.NavButtonClick);
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
			this.titleLable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// titlebarPanel
			// 
			this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
			this.titlebarPanel.Controls.Add(this.minimizeButton);
			this.titlebarPanel.Controls.Add(this.titleLable);
			this.titlebarPanel.Controls.Add(this.closeAppButton);
			this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlebarPanel.Location = new System.Drawing.Point(150, 0);
			this.titlebarPanel.MinimumSize = new System.Drawing.Size(0, 38);
			this.titlebarPanel.Name = "titlebarPanel";
			this.titlebarPanel.Size = new System.Drawing.Size(650, 38);
			this.titlebarPanel.TabIndex = 1;
			this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			// 
			// minimizeButton
			// 
			this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
			this.minimizeButton.Location = new System.Drawing.Point(598, 0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(26, 38);
			this.minimizeButton.TabIndex = 2;
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
			this.contentPanel.Controls.Add(this.contentTabController);
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleDownloader";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contentTabController.ResumeLayout(false);
			this.downloadTab.ResumeLayout(false);
			this.downloadPanel.ResumeLayout(false);
			this.jobTable.ResumeLayout(false);
			this.jobTable.PerformLayout();
			this.searchPanel.ResumeLayout(false);
			this.searchPanel.PerformLayout();
			this.settingsTab.ResumeLayout(false);
			this.settingsPanel.ResumeLayout(false);
			this.logSettingsPanel.ResumeLayout(false);
			this.logSettingsPanel.PerformLayout();
			this.downloadLocationPanel.ResumeLayout(false);
			this.downloadLocationPanel.PerformLayout();
			this.errorTab.ResumeLayout(false);
			this.errorContentPanel.ResumeLayout(false);
			this.errorContentPanel.PerformLayout();
			this.errorTitlePanel.ResumeLayout(false);
			this.convertTab.ResumeLayout(false);
			this.convertContentPanel.ResumeLayout(false);
			this.convertOutputPanel.ResumeLayout(false);
			this.convertOutputLocationPanel.ResumeLayout(false);
			this.convertOutputLocationPanel.PerformLayout();
			this.convertInputPanel.ResumeLayout(false);
			this.convertInputLocationPanel.ResumeLayout(false);
			this.convertInputLocationPanel.PerformLayout();
			this.convertJobTable.ResumeLayout(false);
			this.convertJobTable.PerformLayout();
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
		private System.Windows.Forms.ComboBox formatDownloadComboBox;
		private System.Windows.Forms.Button convertNavButton;
		private System.Windows.Forms.TabPage convertTab;
		private System.Windows.Forms.TableLayoutPanel convertJobTable;
		private System.Windows.Forms.Label convertJobStatusLabel;
		private System.Windows.Forms.Label convertJobTimeLabel;
		private System.Windows.Forms.Label convertJobTitleLabel;
		private System.Windows.Forms.Label convertJobCancelLabel;
		private System.Windows.Forms.Panel convertContentPanel;
		private System.Windows.Forms.Panel convertOutputPanel;
		private System.Windows.Forms.Panel convertInputPanel;
		private System.Windows.Forms.Label convertInputLabel;
		private System.Windows.Forms.Label convertOutputLabel;
		private System.Windows.Forms.Panel convertInputLocationPanel;
		private System.Windows.Forms.Button convertInputSelectFileButton;
		private System.Windows.Forms.TextBox convertInputFileLocationTextBox;
		private System.Windows.Forms.Panel convertOutputLocationPanel;
		private System.Windows.Forms.Button convertOutputLocationButton;
		private System.Windows.Forms.TextBox convertOutputLocationTextBox;
		private System.Windows.Forms.Label downloadLocationLabel;
		private System.Windows.Forms.Label otherSettingsLabel;
		private System.Windows.Forms.ComboBox convertExtensionComboBox;
		private System.Windows.Forms.Button convertStartButton;
	}
}

