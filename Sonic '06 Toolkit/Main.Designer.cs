﻿namespace Sonic_06_Toolkit
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mstrip_Main = new System.Windows.Forms.MenuStrip();
            this.menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.file_OpenARC = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.file_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_SDK = new System.Windows.Forms.ToolStripMenuItem();
            this.sdk_LUBStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.sdk_DecompileLUBs = new System.Windows.Forms.ToolStripMenuItem();
            this.sdk_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sdk_XNOStudio = new System.Windows.Forms.ToolStripMenuItem();
            this.sdk_ConvertXNOs = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Tabs = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs_NewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabs_CloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd_OpenARC = new System.Windows.Forms.OpenFileDialog();
            this.btn_SessionID = new System.Windows.Forms.Button();
            this.pnl_Backdrop = new System.Windows.Forms.Panel();
            this.btn_Forward = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Repack = new System.Windows.Forms.Button();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tm_tabCheck = new System.Windows.Forms.Timer(this.components);
            this.file_RepackARC = new System.Windows.Forms.ToolStripMenuItem();
            this.file_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mstrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrip_Main
            // 
            this.mstrip_Main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mstrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_File,
            this.menu_SDK,
            this.menu_Tabs,
            this.menu_Help});
            this.mstrip_Main.Location = new System.Drawing.Point(0, 0);
            this.mstrip_Main.Name = "mstrip_Main";
            this.mstrip_Main.Size = new System.Drawing.Size(800, 24);
            this.mstrip_Main.TabIndex = 0;
            this.mstrip_Main.Text = "menuStrip1";
            // 
            // menu_File
            // 
            this.menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_OpenARC,
            this.file_Separator1,
            this.file_RepackARC,
            this.file_Separator2,
            this.file_Exit});
            this.menu_File.Name = "menu_File";
            this.menu_File.Size = new System.Drawing.Size(37, 20);
            this.menu_File.Text = "File";
            // 
            // file_OpenARC
            // 
            this.file_OpenARC.Name = "file_OpenARC";
            this.file_OpenARC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.file_OpenARC.Size = new System.Drawing.Size(180, 22);
            this.file_OpenARC.Text = "Open ARC";
            this.file_OpenARC.Click += new System.EventHandler(this.File_OpenARC_Click);
            // 
            // file_Separator1
            // 
            this.file_Separator1.Name = "file_Separator1";
            this.file_Separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // file_Exit
            // 
            this.file_Exit.Name = "file_Exit";
            this.file_Exit.Size = new System.Drawing.Size(180, 22);
            this.file_Exit.Text = "Exit";
            this.file_Exit.Click += new System.EventHandler(this.File_Exit_Click);
            // 
            // menu_SDK
            // 
            this.menu_SDK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdk_LUBStudio,
            this.sdk_DecompileLUBs,
            this.sdk_Separator1,
            this.sdk_XNOStudio,
            this.sdk_ConvertXNOs});
            this.menu_SDK.Name = "menu_SDK";
            this.menu_SDK.Size = new System.Drawing.Size(40, 20);
            this.menu_SDK.Text = "SDK";
            // 
            // sdk_LUBStudio
            // 
            this.sdk_LUBStudio.Name = "sdk_LUBStudio";
            this.sdk_LUBStudio.Size = new System.Drawing.Size(260, 22);
            this.sdk_LUBStudio.Text = "LUB Studio...";
            // 
            // sdk_DecompileLUBs
            // 
            this.sdk_DecompileLUBs.Name = "sdk_DecompileLUBs";
            this.sdk_DecompileLUBs.Size = new System.Drawing.Size(260, 22);
            this.sdk_DecompileLUBs.Text = "Decompile all LUBs in this directory";
            // 
            // sdk_Separator1
            // 
            this.sdk_Separator1.Name = "sdk_Separator1";
            this.sdk_Separator1.Size = new System.Drawing.Size(257, 6);
            // 
            // sdk_XNOStudio
            // 
            this.sdk_XNOStudio.Name = "sdk_XNOStudio";
            this.sdk_XNOStudio.Size = new System.Drawing.Size(260, 22);
            this.sdk_XNOStudio.Text = "XNO Studio...";
            // 
            // sdk_ConvertXNOs
            // 
            this.sdk_ConvertXNOs.Name = "sdk_ConvertXNOs";
            this.sdk_ConvertXNOs.Size = new System.Drawing.Size(260, 22);
            this.sdk_ConvertXNOs.Text = "Convert all XNOs in this directory";
            // 
            // menu_Tabs
            // 
            this.menu_Tabs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabs_NewTab,
            this.tabs_Separator1,
            this.tabs_CloseTab});
            this.menu_Tabs.Name = "menu_Tabs";
            this.menu_Tabs.Size = new System.Drawing.Size(43, 20);
            this.menu_Tabs.Text = "Tabs";
            // 
            // tabs_NewTab
            // 
            this.tabs_NewTab.Name = "tabs_NewTab";
            this.tabs_NewTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tabs_NewTab.Size = new System.Drawing.Size(170, 22);
            this.tabs_NewTab.Text = "New Tab";
            this.tabs_NewTab.Click += new System.EventHandler(this.Tabs_NewTab_Click);
            // 
            // tabs_Separator1
            // 
            this.tabs_Separator1.Name = "tabs_Separator1";
            this.tabs_Separator1.Size = new System.Drawing.Size(167, 6);
            // 
            // tabs_CloseTab
            // 
            this.tabs_CloseTab.Enabled = false;
            this.tabs_CloseTab.Name = "tabs_CloseTab";
            this.tabs_CloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tabs_CloseTab.Size = new System.Drawing.Size(170, 22);
            this.tabs_CloseTab.Text = "Close Tab";
            this.tabs_CloseTab.Click += new System.EventHandler(this.Tabs_CloseTab_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_About});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(44, 20);
            this.menu_Help.Text = "Help";
            // 
            // help_About
            // 
            this.help_About.Name = "help_About";
            this.help_About.Size = new System.Drawing.Size(107, 22);
            this.help_About.Text = "About";
            this.help_About.Click += new System.EventHandler(this.Help_About_Click);
            // 
            // ofd_OpenARC
            // 
            this.ofd_OpenARC.DefaultExt = "arc";
            this.ofd_OpenARC.Filter = "ARC Files|*.ARC";
            this.ofd_OpenARC.Title = "Please select an ARC file...";
            // 
            // btn_SessionID
            // 
            this.btn_SessionID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SessionID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_SessionID.Enabled = false;
            this.btn_SessionID.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SessionID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SessionID.Location = new System.Drawing.Point(751, -1);
            this.btn_SessionID.Name = "btn_SessionID";
            this.btn_SessionID.Size = new System.Drawing.Size(49, 26);
            this.btn_SessionID.TabIndex = 1;
            this.btn_SessionID.Text = "2006";
            this.btn_SessionID.UseVisualStyleBackColor = false;
            // 
            // pnl_Backdrop
            // 
            this.pnl_Backdrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Backdrop.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_Backdrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Backdrop.Location = new System.Drawing.Point(-2, -2);
            this.pnl_Backdrop.Name = "pnl_Backdrop";
            this.pnl_Backdrop.Size = new System.Drawing.Size(805, 28);
            this.pnl_Backdrop.TabIndex = 3;
            // 
            // btn_Forward
            // 
            this.btn_Forward.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Forward.Enabled = false;
            this.btn_Forward.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Forward.Location = new System.Drawing.Point(228, -1);
            this.btn_Forward.Name = "btn_Forward";
            this.btn_Forward.Size = new System.Drawing.Size(55, 26);
            this.btn_Forward.TabIndex = 5;
            this.btn_Forward.Text = "Forward";
            this.btn_Forward.UseVisualStyleBackColor = false;
            this.btn_Forward.Click += new System.EventHandler(this.Btn_Forward_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Tomato;
            this.btn_Back.Enabled = false;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(174, -1);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(55, 26);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // btn_Repack
            // 
            this.btn_Repack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Repack.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Repack.Enabled = false;
            this.btn_Repack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Repack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Repack.Location = new System.Drawing.Point(690, -1);
            this.btn_Repack.Name = "btn_Repack";
            this.btn_Repack.Size = new System.Drawing.Size(62, 26);
            this.btn_Repack.TabIndex = 7;
            this.btn_Repack.Text = "Repack";
            this.btn_Repack.UseVisualStyleBackColor = false;
            this.btn_Repack.Click += new System.EventHandler(this.Btn_Repack_Click);
            // 
            // tab_Main
            // 
            this.tab_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Main.Location = new System.Drawing.Point(1, 26);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(800, 424);
            this.tab_Main.TabIndex = 8;
            // 
            // tm_tabCheck
            // 
            this.tm_tabCheck.Tick += new System.EventHandler(this.Tm_tabCheck_Tick);
            // 
            // file_RepackARC
            // 
            this.file_RepackARC.Name = "file_RepackARC";
            this.file_RepackARC.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_RepackARC.Size = new System.Drawing.Size(180, 22);
            this.file_RepackARC.Text = "Repack ARC";
            this.file_RepackARC.Click += new System.EventHandler(this.File_RepackARC_Click);
            // 
            // file_Separator2
            // 
            this.file_Separator2.Name = "file_Separator2";
            this.file_Separator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.btn_Repack);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Forward);
            this.Controls.Add(this.btn_SessionID);
            this.Controls.Add(this.mstrip_Main);
            this.Controls.Add(this.pnl_Backdrop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mstrip_Main;
            this.MinimumSize = new System.Drawing.Size(510, 245);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic \'06 Toolkit";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mstrip_Main.ResumeLayout(false);
            this.mstrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrip_Main;
        private System.Windows.Forms.ToolStripMenuItem menu_File;
        private System.Windows.Forms.ToolStripMenuItem menu_SDK;
        private System.Windows.Forms.ToolStripMenuItem menu_Tabs;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem file_OpenARC;
        private System.Windows.Forms.ToolStripSeparator file_Separator1;
        private System.Windows.Forms.ToolStripMenuItem file_Exit;
        private System.Windows.Forms.ToolStripMenuItem tabs_NewTab;
        private System.Windows.Forms.ToolStripSeparator tabs_Separator1;
        private System.Windows.Forms.ToolStripMenuItem tabs_CloseTab;
        private System.Windows.Forms.ToolStripMenuItem help_About;
        private System.Windows.Forms.ToolStripMenuItem sdk_LUBStudio;
        private System.Windows.Forms.ToolStripMenuItem sdk_DecompileLUBs;
        private System.Windows.Forms.ToolStripSeparator sdk_Separator1;
        private System.Windows.Forms.ToolStripMenuItem sdk_XNOStudio;
        private System.Windows.Forms.ToolStripMenuItem sdk_ConvertXNOs;
        private System.Windows.Forms.OpenFileDialog ofd_OpenARC;
        private System.Windows.Forms.Button btn_SessionID;
        private System.Windows.Forms.Panel pnl_Backdrop;
        private System.Windows.Forms.Button btn_Forward;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Repack;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.Timer tm_tabCheck;
        private System.Windows.Forms.ToolStripMenuItem file_RepackARC;
        private System.Windows.Forms.ToolStripSeparator file_Separator2;
    }
}

