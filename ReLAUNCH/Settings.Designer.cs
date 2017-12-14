namespace ReLAUNCH
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.bgbUI = new BlackGroupBox();
            this.chkDarkTheme = new JCS.ToggleSwitch();
            this.lblDarkTheme = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCustomColour = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bgbApplicationSettings = new BlackGroupBox();
            this.nudDelay = new DarkNumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblDBDir = new System.Windows.Forms.Label();
            this.lblAutoActivate = new System.Windows.Forms.Label();
            this.chkStartWithWindows = new JCS.ToggleSwitch();
            this.lblStartWithWindows = new System.Windows.Forms.Label();
            this.chkAutoActivate = new JCS.ToggleSwitch();
            this.bgbGlobalDefaults = new BlackGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtGlobalCommandLine = new System.Windows.Forms.TextBox();
            this.lblGlobalCommandLine = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDuplicates = new JCS.ToggleSwitch();
            this.lblCloseDuplicates = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkResponding = new JCS.ToggleSwitch();
            this.lblCheckResponding = new System.Windows.Forms.Label();
            this.nudDelayBetween = new DarkNumericUpDown();
            this.lblDelayBetween = new System.Windows.Forms.Label();
            this.pnlBar.SuspendLayout();
            this.bgbUI.SuspendLayout();
            this.bgbApplicationSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            this.bgbGlobalDefaults.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayBetween)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(87, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(180, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "Settings.db";
            this.openFileDialog1.Filter = "Database File: .db|*.DB";
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlBar.Controls.Add(this.lblSettings);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBar.Location = new System.Drawing.Point(1, -1);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(282, 27);
            this.pnlBar.TabIndex = 24;
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSettings.Location = new System.Drawing.Point(5, -1);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(87, 27);
            this.lblSettings.TabIndex = 6;
            this.lblSettings.Text = "Settings";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.White;
            this.colorDialog1.FullOpen = true;
            this.colorDialog1.SolidColorOnly = true;
            // 
            // bgbUI
            // 
            this.bgbUI.BorderColor = System.Drawing.Color.Black;
            this.bgbUI.Controls.Add(this.chkDarkTheme);
            this.bgbUI.Controls.Add(this.lblDarkTheme);
            this.bgbUI.Controls.Add(this.button6);
            this.bgbUI.Controls.Add(this.button5);
            this.bgbUI.Controls.Add(this.button4);
            this.bgbUI.Controls.Add(this.button3);
            this.bgbUI.Controls.Add(this.btnCustomColour);
            this.bgbUI.Controls.Add(this.button2);
            this.bgbUI.ForeColor = System.Drawing.SystemColors.Control;
            this.bgbUI.Location = new System.Drawing.Point(15, 295);
            this.bgbUI.Name = "bgbUI";
            this.bgbUI.Size = new System.Drawing.Size(252, 85);
            this.bgbUI.TabIndex = 27;
            this.bgbUI.TabStop = false;
            this.bgbUI.Text = "UI";
            // 
            // chkDarkTheme
            // 
            this.chkDarkTheme.Location = new System.Drawing.Point(193, 57);
            this.chkDarkTheme.Name = "chkDarkTheme";
            this.chkDarkTheme.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkTheme.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDarkTheme.Size = new System.Drawing.Size(50, 19);
            this.chkDarkTheme.TabIndex = 25;
            this.chkDarkTheme.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.chkDarkTheme_CheckedChanged);
            // 
            // lblDarkTheme
            // 
            this.lblDarkTheme.AutoSize = true;
            this.lblDarkTheme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDarkTheme.Location = new System.Drawing.Point(8, 63);
            this.lblDarkTheme.Name = "lblDarkTheme";
            this.lblDarkTheme.Size = new System.Drawing.Size(69, 13);
            this.lblDarkTheme.TabIndex = 24;
            this.lblDarkTheme.Text = "Dark Theme:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Magenta;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(5, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 23;
            this.toolTip1.SetToolTip(this.button6, "Set the UI colour to Magenta");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(46, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 22;
            this.toolTip1.SetToolTip(this.button5, "Set the UI colour to blue");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(87, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 21;
            this.toolTip1.SetToolTip(this.button4, "Set the UI colour to yellow");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(128, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button3, "Set the UI colour to IndianRed");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCustomColour
            // 
            this.btnCustomColour.BackColor = System.Drawing.Color.White;
            this.btnCustomColour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomColour.BackgroundImage")));
            this.btnCustomColour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomColour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomColour.FlatAppearance.BorderSize = 0;
            this.btnCustomColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomColour.ForeColor = System.Drawing.Color.Black;
            this.btnCustomColour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomColour.Location = new System.Drawing.Point(210, 19);
            this.btnCustomColour.Name = "btnCustomColour";
            this.btnCustomColour.Size = new System.Drawing.Size(36, 23);
            this.btnCustomColour.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnCustomColour, "Pick a custom colour, I\'d keep it light if I was you");
            this.btnCustomColour.UseVisualStyleBackColor = false;
            this.btnCustomColour.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(169, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button2, "Set the UI colour to Aqua");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bgbApplicationSettings
            // 
            this.bgbApplicationSettings.BorderColor = System.Drawing.Color.Black;
            this.bgbApplicationSettings.Controls.Add(this.nudDelayBetween);
            this.bgbApplicationSettings.Controls.Add(this.lblDelayBetween);
            this.bgbApplicationSettings.Controls.Add(this.nudDelay);
            this.bgbApplicationSettings.Controls.Add(this.lblDelay);
            this.bgbApplicationSettings.Controls.Add(this.btnBrowse);
            this.bgbApplicationSettings.Controls.Add(this.lblDBDir);
            this.bgbApplicationSettings.Controls.Add(this.lblAutoActivate);
            this.bgbApplicationSettings.Controls.Add(this.chkStartWithWindows);
            this.bgbApplicationSettings.Controls.Add(this.lblStartWithWindows);
            this.bgbApplicationSettings.Controls.Add(this.chkAutoActivate);
            this.bgbApplicationSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.bgbApplicationSettings.Location = new System.Drawing.Point(15, 146);
            this.bgbApplicationSettings.Name = "bgbApplicationSettings";
            this.bgbApplicationSettings.Size = new System.Drawing.Size(252, 145);
            this.bgbApplicationSettings.TabIndex = 26;
            this.bgbApplicationSettings.TabStop = false;
            this.bgbApplicationSettings.Text = "Application Settings..";
            // 
            // nudDelay
            // 
            this.nudDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDelay.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDelay.Location = new System.Drawing.Point(166, 20);
            this.nudDelay.Margin = new System.Windows.Forms.Padding(0);
            this.nudDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(77, 16);
            this.nudDelay.TabIndex = 23;
            this.nudDelay.ThousandsSeparator = true;
            this.nudDelay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDelay.Location = new System.Drawing.Point(8, 23);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(121, 13);
            this.lblDelay.TabIndex = 19;
            this.lblDelay.Text = "Delay Between Checks:";
            this.toolTip1.SetToolTip(this.lblDelay, "Delay between checking if a program is running/responding in seconds");
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(166, 113);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(77, 24);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.btnBrowse, "Change the directory of the programs database. If it doesn\'t exist it will be cre" +
        "ated.");
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // lblDBDir
            // 
            this.lblDBDir.AutoSize = true;
            this.lblDBDir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDBDir.Location = new System.Drawing.Point(8, 119);
            this.lblDBDir.Name = "lblDBDir";
            this.lblDBDir.Size = new System.Drawing.Size(101, 13);
            this.lblDBDir.TabIndex = 20;
            this.lblDBDir.Text = "Database Directory:";
            this.toolTip1.SetToolTip(this.lblDBDir, "Change the directory of the programs database. If it doesn\'t exist it will be cre" +
        "ated.");
            // 
            // lblAutoActivate
            // 
            this.lblAutoActivate.AutoSize = true;
            this.lblAutoActivate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAutoActivate.Location = new System.Drawing.Point(8, 69);
            this.lblAutoActivate.Name = "lblAutoActivate";
            this.lblAutoActivate.Size = new System.Drawing.Size(171, 13);
            this.lblAutoActivate.TabIndex = 21;
            this.lblAutoActivate.Text = "Auto activate when program starts:";
            this.toolTip1.SetToolTip(this.lblAutoActivate, "When ReLAUNCH starts, set Active to on?");
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.Location = new System.Drawing.Point(193, 88);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartWithWindows.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartWithWindows.Size = new System.Drawing.Size(50, 19);
            this.chkStartWithWindows.TabIndex = 24;
            this.toolTip1.SetToolTip(this.chkStartWithWindows, "Start ReLAUNCH when windows starts?");
            // 
            // lblStartWithWindows
            // 
            this.lblStartWithWindows.AutoSize = true;
            this.lblStartWithWindows.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartWithWindows.Location = new System.Drawing.Point(8, 94);
            this.lblStartWithWindows.Name = "lblStartWithWindows";
            this.lblStartWithWindows.Size = new System.Drawing.Size(104, 13);
            this.lblStartWithWindows.TabIndex = 22;
            this.lblStartWithWindows.Text = "Start With Windows:";
            this.toolTip1.SetToolTip(this.lblStartWithWindows, "Start ReLAUNCH when windows starts?");
            // 
            // chkAutoActivate
            // 
            this.chkAutoActivate.Location = new System.Drawing.Point(193, 63);
            this.chkAutoActivate.Name = "chkAutoActivate";
            this.chkAutoActivate.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoActivate.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoActivate.Size = new System.Drawing.Size(50, 19);
            this.chkAutoActivate.TabIndex = 25;
            this.toolTip1.SetToolTip(this.chkAutoActivate, "When ReLAUNCH starts, set Active to on?");
            // 
            // bgbGlobalDefaults
            // 
            this.bgbGlobalDefaults.BorderColor = System.Drawing.Color.Black;
            this.bgbGlobalDefaults.Controls.Add(this.panel3);
            this.bgbGlobalDefaults.Controls.Add(this.panel2);
            this.bgbGlobalDefaults.Controls.Add(this.panel1);
            this.bgbGlobalDefaults.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bgbGlobalDefaults.Location = new System.Drawing.Point(15, 33);
            this.bgbGlobalDefaults.Name = "bgbGlobalDefaults";
            this.bgbGlobalDefaults.Size = new System.Drawing.Size(252, 107);
            this.bgbGlobalDefaults.TabIndex = 25;
            this.bgbGlobalDefaults.TabStop = false;
            this.bgbGlobalDefaults.Text = "Global Defaults ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtGlobalCommandLine);
            this.panel3.Controls.Add(this.lblGlobalCommandLine);
            this.panel3.Location = new System.Drawing.Point(5, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 26);
            this.panel3.TabIndex = 12;
            // 
            // txtGlobalCommandLine
            // 
            this.txtGlobalCommandLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtGlobalCommandLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGlobalCommandLine.ForeColor = System.Drawing.Color.White;
            this.txtGlobalCommandLine.Location = new System.Drawing.Point(123, 6);
            this.txtGlobalCommandLine.Name = "txtGlobalCommandLine";
            this.txtGlobalCommandLine.Size = new System.Drawing.Size(115, 13);
            this.txtGlobalCommandLine.TabIndex = 1;
            // 
            // lblGlobalCommandLine
            // 
            this.lblGlobalCommandLine.AutoSize = true;
            this.lblGlobalCommandLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGlobalCommandLine.Location = new System.Drawing.Point(3, 6);
            this.lblGlobalCommandLine.Name = "lblGlobalCommandLine";
            this.lblGlobalCommandLine.Size = new System.Drawing.Size(115, 13);
            this.lblGlobalCommandLine.TabIndex = 0;
            this.lblGlobalCommandLine.Text = "CommandLine Params:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkDuplicates);
            this.panel2.Controls.Add(this.lblCloseDuplicates);
            this.panel2.Location = new System.Drawing.Point(5, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 26);
            this.panel2.TabIndex = 5;
            // 
            // chkDuplicates
            // 
            this.chkDuplicates.Location = new System.Drawing.Point(188, 0);
            this.chkDuplicates.Name = "chkDuplicates";
            this.chkDuplicates.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuplicates.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDuplicates.Size = new System.Drawing.Size(50, 19);
            this.chkDuplicates.TabIndex = 11;
            this.chkDuplicates.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.chkDuplicates_CheckedChanged);
            // 
            // lblCloseDuplicates
            // 
            this.lblCloseDuplicates.AutoSize = true;
            this.lblCloseDuplicates.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCloseDuplicates.Location = new System.Drawing.Point(3, 6);
            this.lblCloseDuplicates.Name = "lblCloseDuplicates";
            this.lblCloseDuplicates.Size = new System.Drawing.Size(89, 13);
            this.lblCloseDuplicates.TabIndex = 0;
            this.lblCloseDuplicates.Text = "Close Duplicates:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkResponding);
            this.panel1.Controls.Add(this.lblCheckResponding);
            this.panel1.Location = new System.Drawing.Point(5, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 29);
            this.panel1.TabIndex = 4;
            // 
            // chkResponding
            // 
            this.chkResponding.Location = new System.Drawing.Point(188, 4);
            this.chkResponding.Name = "chkResponding";
            this.chkResponding.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResponding.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResponding.Size = new System.Drawing.Size(50, 19);
            this.chkResponding.TabIndex = 10;
            // 
            // lblCheckResponding
            // 
            this.lblCheckResponding.AutoSize = true;
            this.lblCheckResponding.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCheckResponding.Location = new System.Drawing.Point(3, 10);
            this.lblCheckResponding.Name = "lblCheckResponding";
            this.lblCheckResponding.Size = new System.Drawing.Size(152, 13);
            this.lblCheckResponding.TabIndex = 0;
            this.lblCheckResponding.Text = "Check for responding program:";
            // 
            // nudDelayBetween
            // 
            this.nudDelayBetween.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudDelayBetween.DecimalPlaces = 1;
            this.nudDelayBetween.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDelayBetween.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDelayBetween.Location = new System.Drawing.Point(166, 43);
            this.nudDelayBetween.Margin = new System.Windows.Forms.Padding(0);
            this.nudDelayBetween.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDelayBetween.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDelayBetween.Name = "nudDelayBetween";
            this.nudDelayBetween.Size = new System.Drawing.Size(77, 16);
            this.nudDelayBetween.TabIndex = 28;
            this.nudDelayBetween.ThousandsSeparator = true;
            this.nudDelayBetween.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblDelayBetween
            // 
            this.lblDelayBetween.AutoSize = true;
            this.lblDelayBetween.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDelayBetween.Location = new System.Drawing.Point(8, 46);
            this.lblDelayBetween.Name = "lblDelayBetween";
            this.lblDelayBetween.Size = new System.Drawing.Size(127, 13);
            this.lblDelayBetween.TabIndex = 27;
            this.lblDelayBetween.Text = "Delay between launches:";
            this.toolTip1.SetToolTip(this.lblDelayBetween, "Sleep delay between launches");
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(283, 425);
            this.ControlBox = false;
            this.Controls.Add(this.bgbUI);
            this.Controls.Add(this.bgbApplicationSettings);
            this.Controls.Add(this.bgbGlobalDefaults);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.bgbUI.ResumeLayout(false);
            this.bgbUI.PerformLayout();
            this.bgbApplicationSettings.ResumeLayout(false);
            this.bgbApplicationSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            this.bgbGlobalDefaults.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayBetween)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCustomColour;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnlBar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel panel2;
        public JCS.ToggleSwitch chkDuplicates;
        private System.Windows.Forms.Panel panel1;
        public JCS.ToggleSwitch chkResponding;
        public DarkNumericUpDown nudDelay;
        public System.Windows.Forms.Button btnBrowse;
        public JCS.ToggleSwitch chkStartWithWindows;
        public JCS.ToggleSwitch chkAutoActivate;
        public JCS.ToggleSwitch chkDarkTheme;
        public BlackGroupBox bgbGlobalDefaults;
        public System.Windows.Forms.Label lblCloseDuplicates;
        public System.Windows.Forms.Label lblCheckResponding;
        public BlackGroupBox bgbApplicationSettings;
        public System.Windows.Forms.Label lblDelay;
        public System.Windows.Forms.Label lblDBDir;
        public System.Windows.Forms.Label lblAutoActivate;
        public System.Windows.Forms.Label lblStartWithWindows;
        public System.Windows.Forms.Label lblDarkTheme;
        public BlackGroupBox bgbUI;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblGlobalCommandLine;
        public System.Windows.Forms.TextBox txtGlobalCommandLine;
        public DarkNumericUpDown nudDelayBetween;
        public System.Windows.Forms.Label lblDelayBetween;
    }
}