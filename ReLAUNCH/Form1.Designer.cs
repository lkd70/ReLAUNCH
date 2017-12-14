namespace ReLAUNCH
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSelectPrograms = new System.Windows.Forms.Button();
            this.btnCheckNow = new System.Windows.Forms.Button();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReLAUNCH = new System.Windows.Forms.Label();
            this.btnMinimise = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabLogs = new Dotnetrix.Controls.TabControlEX();
            this.tabPageEX1 = new Dotnetrix.Controls.TabPageEX();
            this.btnClear = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.RichTextBox();
            this.tabPageEX2 = new Dotnetrix.Controls.TabPageEX();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.tabPageEX3 = new Dotnetrix.Controls.TabPageEX();
            this.rtbChangeLog = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgbControls = new BlackGroupBox();
            this.chkActive = new JCS.ToggleSwitch();
            this.lblActive = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabPageEX1.SuspendLayout();
            this.tabPageEX2.SuspendLayout();
            this.tabPageEX3.SuspendLayout();
            this.bgbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnSettings.Location = new System.Drawing.Point(12, 107);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(106, 23);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSelectPrograms
            // 
            this.btnSelectPrograms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSelectPrograms.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectPrograms.FlatAppearance.BorderSize = 0;
            this.btnSelectPrograms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPrograms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnSelectPrograms.Location = new System.Drawing.Point(12, 136);
            this.btnSelectPrograms.Name = "btnSelectPrograms";
            this.btnSelectPrograms.Size = new System.Drawing.Size(106, 23);
            this.btnSelectPrograms.TabIndex = 16;
            this.btnSelectPrograms.Text = "Programs";
            this.btnSelectPrograms.UseVisualStyleBackColor = false;
            this.btnSelectPrograms.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheckNow
            // 
            this.btnCheckNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCheckNow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckNow.FlatAppearance.BorderSize = 0;
            this.btnCheckNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnCheckNow.Location = new System.Drawing.Point(11, 165);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new System.Drawing.Size(107, 23);
            this.btnCheckNow.TabIndex = 20;
            this.btnCheckNow.Text = "Check Now";
            this.btnCheckNow.UseVisualStyleBackColor = false;
            this.btnCheckNow.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlBar.Controls.Add(this.label3);
            this.pnlBar.Controls.Add(this.lblReLAUNCH);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBar.Location = new System.Drawing.Point(-1, -1);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(656, 27);
            this.pnlBar.TabIndex = 21;
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(122, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "By LKD70";
            // 
            // lblReLAUNCH
            // 
            this.lblReLAUNCH.AutoSize = true;
            this.lblReLAUNCH.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReLAUNCH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReLAUNCH.Location = new System.Drawing.Point(5, 1);
            this.lblReLAUNCH.Name = "lblReLAUNCH";
            this.lblReLAUNCH.Size = new System.Drawing.Size(114, 27);
            this.lblReLAUNCH.TabIndex = 6;
            this.lblReLAUNCH.Text = "ReLAUNCH";
            // 
            // btnMinimise
            // 
            this.btnMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMinimise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnMinimise.Location = new System.Drawing.Point(603, -1);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(49, 27);
            this.btnMinimise.TabIndex = 23;
            this.btnMinimise.Text = " －";
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(652, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 27);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVersion.Location = new System.Drawing.Point(8, 35);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 13);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "Version: ";
            this.toolTip1.SetToolTip(this.lblVersion, "Click me to check for an update");
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabLogs
            // 
            this.tabLogs.AllowTabDrag = true;
            this.tabLogs.Appearance = Dotnetrix.Controls.TabAppearanceEX.FlatTab;
            this.tabLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tabLogs.Controls.Add(this.tabPageEX1);
            this.tabLogs.Controls.Add(this.tabPageEX2);
            this.tabLogs.Controls.Add(this.tabPageEX3);
            this.tabLogs.FlatBorderColor = System.Drawing.Color.Black;
            this.tabLogs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabLogs.Location = new System.Drawing.Point(124, 35);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.SelectedIndex = 0;
            this.tabLogs.SelectedTabFontStyle = System.Drawing.FontStyle.Bold;
            this.tabLogs.Size = new System.Drawing.Size(565, 153);
            this.tabLogs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabLogs.TabIndex = 23;
            this.tabLogs.UseVisualStyles = false;
            // 
            // tabPageEX1
            // 
            this.tabPageEX1.Controls.Add(this.btnClear);
            this.tabPageEX1.Controls.Add(this.log);
            this.tabPageEX1.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX1.Name = "tabPageEX1";
            this.tabPageEX1.Size = new System.Drawing.Size(557, 124);
            this.tabPageEX1.TabIndex = 0;
            this.tabPageEX1.Text = "Log";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(479, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(558, 118);
            this.log.TabIndex = 2;
            this.log.Text = "";
            // 
            // tabPageEX2
            // 
            this.tabPageEX2.Controls.Add(this.btnClear2);
            this.tabPageEX2.Controls.Add(this.debug);
            this.tabPageEX2.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX2.Name = "tabPageEX2";
            this.tabPageEX2.Size = new System.Drawing.Size(557, 124);
            this.tabPageEX2.TabIndex = 1;
            this.tabPageEX2.Text = "Debug";
            // 
            // btnClear2
            // 
            this.btnClear2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClear2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear2.FlatAppearance.BorderSize = 0;
            this.btnClear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnClear2.Location = new System.Drawing.Point(479, 3);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(60, 23);
            this.btnClear2.TabIndex = 24;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = false;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // debug
            // 
            this.debug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.debug.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.debug.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.debug.Location = new System.Drawing.Point(3, 3);
            this.debug.Name = "debug";
            this.debug.ReadOnly = true;
            this.debug.Size = new System.Drawing.Size(554, 118);
            this.debug.TabIndex = 23;
            this.debug.Text = "";
            // 
            // tabPageEX3
            // 
            this.tabPageEX3.Controls.Add(this.rtbChangeLog);
            this.tabPageEX3.Location = new System.Drawing.Point(4, 25);
            this.tabPageEX3.Name = "tabPageEX3";
            this.tabPageEX3.Size = new System.Drawing.Size(557, 124);
            this.tabPageEX3.TabIndex = 2;
            this.tabPageEX3.Text = "ChangeLog";
            // 
            // rtbChangeLog
            // 
            this.rtbChangeLog.AcceptsTab = true;
            this.rtbChangeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbChangeLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.rtbChangeLog.Location = new System.Drawing.Point(4, 3);
            this.rtbChangeLog.Name = "rtbChangeLog";
            this.rtbChangeLog.ReadOnly = true;
            this.rtbChangeLog.Size = new System.Drawing.Size(550, 117);
            this.rtbChangeLog.TabIndex = 0;
            this.rtbChangeLog.Text = "";
            // 
            // bgbControls
            // 
            this.bgbControls.BorderColor = System.Drawing.Color.Black;
            this.bgbControls.Controls.Add(this.chkActive);
            this.bgbControls.Controls.Add(this.lblActive);
            this.bgbControls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bgbControls.Location = new System.Drawing.Point(12, 57);
            this.bgbControls.Name = "bgbControls";
            this.bgbControls.Size = new System.Drawing.Size(106, 44);
            this.bgbControls.TabIndex = 17;
            this.bgbControls.TabStop = false;
            this.bgbControls.Text = "Controls ";
            // 
            // chkActive
            // 
            this.chkActive.GrayWhenDisabled = false;
            this.chkActive.Location = new System.Drawing.Point(55, 15);
            this.chkActive.Name = "chkActive";
            this.chkActive.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Size = new System.Drawing.Size(41, 19);
            this.chkActive.TabIndex = 23;
            this.chkActive.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.chkActive_CheckedChanged);
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblActive.Location = new System.Drawing.Point(7, 17);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(40, 13);
            this.lblActive.TabIndex = 20;
            this.lblActive.Text = "Active:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(701, 197);
            this.Controls.Add(this.tabLogs);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnMinimise);
            this.Controls.Add(this.btnCheckNow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bgbControls);
            this.Controls.Add(this.btnSelectPrograms);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.pnlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReLAUNCH";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabPageEX1.ResumeLayout(false);
            this.tabPageEX2.ResumeLayout(false);
            this.tabPageEX3.ResumeLayout(false);
            this.bgbControls.ResumeLayout(false);
            this.bgbControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BlackGroupBox bgbControls;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSelectPrograms;
        public JCS.ToggleSwitch chkActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Label lblReLAUNCH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Button btnCheckNow;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimise;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Timer timer;
        private Dotnetrix.Controls.TabControlEX tabLogs;
        private Dotnetrix.Controls.TabPageEX tabPageEX1;
        private Dotnetrix.Controls.TabPageEX tabPageEX2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.ToolTip toolTip1;
        private Dotnetrix.Controls.TabPageEX tabPageEX3;
        private System.Windows.Forms.RichTextBox rtbChangeLog;
    }
}

