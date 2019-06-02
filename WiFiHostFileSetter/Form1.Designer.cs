namespace WiFiHostFileSetter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wlanCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enableBtn = new System.Windows.Forms.Button();
            this.settingsBox = new System.Windows.Forms.GroupBox();
            this.askChk = new System.Windows.Forms.CheckBox();
            this.autoStartChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.applyBtn = new System.Windows.Forms.Button();
            this.saveApplyBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ssidList = new System.Windows.Forms.ComboBox();
            this.hostFileEditor = new ICSharpCode.TextEditor.TextEditorControl();
            this.watchdog = new System.Windows.Forms.Timer(this.components);
            this.uiUpdater = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startHidden = new System.Windows.Forms.CheckBox();
            this.settingsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wlanCombobox
            // 
            this.wlanCombobox.FormattingEnabled = true;
            this.wlanCombobox.Location = new System.Drawing.Point(66, 26);
            this.wlanCombobox.Name = "wlanCombobox";
            this.wlanCombobox.Size = new System.Drawing.Size(226, 21);
            this.wlanCombobox.TabIndex = 0;
            this.wlanCombobox.SelectedIndexChanged += new System.EventHandler(this.wlanCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Interface";
            // 
            // enableBtn
            // 
            this.enableBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enableBtn.Enabled = false;
            this.enableBtn.Location = new System.Drawing.Point(869, 514);
            this.enableBtn.Name = "enableBtn";
            this.enableBtn.Size = new System.Drawing.Size(109, 23);
            this.enableBtn.TabIndex = 2;
            this.enableBtn.Text = "Begin listening";
            this.enableBtn.UseVisualStyleBackColor = true;
            this.enableBtn.Click += new System.EventHandler(this.enableBtn_Click);
            // 
            // settingsBox
            // 
            this.settingsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBox.Controls.Add(this.startHidden);
            this.settingsBox.Controls.Add(this.askChk);
            this.settingsBox.Controls.Add(this.autoStartChk);
            this.settingsBox.Controls.Add(this.label2);
            this.settingsBox.Controls.Add(this.intervalUpDown);
            this.settingsBox.Controls.Add(this.label1);
            this.settingsBox.Controls.Add(this.wlanCombobox);
            this.settingsBox.Location = new System.Drawing.Point(15, 423);
            this.settingsBox.Name = "settingsBox";
            this.settingsBox.Size = new System.Drawing.Size(966, 85);
            this.settingsBox.TabIndex = 3;
            this.settingsBox.TabStop = false;
            this.settingsBox.Text = "Settings";
            // 
            // askChk
            // 
            this.askChk.AutoSize = true;
            this.askChk.Location = new System.Drawing.Point(298, 55);
            this.askChk.Name = "askChk";
            this.askChk.Size = new System.Drawing.Size(168, 17);
            this.askChk.TabIndex = 5;
            this.askChk.Text = "Ask before switching host files";
            this.askChk.UseVisualStyleBackColor = true;
            this.askChk.CheckedChanged += new System.EventHandler(this.askChk_CheckedChanged);
            // 
            // autoStartChk
            // 
            this.autoStartChk.AutoSize = true;
            this.autoStartChk.Location = new System.Drawing.Point(298, 28);
            this.autoStartChk.Name = "autoStartChk";
            this.autoStartChk.Size = new System.Drawing.Size(71, 17);
            this.autoStartChk.TabIndex = 4;
            this.autoStartChk.Text = "Auto-start";
            this.autoStartChk.UseVisualStyleBackColor = true;
            this.autoStartChk.CheckedChanged += new System.EventHandler(this.autoStartChk_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Check interval (s)";
            // 
            // intervalUpDown
            // 
            this.intervalUpDown.Location = new System.Drawing.Point(219, 53);
            this.intervalUpDown.Name = "intervalUpDown";
            this.intervalUpDown.Size = new System.Drawing.Size(73, 20);
            this.intervalUpDown.TabIndex = 2;
            this.intervalUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intervalUpDown.ValueChanged += new System.EventHandler(this.intervalUpDown_ValueChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 519);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 13);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status: Idle";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.applyBtn);
            this.groupBox2.Controls.Add(this.saveApplyBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ssidList);
            this.groupBox2.Controls.Add(this.hostFileEditor);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(966, 405);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Host file preferences";
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Enabled = false;
            this.applyBtn.Location = new System.Drawing.Point(786, 14);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 4;
            this.applyBtn.Text = "Apply (F5)";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // saveApplyBtn
            // 
            this.saveApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveApplyBtn.Enabled = false;
            this.saveApplyBtn.Location = new System.Drawing.Point(867, 14);
            this.saveApplyBtn.Name = "saveApplyBtn";
            this.saveApplyBtn.Size = new System.Drawing.Size(93, 23);
            this.saveApplyBtn.TabIndex = 3;
            this.saveApplyBtn.Text = "Save (Ctrl+S)";
            this.saveApplyBtn.UseVisualStyleBackColor = true;
            this.saveApplyBtn.Click += new System.EventHandler(this.saveApplyBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SSID";
            // 
            // ssidList
            // 
            this.ssidList.FormattingEnabled = true;
            this.ssidList.Location = new System.Drawing.Point(52, 16);
            this.ssidList.Name = "ssidList";
            this.ssidList.Size = new System.Drawing.Size(243, 21);
            this.ssidList.TabIndex = 1;
            this.ssidList.SelectedIndexChanged += new System.EventHandler(this.ssidList_SelectedIndexChanged);
            // 
            // hostFileEditor
            // 
            this.hostFileEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hostFileEditor.ConvertTabsToSpaces = true;
            this.hostFileEditor.Highlighting = "C++.NET";
            this.hostFileEditor.Location = new System.Drawing.Point(6, 43);
            this.hostFileEditor.Name = "hostFileEditor";
            this.hostFileEditor.Size = new System.Drawing.Size(954, 356);
            this.hostFileEditor.TabIndex = 0;
            this.hostFileEditor.Text = "# Copyright (c) 1993-2009 Microsoft Corp.";
            this.hostFileEditor.TextChanged += new System.EventHandler(this.hostFileEditor_TextChanged);
            // 
            // watchdog
            // 
            this.watchdog.Interval = 5000;
            this.watchdog.Tick += new System.EventHandler(this.watchdog_Tick);
            // 
            // uiUpdater
            // 
            this.uiUpdater.Enabled = true;
            this.uiUpdater.Tick += new System.EventHandler(this.uiUpdater_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.trayMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Host file updater";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(117, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.showToolStripMenuItem.Text = "Settings";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.applyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveApplyBtn_Click);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // startHidden
            // 
            this.startHidden.AutoSize = true;
            this.startHidden.Location = new System.Drawing.Point(375, 28);
            this.startHidden.Name = "startHidden";
            this.startHidden.Size = new System.Drawing.Size(83, 17);
            this.startHidden.TabIndex = 6;
            this.startHidden.Text = "Start hidden";
            this.startHidden.UseVisualStyleBackColor = true;
            this.startHidden.CheckedChanged += new System.EventHandler(this.startHidden_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 549);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.settingsBox);
            this.Controls.Add(this.enableBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Host file updater";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.settingsBox.ResumeLayout(false);
            this.settingsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.trayMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox wlanCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enableBtn;
        private System.Windows.Forms.GroupBox settingsBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown intervalUpDown;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button saveApplyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ssidList;
        private ICSharpCode.TextEditor.TextEditorControl hostFileEditor;
        private System.Windows.Forms.Timer watchdog;
        private System.Windows.Forms.CheckBox askChk;
        private System.Windows.Forms.CheckBox autoStartChk;
        private System.Windows.Forms.Timer uiUpdater;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.CheckBox startHidden;
    }
}

