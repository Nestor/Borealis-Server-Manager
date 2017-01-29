﻿namespace GameServer_Manager
{
    partial class GSM_Deployment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSM_Deployment));
            this.btnCancelDeployGameserver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.progressbarDownloadProgressOverall = new Bunifu.Framework.UI.BunifuProgressBar();
            this.dropdownServerSelection = new MetroFramework.Controls.MetroComboBox();
            this.lblDownloadProgressDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDestinationDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDownloadProgress = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.progressbarDownloadProgress = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btnBrowseDestination = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtboxDestinationFolder = new System.Windows.Forms.TextBox();
            this.lblDestination = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSelectServerDetails = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeployGameserver = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSelectServer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.browseDestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.serverDeploymentWorker = new System.ComponentModel.BackgroundWorker();
            this.lblSeparateConfig = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkSeparateConfig = new Bunifu.Framework.UI.BunifuCheckbox();
            this.dropdownExistingServer = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // btnCancelDeployGameserver
            // 
            this.btnCancelDeployGameserver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancelDeployGameserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnCancelDeployGameserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelDeployGameserver.BorderRadius = 0;
            this.btnCancelDeployGameserver.ButtonText = "   Cancel";
            this.btnCancelDeployGameserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelDeployGameserver.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelDeployGameserver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnCancelDeployGameserver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelDeployGameserver.Iconimage = global::GameServer_Manager.Properties.Resources.STOP_ICON;
            this.btnCancelDeployGameserver.Iconimage_right = null;
            this.btnCancelDeployGameserver.Iconimage_right_Selected = null;
            this.btnCancelDeployGameserver.Iconimage_Selected = null;
            this.btnCancelDeployGameserver.IconMarginLeft = 0;
            this.btnCancelDeployGameserver.IconMarginRight = 0;
            this.btnCancelDeployGameserver.IconRightVisible = true;
            this.btnCancelDeployGameserver.IconRightZoom = 0D;
            this.btnCancelDeployGameserver.IconVisible = true;
            this.btnCancelDeployGameserver.IconZoom = 45D;
            this.btnCancelDeployGameserver.IsTab = false;
            this.btnCancelDeployGameserver.Location = new System.Drawing.Point(378, 465);
            this.btnCancelDeployGameserver.Name = "btnCancelDeployGameserver";
            this.btnCancelDeployGameserver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.btnCancelDeployGameserver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btnCancelDeployGameserver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelDeployGameserver.selected = false;
            this.btnCancelDeployGameserver.Size = new System.Drawing.Size(143, 48);
            this.btnCancelDeployGameserver.TabIndex = 41;
            this.btnCancelDeployGameserver.Text = "   Cancel";
            this.btnCancelDeployGameserver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDeployGameserver.Textcolor = System.Drawing.Color.White;
            this.btnCancelDeployGameserver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDeployGameserver.Visible = false;
            // 
            // progressbarDownloadProgressOverall
            // 
            this.progressbarDownloadProgressOverall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressbarDownloadProgressOverall.BorderRadius = 5;
            this.progressbarDownloadProgressOverall.Location = new System.Drawing.Point(16, 447);
            this.progressbarDownloadProgressOverall.MaximumValue = 100;
            this.progressbarDownloadProgressOverall.Name = "progressbarDownloadProgressOverall";
            this.progressbarDownloadProgressOverall.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressbarDownloadProgressOverall.Size = new System.Drawing.Size(664, 10);
            this.progressbarDownloadProgressOverall.TabIndex = 40;
            this.progressbarDownloadProgressOverall.Value = 0;
            this.progressbarDownloadProgressOverall.Visible = false;
            // 
            // dropdownServerSelection
            // 
            this.dropdownServerSelection.BackColor = System.Drawing.Color.White;
            this.dropdownServerSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dropdownServerSelection.FormattingEnabled = true;
            this.dropdownServerSelection.ItemHeight = 23;
            this.dropdownServerSelection.Items.AddRange(new object[] {
            "Garry\'s Mod",
            "Killing Floor 2",
            "SynergyMod HL2-Coop",
            "Team Fortress 2"});
            this.dropdownServerSelection.Location = new System.Drawing.Point(16, 125);
            this.dropdownServerSelection.Name = "dropdownServerSelection";
            this.dropdownServerSelection.Size = new System.Drawing.Size(346, 29);
            this.dropdownServerSelection.Sorted = true;
            this.dropdownServerSelection.TabIndex = 39;
            this.dropdownServerSelection.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropdownServerSelection.UseCustomBackColor = true;
            this.dropdownServerSelection.UseCustomForeColor = true;
            this.dropdownServerSelection.UseSelectable = true;
            this.dropdownServerSelection.SelectedValueChanged += new System.EventHandler(this.dropdownServerSelection_SelectedValueChanged);
            // 
            // lblDownloadProgressDetails
            // 
            this.lblDownloadProgressDetails.AutoSize = true;
            this.lblDownloadProgressDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDownloadProgressDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblDownloadProgressDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDownloadProgressDetails.Location = new System.Drawing.Point(13, 411);
            this.lblDownloadProgressDetails.Name = "lblDownloadProgressDetails";
            this.lblDownloadProgressDetails.Size = new System.Drawing.Size(55, 13);
            this.lblDownloadProgressDetails.TabIndex = 38;
            this.lblDownloadProgressDetails.Text = "Status: Idle";
            this.lblDownloadProgressDetails.Visible = false;
            // 
            // lblDestinationDetails
            // 
            this.lblDestinationDetails.AutoSize = true;
            this.lblDestinationDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblDestinationDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblDestinationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblDestinationDetails.Location = new System.Drawing.Point(13, 203);
            this.lblDestinationDetails.Name = "lblDestinationDetails";
            this.lblDestinationDetails.Size = new System.Drawing.Size(234, 13);
            this.lblDestinationDetails.TabIndex = 37;
            this.lblDestinationDetails.Text = "Choose where you want to install the gameserver";
            this.lblDestinationDetails.Visible = false;
            // 
            // lblDownloadProgress
            // 
            this.lblDownloadProgress.AutoSize = true;
            this.lblDownloadProgress.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblDownloadProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDownloadProgress.Location = new System.Drawing.Point(12, 390);
            this.lblDownloadProgress.Name = "lblDownloadProgress";
            this.lblDownloadProgress.Size = new System.Drawing.Size(230, 21);
            this.lblDownloadProgress.TabIndex = 36;
            this.lblDownloadProgress.Text = "Download / Installation Progress:";
            this.lblDownloadProgress.Visible = false;
            // 
            // progressbarDownloadProgress
            // 
            this.progressbarDownloadProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.progressbarDownloadProgress.BorderRadius = 5;
            this.progressbarDownloadProgress.Location = new System.Drawing.Point(16, 431);
            this.progressbarDownloadProgress.MaximumValue = 100;
            this.progressbarDownloadProgress.Name = "progressbarDownloadProgress";
            this.progressbarDownloadProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.progressbarDownloadProgress.Size = new System.Drawing.Size(664, 10);
            this.progressbarDownloadProgress.TabIndex = 35;
            this.progressbarDownloadProgress.Value = 0;
            this.progressbarDownloadProgress.Visible = false;
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnBrowseDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowseDestination.BorderRadius = 0;
            this.btnBrowseDestination.ButtonText = "      Browse";
            this.btnBrowseDestination.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseDestination.DisabledColor = System.Drawing.Color.Gray;
            this.btnBrowseDestination.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnBrowseDestination.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBrowseDestination.Iconimage = null;
            this.btnBrowseDestination.Iconimage_right = null;
            this.btnBrowseDestination.Iconimage_right_Selected = null;
            this.btnBrowseDestination.Iconimage_Selected = null;
            this.btnBrowseDestination.IconMarginLeft = 0;
            this.btnBrowseDestination.IconMarginRight = 0;
            this.btnBrowseDestination.IconRightVisible = true;
            this.btnBrowseDestination.IconRightZoom = 0D;
            this.btnBrowseDestination.IconVisible = true;
            this.btnBrowseDestination.IconZoom = 90D;
            this.btnBrowseDestination.IsTab = false;
            this.btnBrowseDestination.Location = new System.Drawing.Point(368, 227);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnBrowseDestination.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnBrowseDestination.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBrowseDestination.selected = false;
            this.btnBrowseDestination.Size = new System.Drawing.Size(72, 29);
            this.btnBrowseDestination.TabIndex = 33;
            this.btnBrowseDestination.Text = "      Browse";
            this.btnBrowseDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseDestination.Textcolor = System.Drawing.Color.White;
            this.btnBrowseDestination.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseDestination.Visible = false;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // txtboxDestinationFolder
            // 
            this.txtboxDestinationFolder.BackColor = System.Drawing.Color.White;
            this.txtboxDestinationFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDestinationFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.txtboxDestinationFolder.Location = new System.Drawing.Point(16, 227);
            this.txtboxDestinationFolder.Name = "txtboxDestinationFolder";
            this.txtboxDestinationFolder.Size = new System.Drawing.Size(346, 29);
            this.txtboxDestinationFolder.TabIndex = 32;
            this.txtboxDestinationFolder.Text = "C:\\GSM\\";
            this.txtboxDestinationFolder.Visible = false;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDestination.Location = new System.Drawing.Point(12, 182);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(136, 21);
            this.lblDestination.TabIndex = 29;
            this.lblDestination.Text = "Step 2: Destination";
            this.lblDestination.Visible = false;
            // 
            // lblSelectServerDetails
            // 
            this.lblSelectServerDetails.AutoSize = true;
            this.lblSelectServerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblSelectServerDetails.Font = new System.Drawing.Font("Segoe UI Light", 8F);
            this.lblSelectServerDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.lblSelectServerDetails.Location = new System.Drawing.Point(13, 101);
            this.lblSelectServerDetails.Name = "lblSelectServerDetails";
            this.lblSelectServerDetails.Size = new System.Drawing.Size(198, 13);
            this.lblSelectServerDetails.TabIndex = 12;
            this.lblSelectServerDetails.Text = "Which gameserver do you want to install?";
            // 
            // btnDeployGameserver
            // 
            this.btnDeployGameserver.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeployGameserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnDeployGameserver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeployGameserver.BorderRadius = 0;
            this.btnDeployGameserver.ButtonText = "Deploy";
            this.btnDeployGameserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeployGameserver.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeployGameserver.Enabled = false;
            this.btnDeployGameserver.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.btnDeployGameserver.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeployGameserver.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeployGameserver.Iconimage")));
            this.btnDeployGameserver.Iconimage_right = null;
            this.btnDeployGameserver.Iconimage_right_Selected = null;
            this.btnDeployGameserver.Iconimage_Selected = null;
            this.btnDeployGameserver.IconMarginLeft = 0;
            this.btnDeployGameserver.IconMarginRight = 0;
            this.btnDeployGameserver.IconRightVisible = true;
            this.btnDeployGameserver.IconRightZoom = 0D;
            this.btnDeployGameserver.IconVisible = true;
            this.btnDeployGameserver.IconZoom = 90D;
            this.btnDeployGameserver.IsTab = false;
            this.btnDeployGameserver.Location = new System.Drawing.Point(537, 465);
            this.btnDeployGameserver.Name = "btnDeployGameserver";
            this.btnDeployGameserver.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.btnDeployGameserver.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeployGameserver.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeployGameserver.selected = false;
            this.btnDeployGameserver.Size = new System.Drawing.Size(143, 48);
            this.btnDeployGameserver.TabIndex = 14;
            this.btnDeployGameserver.Text = "Deploy";
            this.btnDeployGameserver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeployGameserver.Textcolor = System.Drawing.Color.White;
            this.btnDeployGameserver.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeployGameserver.Click += new System.EventHandler(this.btnDeployGameserver_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(156)))), ((int)(((byte)(163)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(12, 40);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(295, 19);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Select a gameserver and destination to deploy it.";
            // 
            // lblSelectServer
            // 
            this.lblSelectServer.AutoSize = true;
            this.lblSelectServer.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lblSelectServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSelectServer.Location = new System.Drawing.Point(10, 80);
            this.lblSelectServer.Name = "lblSelectServer";
            this.lblSelectServer.Size = new System.Drawing.Size(143, 21);
            this.lblSelectServer.TabIndex = 5;
            this.lblSelectServer.Text = "Step 1: Select Server";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(10, 10);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(268, 32);
            this.bunifuCustomLabel2.TabIndex = 4;
            this.bunifuCustomLabel2.Text = "GameServer Deployment";
            // 
            // browseDestinationFolder
            // 
            this.browseDestinationFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // serverDeploymentWorker
            // 
            this.serverDeploymentWorker.WorkerReportsProgress = true;
            this.serverDeploymentWorker.WorkerSupportsCancellation = true;
            // 
            // lblSeparateConfig
            // 
            this.lblSeparateConfig.AutoSize = true;
            this.lblSeparateConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.lblSeparateConfig.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblSeparateConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSeparateConfig.Location = new System.Drawing.Point(406, 135);
            this.lblSeparateConfig.Name = "lblSeparateConfig";
            this.lblSeparateConfig.Size = new System.Drawing.Size(231, 19);
            this.lblSeparateConfig.TabIndex = 43;
            this.lblSeparateConfig.Text = "Add separate config to existing server";
            this.lblSeparateConfig.Visible = false;
            // 
            // chkSeparateConfig
            // 
            this.chkSeparateConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSeparateConfig.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSeparateConfig.Checked = false;
            this.chkSeparateConfig.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.chkSeparateConfig.ForeColor = System.Drawing.Color.White;
            this.chkSeparateConfig.Location = new System.Drawing.Point(380, 135);
            this.chkSeparateConfig.Name = "chkSeparateConfig";
            this.chkSeparateConfig.Size = new System.Drawing.Size(20, 20);
            this.chkSeparateConfig.TabIndex = 42;
            this.chkSeparateConfig.Visible = false;
            this.chkSeparateConfig.OnChange += new System.EventHandler(this.chkSeparateConfig_OnChange_1);
            // 
            // dropdownExistingServer
            // 
            this.dropdownExistingServer.BackColor = System.Drawing.Color.White;
            this.dropdownExistingServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.dropdownExistingServer.FormattingEnabled = true;
            this.dropdownExistingServer.ItemHeight = 23;
            this.dropdownExistingServer.Location = new System.Drawing.Point(16, 227);
            this.dropdownExistingServer.Name = "dropdownExistingServer";
            this.dropdownExistingServer.Size = new System.Drawing.Size(346, 29);
            this.dropdownExistingServer.Sorted = true;
            this.dropdownExistingServer.TabIndex = 44;
            this.dropdownExistingServer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dropdownExistingServer.UseCustomBackColor = true;
            this.dropdownExistingServer.UseCustomForeColor = true;
            this.dropdownExistingServer.UseSelectable = true;
            this.dropdownExistingServer.Visible = false;
            // 
            // GSM_Deployment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(697, 531);
            this.Controls.Add(this.dropdownExistingServer);
            this.Controls.Add(this.lblSeparateConfig);
            this.Controls.Add(this.chkSeparateConfig);
            this.Controls.Add(this.btnDeployGameserver);
            this.Controls.Add(this.btnCancelDeployGameserver);
            this.Controls.Add(this.progressbarDownloadProgressOverall);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.progressbarDownloadProgress);
            this.Controls.Add(this.lblDownloadProgressDetails);
            this.Controls.Add(this.dropdownServerSelection);
            this.Controls.Add(this.lblDownloadProgress);
            this.Controls.Add(this.lblDestinationDetails);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.lblSelectServer);
            this.Controls.Add(this.txtboxDestinationFolder);
            this.Controls.Add(this.lblSelectServerDetails);
            this.Controls.Add(this.lblDestination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GSM_Deployment";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Toolkit_Authentication_Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnDeployGameserver;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelectServer;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDestination;
        private System.Windows.Forms.TextBox txtboxDestinationFolder;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSelectServerDetails;
        private Bunifu.Framework.UI.BunifuFlatButton btnBrowseDestination;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDownloadProgressDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDestinationDetails;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDownloadProgress;
        private Bunifu.Framework.UI.BunifuProgressBar progressbarDownloadProgress;
        private System.Windows.Forms.FolderBrowserDialog browseDestinationFolder;
        private MetroFramework.Controls.MetroComboBox dropdownServerSelection;
        private Bunifu.Framework.UI.BunifuProgressBar progressbarDownloadProgressOverall;
        private System.ComponentModel.BackgroundWorker serverDeploymentWorker;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelDeployGameserver;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSeparateConfig;
        private Bunifu.Framework.UI.BunifuCheckbox chkSeparateConfig;
        private MetroFramework.Controls.MetroComboBox dropdownExistingServer;
    }
}