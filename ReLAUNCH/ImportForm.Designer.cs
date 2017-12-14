namespace ReLAUNCH
{
    partial class ImportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImport = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Executable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExecutablePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckResponding = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KillDuplicates = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LoopLaunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LoopLaunchCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bgbImportRules = new BlackGroupBox();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.chkMaintainOn = new JCS.ToggleSwitch();
            this.lblPass = new System.Windows.Forms.Label();
            this.chkAddPassword = new JCS.ToggleSwitch();
            this.lblNotes = new System.Windows.Forms.Label();
            this.chkMergeNotes = new JCS.ToggleSwitch();
            this.blackPanel1 = new BlackPanel();
            this.bgbCheck = new BlackGroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLoadDatabase = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSelect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlBar.SuspendLayout();
            this.bgbImportRules.SuspendLayout();
            this.blackPanel1.SuspendLayout();
            this.bgbCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnImport.Location = new System.Drawing.Point(1077, 433);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(111, 23);
            this.btnImport.TabIndex = 33;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramName,
            this.RunActive,
            this.Executable,
            this.ExecutablePath,
            this.CheckResponding,
            this.KillDuplicates,
            this.LoopLaunch,
            this.LoopLaunchCounter,
            this.CustomParams,
            this.Notes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvList.Location = new System.Drawing.Point(222, 44);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.ShowEditingIcon = false;
            this.dgvList.Size = new System.Drawing.Size(966, 380);
            this.dgvList.TabIndex = 34;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProgramName.HeaderText = "Name";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Width = 58;
            // 
            // RunActive
            // 
            this.RunActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RunActive.HeaderText = "Active";
            this.RunActive.Name = "RunActive";
            this.RunActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RunActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RunActive.Width = 60;
            // 
            // Executable
            // 
            this.Executable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Executable.HeaderText = "Executable";
            this.Executable.Name = "Executable";
            this.Executable.Text = "Browse";
            this.Executable.ToolTipText = "Browse for the program file";
            this.Executable.Width = 64;
            // 
            // ExecutablePath
            // 
            this.ExecutablePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExecutablePath.HeaderText = "ExecutablePath";
            this.ExecutablePath.Name = "ExecutablePath";
            this.ExecutablePath.ReadOnly = true;
            this.ExecutablePath.Width = 105;
            // 
            // CheckResponding
            // 
            this.CheckResponding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckResponding.HeaderText = "Check Responding";
            this.CheckResponding.Items.AddRange(new object[] {
            "Default",
            "Yes",
            "No"});
            this.CheckResponding.Name = "CheckResponding";
            this.CheckResponding.Width = 92;
            // 
            // KillDuplicates
            // 
            this.KillDuplicates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KillDuplicates.HeaderText = "Kill Duplicates";
            this.KillDuplicates.Items.AddRange(new object[] {
            "Default",
            "Yes",
            "No"});
            this.KillDuplicates.Name = "KillDuplicates";
            this.KillDuplicates.Width = 69;
            // 
            // LoopLaunch
            // 
            this.LoopLaunch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoopLaunch.HeaderText = "Loop Launch";
            this.LoopLaunch.Name = "LoopLaunch";
            this.LoopLaunch.Width = 66;
            // 
            // LoopLaunchCounter
            // 
            this.LoopLaunchCounter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoopLaunchCounter.HeaderText = "Loop Launch Count";
            this.LoopLaunchCounter.Name = "LoopLaunchCounter";
            this.LoopLaunchCounter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoopLaunchCounter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoopLaunchCounter.Width = 94;
            // 
            // CustomParams
            // 
            this.CustomParams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomParams.HeaderText = "Custom Params";
            this.CustomParams.Name = "CustomParams";
            this.CustomParams.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomParams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CustomParams.Width = 75;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Notes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlBar
            // 
            this.pnlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.pnlBar.Controls.Add(this.lblTitle);
            this.pnlBar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBar.Location = new System.Drawing.Point(0, 0);
            this.pnlBar.Name = "pnlBar";
            this.pnlBar.Size = new System.Drawing.Size(1200, 27);
            this.pnlBar.TabIndex = 36;
            this.pnlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBar_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(5, 1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 27);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Import from DB";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(960, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bgbImportRules
            // 
            this.bgbImportRules.BorderColor = System.Drawing.Color.Black;
            this.bgbImportRules.Controls.Add(this.lblMaintain);
            this.bgbImportRules.Controls.Add(this.chkMaintainOn);
            this.bgbImportRules.Controls.Add(this.lblPass);
            this.bgbImportRules.Controls.Add(this.chkAddPassword);
            this.bgbImportRules.Controls.Add(this.lblNotes);
            this.bgbImportRules.Controls.Add(this.chkMergeNotes);
            this.bgbImportRules.ForeColor = System.Drawing.Color.White;
            this.bgbImportRules.Location = new System.Drawing.Point(12, 197);
            this.bgbImportRules.Name = "bgbImportRules";
            this.bgbImportRules.Size = new System.Drawing.Size(200, 227);
            this.bgbImportRules.TabIndex = 35;
            this.bgbImportRules.TabStop = false;
            this.bgbImportRules.Text = "Import Rules ";
            this.bgbImportRules.Visible = false;
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.ForeColor = System.Drawing.Color.White;
            this.lblMaintain.Location = new System.Drawing.Point(6, 75);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(106, 13);
            this.lblMaintain.TabIndex = 29;
            this.lblMaintain.Text = "Active = MaintainOn:";
            // 
            // chkMaintainOn
            // 
            this.chkMaintainOn.Checked = true;
            this.chkMaintainOn.GrayWhenDisabled = false;
            this.chkMaintainOn.Location = new System.Drawing.Point(153, 72);
            this.chkMaintainOn.Name = "chkMaintainOn";
            this.chkMaintainOn.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaintainOn.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaintainOn.Size = new System.Drawing.Size(41, 19);
            this.chkMaintainOn.TabIndex = 28;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(6, 50);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(78, 13);
            this.lblPass.TabIndex = 27;
            this.lblPass.Text = "Add Password:";
            // 
            // chkAddPassword
            // 
            this.chkAddPassword.Checked = true;
            this.chkAddPassword.GrayWhenDisabled = false;
            this.chkAddPassword.Location = new System.Drawing.Point(153, 47);
            this.chkAddPassword.Name = "chkAddPassword";
            this.chkAddPassword.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddPassword.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddPassword.Size = new System.Drawing.Size(41, 19);
            this.chkAddPassword.TabIndex = 26;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.ForeColor = System.Drawing.Color.White;
            this.lblNotes.Location = new System.Drawing.Point(6, 25);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(123, 13);
            this.lblNotes.TabIndex = 25;
            this.lblNotes.Text = "Merge \"Notes\" columns:";
            // 
            // chkMergeNotes
            // 
            this.chkMergeNotes.Checked = true;
            this.chkMergeNotes.GrayWhenDisabled = false;
            this.chkMergeNotes.Location = new System.Drawing.Point(153, 22);
            this.chkMergeNotes.Name = "chkMergeNotes";
            this.chkMergeNotes.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMergeNotes.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMergeNotes.Size = new System.Drawing.Size(41, 19);
            this.chkMergeNotes.TabIndex = 24;
            // 
            // blackPanel1
            // 
            this.blackPanel1.BorderColor = System.Drawing.Color.Black;
            this.blackPanel1.Controls.Add(this.bgbCheck);
            this.blackPanel1.Controls.Add(this.btnLoadDatabase);
            this.blackPanel1.Controls.Add(this.btnBrowse);
            this.blackPanel1.Controls.Add(this.lblSelect);
            this.blackPanel1.Location = new System.Drawing.Point(12, 44);
            this.blackPanel1.Name = "blackPanel1";
            this.blackPanel1.Size = new System.Drawing.Size(204, 146);
            this.blackPanel1.TabIndex = 31;
            // 
            // bgbCheck
            // 
            this.bgbCheck.BorderColor = System.Drawing.Color.Black;
            this.bgbCheck.Controls.Add(this.radioButton2);
            this.bgbCheck.Controls.Add(this.radioButton1);
            this.bgbCheck.ForeColor = System.Drawing.Color.White;
            this.bgbCheck.Location = new System.Drawing.Point(11, 38);
            this.bgbCheck.Name = "bgbCheck";
            this.bgbCheck.Size = new System.Drawing.Size(183, 68);
            this.bgbCheck.TabIndex = 29;
            this.bgbCheck.TabStop = false;
            this.bgbCheck.Text = "Database type:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(28, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 17);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TheDirector Database";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(28, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(132, 17);
            this.radioButton1.TabIndex = 29;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ReLAUNCH Database";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLoadDatabase
            // 
            this.btnLoadDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnLoadDatabase.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLoadDatabase.FlatAppearance.BorderSize = 0;
            this.btnLoadDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnLoadDatabase.Location = new System.Drawing.Point(83, 112);
            this.btnLoadDatabase.Name = "btnLoadDatabase";
            this.btnLoadDatabase.Size = new System.Drawing.Size(111, 23);
            this.btnLoadDatabase.TabIndex = 30;
            this.btnLoadDatabase.Text = "Load Database";
            this.btnLoadDatabase.UseVisualStyleBackColor = false;
            this.btnLoadDatabase.Click += new System.EventHandler(this.btnLoadDatabase_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(255)))));
            this.btnBrowse.Location = new System.Drawing.Point(122, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 23);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.ForeColor = System.Drawing.Color.White;
            this.lblSelect.Location = new System.Drawing.Point(8, 14);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(108, 13);
            this.lblSelect.TabIndex = 26;
            this.lblSelect.Text = "Select a file to import:";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1200, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlBar);
            this.Controls.Add(this.bgbImportRules);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.blackPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlBar.ResumeLayout(false);
            this.pnlBar.PerformLayout();
            this.bgbImportRules.ResumeLayout(false);
            this.bgbImportRules.PerformLayout();
            this.blackPanel1.ResumeLayout(false);
            this.blackPanel1.PerformLayout();
            this.bgbCheck.ResumeLayout(false);
            this.bgbCheck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.Label lblSelect;
        public System.Windows.Forms.Button btnLoadDatabase;
        private BlackPanel blackPanel1;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RunActive;
        private System.Windows.Forms.DataGridViewButtonColumn Executable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExecutablePath;
        private System.Windows.Forms.DataGridViewComboBoxColumn CheckResponding;
        private System.Windows.Forms.DataGridViewComboBoxColumn KillDuplicates;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LoopLaunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoopLaunchCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        public System.Windows.Forms.Label lblMaintain;
        public System.Windows.Forms.Label lblPass;
        public JCS.ToggleSwitch chkAddPassword;
        public System.Windows.Forms.Label lblNotes;
        public JCS.ToggleSwitch chkMergeNotes;
        public JCS.ToggleSwitch chkMaintainOn;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel pnlBar;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblTitle;
        public BlackGroupBox bgbImportRules;
        public BlackGroupBox bgbCheck;
    }
}