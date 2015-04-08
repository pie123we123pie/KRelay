﻿using System;
namespace K_Relay
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imglistTabs = new System.Windows.Forms.ImageList(this.components);
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tbxLog = new System.Windows.Forms.RichTextBox();
            this.menuInfo = new System.Windows.Forms.MenuStrip();
            this.btnToggleProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveLog = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPlugins = new System.Windows.Forms.TabPage();
            this.splitPlugins = new System.Windows.Forms.SplitContainer();
            this.listPlugins = new System.Windows.Forms.ListBox();
            this.tbxPluginInfo = new System.Windows.Forms.RichTextBox();
            this.menuPlugins = new System.Windows.Forms.MenuStrip();
            this.btnOpenPluginFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPackets = new System.Windows.Forms.TabPage();
            this.splitPackets = new System.Windows.Forms.SplitContainer();
            this.listPackets = new System.Windows.Forms.ListBox();
            this.tbxPacketInfo = new System.Windows.Forms.RichTextBox();
            this.menuPackets = new System.Windows.Forms.MenuStrip();
            this.btnOpenPacketsFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.gridSettings = new System.Windows.Forms.PropertyGrid();
            this.menuSettings = new System.Windows.Forms.MenuStrip();
            this.btnSaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lblKRelay = new System.Windows.Forms.Label();
            this.pbxGang = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblKronks = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.menuInfo.SuspendLayout();
            this.tabPlugins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPlugins)).BeginInit();
            this.splitPlugins.Panel1.SuspendLayout();
            this.splitPlugins.Panel2.SuspendLayout();
            this.splitPlugins.SuspendLayout();
            this.menuPlugins.SuspendLayout();
            this.tabPackets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPackets)).BeginInit();
            this.splitPackets.Panel1.SuspendLayout();
            this.splitPackets.Panel2.SuspendLayout();
            this.splitPackets.SuspendLayout();
            this.menuPackets.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.menuSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGang)).BeginInit();
            this.SuspendLayout();
            // 
            // imglistTabs
            // 
            this.imglistTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistTabs.ImageStream")));
            this.imglistTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistTabs.Images.SetKeyName(0, "info icon.png");
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tabInfo);
            this.tabMain.Controls.Add(this.tabPlugins);
            this.tabMain.Controls.Add(this.tabPackets);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Controls.Add(this.tabAbout);
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(938, 731);
            this.tabMain.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tbxLog);
            this.tabInfo.Controls.Add(this.menuInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 39);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInfo.Size = new System.Drawing.Size(930, 688);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // tbxLog
            // 
            this.tbxLog.BackColor = System.Drawing.Color.LightGray;
            this.tbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxLog.Location = new System.Drawing.Point(4, 44);
            this.tbxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ReadOnly = true;
            this.tbxLog.Size = new System.Drawing.Size(922, 640);
            this.tbxLog.TabIndex = 1;
            this.tbxLog.Text = "";
            this.tbxLog.WordWrap = false;
            this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
            // 
            // menuInfo
            // 
            this.menuInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuInfo.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToggleProxy,
            this.btnSaveLog,
            this.btnClearLog});
            this.menuInfo.Location = new System.Drawing.Point(4, 4);
            this.menuInfo.Name = "menuInfo";
            this.menuInfo.Size = new System.Drawing.Size(922, 40);
            this.menuInfo.TabIndex = 0;
            this.menuInfo.Text = "menuStrip2";
            // 
            // btnToggleProxy
            // 
            this.btnToggleProxy.Name = "btnToggleProxy";
            this.btnToggleProxy.Size = new System.Drawing.Size(141, 36);
            this.btnToggleProxy.Text = "Start Proxy";
            this.btnToggleProxy.Click += new System.EventHandler(this.btnToggleProxy_Click);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(123, 36);
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(127, 36);
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // tabPlugins
            // 
            this.tabPlugins.Controls.Add(this.splitPlugins);
            this.tabPlugins.Controls.Add(this.menuPlugins);
            this.tabPlugins.Location = new System.Drawing.Point(4, 39);
            this.tabPlugins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPlugins.Name = "tabPlugins";
            this.tabPlugins.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPlugins.Size = new System.Drawing.Size(930, 688);
            this.tabPlugins.TabIndex = 1;
            this.tabPlugins.Text = "Plugins";
            this.tabPlugins.UseVisualStyleBackColor = true;
            // 
            // splitPlugins
            // 
            this.splitPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPlugins.Location = new System.Drawing.Point(4, 44);
            this.splitPlugins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitPlugins.Name = "splitPlugins";
            // 
            // splitPlugins.Panel1
            // 
            this.splitPlugins.Panel1.Controls.Add(this.listPlugins);
            // 
            // splitPlugins.Panel2
            // 
            this.splitPlugins.Panel2.Controls.Add(this.tbxPluginInfo);
            this.splitPlugins.Size = new System.Drawing.Size(922, 640);
            this.splitPlugins.SplitterDistance = 288;
            this.splitPlugins.TabIndex = 1;
            // 
            // listPlugins
            // 
            this.listPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPlugins.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPlugins.ItemHeight = 30;
            this.listPlugins.Location = new System.Drawing.Point(0, 0);
            this.listPlugins.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPlugins.Name = "listPlugins";
            this.listPlugins.Size = new System.Drawing.Size(288, 640);
            this.listPlugins.TabIndex = 0;
            this.listPlugins.SelectedIndexChanged += new System.EventHandler(this.listPlugins_SelectedIndexChanged);
            // 
            // tbxPluginInfo
            // 
            this.tbxPluginInfo.BackColor = System.Drawing.Color.Silver;
            this.tbxPluginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPluginInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPluginInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPluginInfo.Location = new System.Drawing.Point(0, 0);
            this.tbxPluginInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPluginInfo.Name = "tbxPluginInfo";
            this.tbxPluginInfo.ReadOnly = true;
            this.tbxPluginInfo.Size = new System.Drawing.Size(630, 640);
            this.tbxPluginInfo.TabIndex = 1;
            this.tbxPluginInfo.Text = "Select a plugin to view its description.";
            // 
            // menuPlugins
            // 
            this.menuPlugins.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPlugins.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPlugins.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenPluginFolder});
            this.menuPlugins.Location = new System.Drawing.Point(4, 4);
            this.menuPlugins.Name = "menuPlugins";
            this.menuPlugins.Size = new System.Drawing.Size(922, 40);
            this.menuPlugins.TabIndex = 0;
            this.menuPlugins.Text = "menuStrip1";
            // 
            // btnOpenPluginFolder
            // 
            this.btnOpenPluginFolder.Name = "btnOpenPluginFolder";
            this.btnOpenPluginFolder.Size = new System.Drawing.Size(234, 36);
            this.btnOpenPluginFolder.Text = "Open Plugin Folder";
            this.btnOpenPluginFolder.Click += new System.EventHandler(this.btnOpenPluginFolder_Click);
            // 
            // tabPackets
            // 
            this.tabPackets.Controls.Add(this.splitPackets);
            this.tabPackets.Controls.Add(this.menuPackets);
            this.tabPackets.Location = new System.Drawing.Point(4, 39);
            this.tabPackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPackets.Name = "tabPackets";
            this.tabPackets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPackets.Size = new System.Drawing.Size(930, 688);
            this.tabPackets.TabIndex = 4;
            this.tabPackets.Text = "Packets";
            this.tabPackets.UseVisualStyleBackColor = true;
            // 
            // splitPackets
            // 
            this.splitPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPackets.Location = new System.Drawing.Point(4, 44);
            this.splitPackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitPackets.Name = "splitPackets";
            // 
            // splitPackets.Panel1
            // 
            this.splitPackets.Panel1.Controls.Add(this.listPackets);
            // 
            // splitPackets.Panel2
            // 
            this.splitPackets.Panel2.Controls.Add(this.tbxPacketInfo);
            this.splitPackets.Size = new System.Drawing.Size(922, 640);
            this.splitPackets.SplitterDistance = 288;
            this.splitPackets.TabIndex = 2;
            // 
            // listPackets
            // 
            this.listPackets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPackets.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPackets.ItemHeight = 30;
            this.listPackets.Location = new System.Drawing.Point(0, 0);
            this.listPackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPackets.Name = "listPackets";
            this.listPackets.Size = new System.Drawing.Size(288, 640);
            this.listPackets.Sorted = true;
            this.listPackets.TabIndex = 0;
            this.listPackets.SelectedIndexChanged += new System.EventHandler(this.listPackets_SelectedIndexChanged);
            // 
            // tbxPacketInfo
            // 
            this.tbxPacketInfo.BackColor = System.Drawing.Color.Silver;
            this.tbxPacketInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPacketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPacketInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPacketInfo.Location = new System.Drawing.Point(0, 0);
            this.tbxPacketInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPacketInfo.Name = "tbxPacketInfo";
            this.tbxPacketInfo.ReadOnly = true;
            this.tbxPacketInfo.Size = new System.Drawing.Size(630, 640);
            this.tbxPacketInfo.TabIndex = 0;
            this.tbxPacketInfo.Text = "Select a packet type to view more info.";
            // 
            // menuPackets
            // 
            this.menuPackets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPackets.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuPackets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenPacketsFolder});
            this.menuPackets.Location = new System.Drawing.Point(4, 4);
            this.menuPackets.Name = "menuPackets";
            this.menuPackets.Size = new System.Drawing.Size(922, 40);
            this.menuPackets.TabIndex = 1;
            this.menuPackets.Text = "menuStrip1";
            // 
            // btnOpenPacketsFolder
            // 
            this.btnOpenPacketsFolder.Name = "btnOpenPacketsFolder";
            this.btnOpenPacketsFolder.Size = new System.Drawing.Size(236, 36);
            this.btnOpenPacketsFolder.Text = "Open Packet Folder";
            this.btnOpenPacketsFolder.Click += new System.EventHandler(this.btnOpenPacketsFolder_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.gridSettings);
            this.tabSettings.Controls.Add(this.menuSettings);
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSettings.Size = new System.Drawing.Size(930, 688);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // gridSettings
            // 
            this.gridSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSettings.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridSettings.Location = new System.Drawing.Point(4, 44);
            this.gridSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridSettings.Name = "gridSettings";
            this.gridSettings.Size = new System.Drawing.Size(922, 640);
            this.gridSettings.TabIndex = 1;
            // 
            // menuSettings
            // 
            this.menuSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSettings.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSettings});
            this.menuSettings.Location = new System.Drawing.Point(4, 4);
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.Size = new System.Drawing.Size(922, 40);
            this.menuSettings.TabIndex = 0;
            this.menuSettings.Text = "menuStrip2";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(170, 36);
            this.btnSaveSettings.Text = "Save Settings";
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.lblKRelay);
            this.tabAbout.Controls.Add(this.pbxGang);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Controls.Add(this.lblCredits);
            this.tabAbout.Controls.Add(this.lblKronks);
            this.tabAbout.Controls.Add(this.lblVersion);
            this.tabAbout.Location = new System.Drawing.Point(4, 39);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Size = new System.Drawing.Size(930, 688);
            this.tabAbout.TabIndex = 5;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // lblKRelay
            // 
            this.lblKRelay.AutoSize = true;
            this.lblKRelay.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.lblKRelay.Location = new System.Drawing.Point(4, 4);
            this.lblKRelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKRelay.Name = "lblKRelay";
            this.lblKRelay.Size = new System.Drawing.Size(344, 128);
            this.lblKRelay.TabIndex = 0;
            this.lblKRelay.Text = "K Relay";
            // 
            // pbxGang
            // 
            this.pbxGang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxGang.Image = ((System.Drawing.Image)(resources.GetObject("pbxGang.Image")));
            this.pbxGang.Location = new System.Drawing.Point(30, 246);
            this.pbxGang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxGang.Name = "pbxGang";
            this.pbxGang.Size = new System.Drawing.Size(862, 438);
            this.pbxGang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGang.TabIndex = 5;
            this.pbxGang.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "helped me since day 1 and made this possible";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Font = new System.Drawing.Font("Segoe UI Light", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredits.Location = new System.Drawing.Point(24, 165);
            this.lblCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(479, 40);
            this.lblCredits.TabIndex = 3;
            this.lblCredits.Text = "very special thanks to the people who";
            // 
            // lblKronks
            // 
            this.lblKronks.AutoSize = true;
            this.lblKronks.Font = new System.Drawing.Font("Segoe UI Light", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKronks.Location = new System.Drawing.Point(22, 117);
            this.lblKronks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKronks.Name = "lblKronks";
            this.lblKronks.Size = new System.Drawing.Size(379, 50);
            this.lblKronks.TabIndex = 2;
            this.lblKronks.Text = "By KrazyShank / Kronks";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.lblVersion.Location = new System.Drawing.Point(630, 4);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(273, 128);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "v0.1.0";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(753, 0);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(180, 37);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Not Running";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 729);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Text = "K Relay";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.tabMain.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.menuInfo.ResumeLayout(false);
            this.menuInfo.PerformLayout();
            this.tabPlugins.ResumeLayout(false);
            this.tabPlugins.PerformLayout();
            this.splitPlugins.Panel1.ResumeLayout(false);
            this.splitPlugins.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPlugins)).EndInit();
            this.splitPlugins.ResumeLayout(false);
            this.menuPlugins.ResumeLayout(false);
            this.menuPlugins.PerformLayout();
            this.tabPackets.ResumeLayout(false);
            this.tabPackets.PerformLayout();
            this.splitPackets.Panel1.ResumeLayout(false);
            this.splitPackets.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPackets)).EndInit();
            this.splitPackets.ResumeLayout(false);
            this.menuPackets.ResumeLayout(false);
            this.menuPackets.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.menuSettings.ResumeLayout(false);
            this.menuSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imglistTabs;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabPlugins;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.MenuStrip menuPlugins;
        private System.Windows.Forms.ToolStripMenuItem btnOpenPluginFolder;
        private System.Windows.Forms.SplitContainer splitPlugins;
        private System.Windows.Forms.ListBox listPlugins;
        private System.Windows.Forms.MenuStrip menuSettings;
        public System.Windows.Forms.ToolStripMenuItem btnSaveSettings;
        public System.Windows.Forms.PropertyGrid gridSettings;
        private System.Windows.Forms.MenuStrip menuInfo;
        private System.Windows.Forms.ToolStripMenuItem btnToggleProxy;
        private System.Windows.Forms.TabPage tabPackets;
        private System.Windows.Forms.MenuStrip menuPackets;
        private System.Windows.Forms.ToolStripMenuItem btnOpenPacketsFolder;
        private System.Windows.Forms.SplitContainer splitPackets;
        private System.Windows.Forms.ListBox listPackets;
        private System.Windows.Forms.RichTextBox tbxPacketInfo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox tbxPluginInfo;
        private System.Windows.Forms.RichTextBox tbxLog;
        private System.Windows.Forms.ToolStripMenuItem btnSaveLog;
        private System.Windows.Forms.ToolStripMenuItem btnClearLog;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.Label lblKRelay;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblKronks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxGang;
    }
}

