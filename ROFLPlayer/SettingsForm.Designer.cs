﻿namespace ROFLPlayer
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.GeneralFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.GeneralGameLabel = new System.Windows.Forms.Label();
            this.GeneralGameComboBox = new System.Windows.Forms.ComboBox();
            this.GeneralLaunchLabel = new System.Windows.Forms.Label();
            this.GeneralLaunchComboBox = new System.Windows.Forms.ComboBox();
            this.GeneralDivider1 = new System.Windows.Forms.Label();
            this.GeneralUsernameLabel = new System.Windows.Forms.Label();
            this.GeneralUsernameTextBox = new System.Windows.Forms.TextBox();
            this.GeneralRegionLabel = new System.Windows.Forms.Label();
            this.GeneralRegionComboBox = new System.Windows.Forms.ComboBox();
            this.ExecutablesTab = new System.Windows.Forms.TabPage();
            this.ExecFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ExecItemsList = new System.Windows.Forms.ListBox();
            this.ExecGroupBox = new System.Windows.Forms.GroupBox();
            this.GBoxAllowUpdatesTextBox = new System.Windows.Forms.TextBox();
            this.GBoxAllowUpdatesLabel = new System.Windows.Forms.Label();
            this.GBoxTargetLocationTextBox = new System.Windows.Forms.TextBox();
            this.GBoxTargetLocationLabel = new System.Windows.Forms.Label();
            this.GBoxLastModifTextBox = new System.Windows.Forms.TextBox();
            this.GBoxLastModifLabel = new System.Windows.Forms.Label();
            this.GBoxPatchVersTextBox = new System.Windows.Forms.TextBox();
            this.GBoxPatchVersLabel = new System.Windows.Forms.Label();
            this.GBoxExecNameTextBox = new System.Windows.Forms.TextBox();
            this.GBoxExecNameLabel = new System.Windows.Forms.Label();
            this.ExecAddButton = new System.Windows.Forms.Button();
            this.ExecEditButton = new System.Windows.Forms.Button();
            this.ExecDeleteButton = new System.Windows.Forms.Button();
            this.AboutTab = new System.Windows.Forms.TabPage();
            this.AboutTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AboutLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.AboutTitleLabel = new System.Windows.Forms.Label();
            this.AboutVersionLabel = new System.Windows.Forms.Label();
            this.AboutGithubButton = new System.Windows.Forms.Button();
            this.AboutCatLabel = new System.Windows.Forms.Label();
            this.MainCancelButton = new System.Windows.Forms.Button();
            this.MainOkButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.GeneralFlowLayout.SuspendLayout();
            this.ExecutablesTab.SuspendLayout();
            this.ExecFlowLayout.SuspendLayout();
            this.ExecGroupBox.SuspendLayout();
            this.AboutTab.SuspendLayout();
            this.AboutTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.GeneralTab);
            this.MainTabControl.Controls.Add(this.ExecutablesTab);
            this.MainTabControl.Controls.Add(this.AboutTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTabControl.Location = new System.Drawing.Point(5, 5);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(348, 423);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.SelectedIndexChanged += new System.EventHandler(this.SettingsForm_SelectedIndexChanged);
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.GeneralFlowLayout);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(340, 397);
            this.GeneralTab.TabIndex = 1;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // GeneralFlowLayout
            // 
            this.GeneralFlowLayout.Controls.Add(this.GeneralGameLabel);
            this.GeneralFlowLayout.Controls.Add(this.GeneralGameComboBox);
            this.GeneralFlowLayout.Controls.Add(this.GeneralLaunchLabel);
            this.GeneralFlowLayout.Controls.Add(this.GeneralLaunchComboBox);
            this.GeneralFlowLayout.Controls.Add(this.GeneralDivider1);
            this.GeneralFlowLayout.Controls.Add(this.GeneralUsernameLabel);
            this.GeneralFlowLayout.Controls.Add(this.GeneralUsernameTextBox);
            this.GeneralFlowLayout.Controls.Add(this.GeneralRegionLabel);
            this.GeneralFlowLayout.Controls.Add(this.GeneralRegionComboBox);
            this.GeneralFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.GeneralFlowLayout.Name = "GeneralFlowLayout";
            this.GeneralFlowLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.GeneralFlowLayout.Size = new System.Drawing.Size(334, 391);
            this.GeneralFlowLayout.TabIndex = 0;
            // 
            // GeneralGameLabel
            // 
            this.GeneralGameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralGameLabel.Location = new System.Drawing.Point(5, 14);
            this.GeneralGameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralGameLabel.Name = "GeneralGameLabel";
            this.GeneralGameLabel.Size = new System.Drawing.Size(105, 13);
            this.GeneralGameLabel.TabIndex = 0;
            this.GeneralGameLabel.Text = "Default Executable:";
            // 
            // GeneralGameComboBox
            // 
            this.GeneralGameComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralGameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneralGameComboBox.FormattingEnabled = true;
            this.GeneralGameComboBox.Location = new System.Drawing.Point(120, 10);
            this.GeneralGameComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralGameComboBox.Name = "GeneralGameComboBox";
            this.GeneralGameComboBox.Size = new System.Drawing.Size(200, 21);
            this.GeneralGameComboBox.TabIndex = 12;
            // 
            // GeneralLaunchLabel
            // 
            this.GeneralLaunchLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralLaunchLabel.Location = new System.Drawing.Point(5, 45);
            this.GeneralLaunchLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralLaunchLabel.Name = "GeneralLaunchLabel";
            this.GeneralLaunchLabel.Size = new System.Drawing.Size(105, 13);
            this.GeneralLaunchLabel.TabIndex = 5;
            this.GeneralLaunchLabel.Text = "Double-click action:";
            // 
            // GeneralLaunchComboBox
            // 
            this.GeneralLaunchComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralLaunchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneralLaunchComboBox.FormattingEnabled = true;
            this.GeneralLaunchComboBox.Items.AddRange(new object[] {
            "Play replay",
            "Show details"});
            this.GeneralLaunchComboBox.Location = new System.Drawing.Point(120, 41);
            this.GeneralLaunchComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralLaunchComboBox.Name = "GeneralLaunchComboBox";
            this.GeneralLaunchComboBox.Size = new System.Drawing.Size(200, 21);
            this.GeneralLaunchComboBox.TabIndex = 7;
            // 
            // GeneralDivider1
            // 
            this.GeneralDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GeneralDivider1.Location = new System.Drawing.Point(5, 72);
            this.GeneralDivider1.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralDivider1.Name = "GeneralDivider1";
            this.GeneralDivider1.Size = new System.Drawing.Size(315, 2);
            this.GeneralDivider1.TabIndex = 6;
            // 
            // GeneralUsernameLabel
            // 
            this.GeneralUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralUsernameLabel.Location = new System.Drawing.Point(5, 87);
            this.GeneralUsernameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralUsernameLabel.Name = "GeneralUsernameLabel";
            this.GeneralUsernameLabel.Size = new System.Drawing.Size(105, 13);
            this.GeneralUsernameLabel.TabIndex = 8;
            this.GeneralUsernameLabel.Text = "Player name:";
            // 
            // GeneralUsernameTextBox
            // 
            this.GeneralUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneralUsernameTextBox.Location = new System.Drawing.Point(120, 84);
            this.GeneralUsernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralUsernameTextBox.Name = "GeneralUsernameTextBox";
            this.GeneralUsernameTextBox.Size = new System.Drawing.Size(200, 20);
            this.GeneralUsernameTextBox.TabIndex = 9;
            // 
            // GeneralRegionLabel
            // 
            this.GeneralRegionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralRegionLabel.Location = new System.Drawing.Point(5, 118);
            this.GeneralRegionLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralRegionLabel.Name = "GeneralRegionLabel";
            this.GeneralRegionLabel.Size = new System.Drawing.Size(105, 13);
            this.GeneralRegionLabel.TabIndex = 10;
            this.GeneralRegionLabel.Text = "Region:";
            // 
            // GeneralRegionComboBox
            // 
            this.GeneralRegionComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GeneralRegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GeneralRegionComboBox.FormattingEnabled = true;
            this.GeneralRegionComboBox.Items.AddRange(new object[] {
            "BR",
            "EUNE",
            "EUW",
            "JP",
            "KR",
            "LAN",
            "LAS",
            "NA",
            "OCE",
            "TR",
            "RU",
            "PBE"});
            this.GeneralRegionComboBox.Location = new System.Drawing.Point(120, 114);
            this.GeneralRegionComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.GeneralRegionComboBox.Name = "GeneralRegionComboBox";
            this.GeneralRegionComboBox.Size = new System.Drawing.Size(200, 21);
            this.GeneralRegionComboBox.TabIndex = 11;
            // 
            // ExecutablesTab
            // 
            this.ExecutablesTab.Controls.Add(this.ExecFlowLayout);
            this.ExecutablesTab.Location = new System.Drawing.Point(4, 22);
            this.ExecutablesTab.Name = "ExecutablesTab";
            this.ExecutablesTab.Padding = new System.Windows.Forms.Padding(3);
            this.ExecutablesTab.Size = new System.Drawing.Size(340, 397);
            this.ExecutablesTab.TabIndex = 3;
            this.ExecutablesTab.Text = "Executables";
            this.ExecutablesTab.UseVisualStyleBackColor = true;
            // 
            // ExecFlowLayout
            // 
            this.ExecFlowLayout.Controls.Add(this.ExecItemsList);
            this.ExecFlowLayout.Controls.Add(this.ExecGroupBox);
            this.ExecFlowLayout.Controls.Add(this.ExecAddButton);
            this.ExecFlowLayout.Controls.Add(this.ExecEditButton);
            this.ExecFlowLayout.Controls.Add(this.ExecDeleteButton);
            this.ExecFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExecFlowLayout.Location = new System.Drawing.Point(3, 3);
            this.ExecFlowLayout.Name = "ExecFlowLayout";
            this.ExecFlowLayout.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ExecFlowLayout.Size = new System.Drawing.Size(334, 391);
            this.ExecFlowLayout.TabIndex = 0;
            // 
            // ExecItemsList
            // 
            this.ExecItemsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecItemsList.ItemHeight = 16;
            this.ExecItemsList.Location = new System.Drawing.Point(5, 10);
            this.ExecItemsList.Margin = new System.Windows.Forms.Padding(5);
            this.ExecItemsList.Name = "ExecItemsList";
            this.ExecItemsList.Size = new System.Drawing.Size(322, 164);
            this.ExecItemsList.TabIndex = 0;
            this.ExecItemsList.SelectedIndexChanged += new System.EventHandler(this.ExecItemsList_SelectedIndexChanged);
            this.ExecItemsList.DoubleClick += new System.EventHandler(this.ExecEditButton_Click);
            // 
            // ExecGroupBox
            // 
            this.ExecGroupBox.Controls.Add(this.GBoxAllowUpdatesTextBox);
            this.ExecGroupBox.Controls.Add(this.GBoxAllowUpdatesLabel);
            this.ExecGroupBox.Controls.Add(this.GBoxTargetLocationTextBox);
            this.ExecGroupBox.Controls.Add(this.GBoxTargetLocationLabel);
            this.ExecGroupBox.Controls.Add(this.GBoxLastModifTextBox);
            this.ExecGroupBox.Controls.Add(this.GBoxLastModifLabel);
            this.ExecGroupBox.Controls.Add(this.GBoxPatchVersTextBox);
            this.ExecGroupBox.Controls.Add(this.GBoxPatchVersLabel);
            this.ExecGroupBox.Controls.Add(this.GBoxExecNameTextBox);
            this.ExecGroupBox.Controls.Add(this.GBoxExecNameLabel);
            this.ExecGroupBox.Location = new System.Drawing.Point(5, 184);
            this.ExecGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.ExecGroupBox.Name = "ExecGroupBox";
            this.ExecGroupBox.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ExecGroupBox.Size = new System.Drawing.Size(322, 170);
            this.ExecGroupBox.TabIndex = 5;
            this.ExecGroupBox.TabStop = false;
            this.ExecGroupBox.Text = "Entry Information";
            // 
            // GBoxAllowUpdatesTextBox
            // 
            this.GBoxAllowUpdatesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GBoxAllowUpdatesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GBoxAllowUpdatesTextBox.Location = new System.Drawing.Point(93, 90);
            this.GBoxAllowUpdatesTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxAllowUpdatesTextBox.Name = "GBoxAllowUpdatesTextBox";
            this.GBoxAllowUpdatesTextBox.ReadOnly = true;
            this.GBoxAllowUpdatesTextBox.Size = new System.Drawing.Size(221, 13);
            this.GBoxAllowUpdatesTextBox.TabIndex = 19;
            // 
            // GBoxAllowUpdatesLabel
            // 
            this.GBoxAllowUpdatesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBoxAllowUpdatesLabel.Location = new System.Drawing.Point(5, 90);
            this.GBoxAllowUpdatesLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxAllowUpdatesLabel.Name = "GBoxAllowUpdatesLabel";
            this.GBoxAllowUpdatesLabel.Size = new System.Drawing.Size(100, 13);
            this.GBoxAllowUpdatesLabel.TabIndex = 18;
            this.GBoxAllowUpdatesLabel.Text = "Allow Updates:";
            // 
            // GBoxTargetLocationTextBox
            // 
            this.GBoxTargetLocationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GBoxTargetLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GBoxTargetLocationTextBox.Location = new System.Drawing.Point(93, 113);
            this.GBoxTargetLocationTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxTargetLocationTextBox.Multiline = true;
            this.GBoxTargetLocationTextBox.Name = "GBoxTargetLocationTextBox";
            this.GBoxTargetLocationTextBox.ReadOnly = true;
            this.GBoxTargetLocationTextBox.Size = new System.Drawing.Size(221, 54);
            this.GBoxTargetLocationTextBox.TabIndex = 17;
            // 
            // GBoxTargetLocationLabel
            // 
            this.GBoxTargetLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBoxTargetLocationLabel.Location = new System.Drawing.Point(5, 113);
            this.GBoxTargetLocationLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxTargetLocationLabel.Name = "GBoxTargetLocationLabel";
            this.GBoxTargetLocationLabel.Size = new System.Drawing.Size(100, 13);
            this.GBoxTargetLocationLabel.TabIndex = 16;
            this.GBoxTargetLocationLabel.Text = "Target:";
            // 
            // GBoxLastModifTextBox
            // 
            this.GBoxLastModifTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GBoxLastModifTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GBoxLastModifTextBox.Location = new System.Drawing.Point(93, 67);
            this.GBoxLastModifTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxLastModifTextBox.Name = "GBoxLastModifTextBox";
            this.GBoxLastModifTextBox.ReadOnly = true;
            this.GBoxLastModifTextBox.Size = new System.Drawing.Size(221, 13);
            this.GBoxLastModifTextBox.TabIndex = 15;
            // 
            // GBoxLastModifLabel
            // 
            this.GBoxLastModifLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBoxLastModifLabel.Location = new System.Drawing.Point(5, 67);
            this.GBoxLastModifLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxLastModifLabel.Name = "GBoxLastModifLabel";
            this.GBoxLastModifLabel.Size = new System.Drawing.Size(100, 13);
            this.GBoxLastModifLabel.TabIndex = 14;
            this.GBoxLastModifLabel.Text = "Last Modified:";
            // 
            // GBoxPatchVersTextBox
            // 
            this.GBoxPatchVersTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GBoxPatchVersTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GBoxPatchVersTextBox.Location = new System.Drawing.Point(93, 44);
            this.GBoxPatchVersTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxPatchVersTextBox.Name = "GBoxPatchVersTextBox";
            this.GBoxPatchVersTextBox.ReadOnly = true;
            this.GBoxPatchVersTextBox.Size = new System.Drawing.Size(221, 13);
            this.GBoxPatchVersTextBox.TabIndex = 11;
            // 
            // GBoxPatchVersLabel
            // 
            this.GBoxPatchVersLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBoxPatchVersLabel.Location = new System.Drawing.Point(5, 44);
            this.GBoxPatchVersLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxPatchVersLabel.Name = "GBoxPatchVersLabel";
            this.GBoxPatchVersLabel.Size = new System.Drawing.Size(100, 13);
            this.GBoxPatchVersLabel.TabIndex = 10;
            this.GBoxPatchVersLabel.Text = "Patch Version:";
            // 
            // GBoxExecNameTextBox
            // 
            this.GBoxExecNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.GBoxExecNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GBoxExecNameTextBox.Location = new System.Drawing.Point(93, 21);
            this.GBoxExecNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxExecNameTextBox.Name = "GBoxExecNameTextBox";
            this.GBoxExecNameTextBox.ReadOnly = true;
            this.GBoxExecNameTextBox.Size = new System.Drawing.Size(221, 13);
            this.GBoxExecNameTextBox.TabIndex = 9;
            // 
            // GBoxExecNameLabel
            // 
            this.GBoxExecNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GBoxExecNameLabel.Location = new System.Drawing.Point(5, 21);
            this.GBoxExecNameLabel.Margin = new System.Windows.Forms.Padding(5);
            this.GBoxExecNameLabel.Name = "GBoxExecNameLabel";
            this.GBoxExecNameLabel.Size = new System.Drawing.Size(100, 13);
            this.GBoxExecNameLabel.TabIndex = 8;
            this.GBoxExecNameLabel.Text = "Entry Name:";
            // 
            // ExecAddButton
            // 
            this.ExecAddButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExecAddButton.Location = new System.Drawing.Point(5, 364);
            this.ExecAddButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExecAddButton.Name = "ExecAddButton";
            this.ExecAddButton.Size = new System.Drawing.Size(88, 25);
            this.ExecAddButton.TabIndex = 3;
            this.ExecAddButton.Text = "Add...";
            this.ExecAddButton.UseVisualStyleBackColor = true;
            this.ExecAddButton.Click += new System.EventHandler(this.ExecAddButton_Click);
            // 
            // ExecEditButton
            // 
            this.ExecEditButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExecEditButton.Enabled = false;
            this.ExecEditButton.Location = new System.Drawing.Point(98, 364);
            this.ExecEditButton.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ExecEditButton.Name = "ExecEditButton";
            this.ExecEditButton.Size = new System.Drawing.Size(88, 25);
            this.ExecEditButton.TabIndex = 6;
            this.ExecEditButton.Text = "Edit...";
            this.ExecEditButton.UseVisualStyleBackColor = true;
            this.ExecEditButton.Click += new System.EventHandler(this.ExecEditButton_Click);
            // 
            // ExecDeleteButton
            // 
            this.ExecDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExecDeleteButton.Enabled = false;
            this.ExecDeleteButton.Location = new System.Drawing.Point(191, 364);
            this.ExecDeleteButton.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.ExecDeleteButton.Name = "ExecDeleteButton";
            this.ExecDeleteButton.Size = new System.Drawing.Size(88, 25);
            this.ExecDeleteButton.TabIndex = 7;
            this.ExecDeleteButton.Text = "Delete";
            this.ExecDeleteButton.UseVisualStyleBackColor = true;
            this.ExecDeleteButton.Click += new System.EventHandler(this.ExecDeleteButton_Click);
            // 
            // AboutTab
            // 
            this.AboutTab.Controls.Add(this.AboutTableLayoutPanel);
            this.AboutTab.Location = new System.Drawing.Point(4, 22);
            this.AboutTab.Name = "AboutTab";
            this.AboutTab.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTab.Size = new System.Drawing.Size(340, 397);
            this.AboutTab.TabIndex = 2;
            this.AboutTab.Text = "About";
            this.AboutTab.UseVisualStyleBackColor = true;
            // 
            // AboutTableLayoutPanel
            // 
            this.AboutTableLayoutPanel.ColumnCount = 1;
            this.AboutTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AboutTableLayoutPanel.Controls.Add(this.AboutLogoPictureBox, 0, 1);
            this.AboutTableLayoutPanel.Controls.Add(this.AboutTitleLabel, 0, 2);
            this.AboutTableLayoutPanel.Controls.Add(this.AboutVersionLabel, 0, 3);
            this.AboutTableLayoutPanel.Controls.Add(this.AboutGithubButton, 0, 6);
            this.AboutTableLayoutPanel.Controls.Add(this.AboutCatLabel, 0, 5);
            this.AboutTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.AboutTableLayoutPanel.Name = "AboutTableLayoutPanel";
            this.AboutTableLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.AboutTableLayoutPanel.RowCount = 7;
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.AboutTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.AboutTableLayoutPanel.Size = new System.Drawing.Size(334, 391);
            this.AboutTableLayoutPanel.TabIndex = 0;
            // 
            // AboutLogoPictureBox
            // 
            this.AboutLogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AboutLogoPictureBox.Image = global::ROFLPlayer.Properties.Resources.iconBMP;
            this.AboutLogoPictureBox.Location = new System.Drawing.Point(125, 28);
            this.AboutLogoPictureBox.Name = "AboutLogoPictureBox";
            this.AboutLogoPictureBox.Size = new System.Drawing.Size(84, 96);
            this.AboutLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AboutLogoPictureBox.TabIndex = 1;
            this.AboutLogoPictureBox.TabStop = false;
            // 
            // AboutTitleLabel
            // 
            this.AboutTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTitleLabel.Location = new System.Drawing.Point(3, 127);
            this.AboutTitleLabel.Name = "AboutTitleLabel";
            this.AboutTitleLabel.Size = new System.Drawing.Size(328, 23);
            this.AboutTitleLabel.TabIndex = 2;
            this.AboutTitleLabel.Text = "ROFL Player";
            this.AboutTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutVersionLabel
            // 
            this.AboutVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutVersionLabel.Location = new System.Drawing.Point(3, 150);
            this.AboutVersionLabel.Name = "AboutVersionLabel";
            this.AboutVersionLabel.Size = new System.Drawing.Size(328, 23);
            this.AboutVersionLabel.TabIndex = 3;
            this.AboutVersionLabel.Text = "-";
            this.AboutVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutGithubButton
            // 
            this.AboutGithubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutGithubButton.Location = new System.Drawing.Point(3, 360);
            this.AboutGithubButton.Name = "AboutGithubButton";
            this.AboutGithubButton.Size = new System.Drawing.Size(75, 23);
            this.AboutGithubButton.TabIndex = 5;
            this.AboutGithubButton.Text = "GitHub";
            this.AboutGithubButton.UseVisualStyleBackColor = true;
            this.AboutGithubButton.Click += new System.EventHandler(this.AboutGithubButton_Click);
            // 
            // AboutCatLabel
            // 
            this.AboutCatLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutCatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutCatLabel.Location = new System.Drawing.Point(3, 173);
            this.AboutCatLabel.Name = "AboutCatLabel";
            this.AboutCatLabel.Size = new System.Drawing.Size(328, 20);
            this.AboutCatLabel.TabIndex = 6;
            this.AboutCatLabel.Text = "buff nidalee";
            this.AboutCatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainCancelButton
            // 
            this.MainCancelButton.Location = new System.Drawing.Point(275, 434);
            this.MainCancelButton.Name = "MainCancelButton";
            this.MainCancelButton.Size = new System.Drawing.Size(75, 23);
            this.MainCancelButton.TabIndex = 2;
            this.MainCancelButton.Text = "Cancel";
            this.MainCancelButton.UseVisualStyleBackColor = true;
            this.MainCancelButton.Click += new System.EventHandler(this.MainCancelButton_Click);
            // 
            // MainOkButton
            // 
            this.MainOkButton.Location = new System.Drawing.Point(194, 434);
            this.MainOkButton.Name = "MainOkButton";
            this.MainOkButton.Size = new System.Drawing.Size(75, 23);
            this.MainOkButton.TabIndex = 3;
            this.MainOkButton.Text = "OK";
            this.MainOkButton.UseVisualStyleBackColor = true;
            this.MainOkButton.Click += new System.EventHandler(this.MainOkButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 465);
            this.Controls.Add(this.MainOkButton);
            this.Controls.Add(this.MainCancelButton);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ROFL Player Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralFlowLayout.ResumeLayout(false);
            this.GeneralFlowLayout.PerformLayout();
            this.ExecutablesTab.ResumeLayout(false);
            this.ExecFlowLayout.ResumeLayout(false);
            this.ExecGroupBox.ResumeLayout(false);
            this.ExecGroupBox.PerformLayout();
            this.AboutTab.ResumeLayout(false);
            this.AboutTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AboutLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.TabPage AboutTab;
        private System.Windows.Forms.FlowLayoutPanel GeneralFlowLayout;
        private System.Windows.Forms.Label GeneralGameLabel;
        private System.Windows.Forms.Button MainCancelButton;
        private System.Windows.Forms.Button MainOkButton;
        private System.Windows.Forms.Label GeneralLaunchLabel;
        private System.Windows.Forms.Label GeneralDivider1;
        private System.Windows.Forms.ComboBox GeneralLaunchComboBox;
        private System.Windows.Forms.TableLayoutPanel AboutTableLayoutPanel;
        private System.Windows.Forms.PictureBox AboutLogoPictureBox;
        private System.Windows.Forms.Label AboutTitleLabel;
        private System.Windows.Forms.Label AboutVersionLabel;
        private System.Windows.Forms.Button AboutGithubButton;
        private System.Windows.Forms.Label AboutCatLabel;
        private System.Windows.Forms.Label GeneralUsernameLabel;
        private System.Windows.Forms.TextBox GeneralUsernameTextBox;
        private System.Windows.Forms.Label GeneralRegionLabel;
        private System.Windows.Forms.ComboBox GeneralRegionComboBox;
        private System.Windows.Forms.TabPage ExecutablesTab;
        private System.Windows.Forms.FlowLayoutPanel ExecFlowLayout;
        private System.Windows.Forms.ListBox ExecItemsList;
        private System.Windows.Forms.Button ExecAddButton;
        private System.Windows.Forms.GroupBox ExecGroupBox;
        private System.Windows.Forms.TextBox GBoxLastModifTextBox;
        private System.Windows.Forms.Label GBoxLastModifLabel;
        private System.Windows.Forms.TextBox GBoxPatchVersTextBox;
        private System.Windows.Forms.Label GBoxPatchVersLabel;
        private System.Windows.Forms.TextBox GBoxExecNameTextBox;
        private System.Windows.Forms.Label GBoxExecNameLabel;
        private System.Windows.Forms.TextBox GBoxTargetLocationTextBox;
        private System.Windows.Forms.Label GBoxTargetLocationLabel;
        private System.Windows.Forms.Button ExecDeleteButton;
        private System.Windows.Forms.Button ExecEditButton;
        private System.Windows.Forms.TextBox GBoxAllowUpdatesTextBox;
        private System.Windows.Forms.Label GBoxAllowUpdatesLabel;
        private System.Windows.Forms.ComboBox GeneralGameComboBox;
    }
}