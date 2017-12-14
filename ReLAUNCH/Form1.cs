using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using JCS;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using System.Deployment.Application;
using System.IO;
using System.Threading;

namespace ReLAUNCH
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Settings SettingsForm = new Settings();
        ProgramsForm ProgramsForm = new ProgramsForm();
        public ImportForm ImportForm = new ImportForm();

        public Form1()
        {
            InitializeComponent();
            ToggleSwitchMetroRenderer cmr3 = new ToggleSwitchMetroRenderer();
            cmr3.LeftSideColor = Color.Green;
            cmr3.RightSideColor = Color.FromArgb(157, 0, 0);
            cmr3.RightSideColorHovered = Color.Red;
            cmr3.RightSideColorPressed = Color.Red;
            cmr3.BorderColor = Color.FromArgb(45, 45, 48);
            cmr3.ButtonColor = Color.FromArgb(70, 70, 70);
            cmr3.ButtonColorHovered = Color.FromArgb(100, 100, 100);
            cmr3.ButtonColorPressed = Color.FromArgb(100, 100, 100);
            chkActive.SetRenderer(cmr3);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;

        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]

        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]

        public static extern bool ReleaseCapture();
        int changeLogCommitCounter = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo();
            string ver = (ApplicationDeployment.IsNetworkDeployed) ? ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() : "Undeployed";
            lblVersion.Text = "Version: " + ver;
            setColours();
            setTheme(Properties.Settings.Default.darkTheme);
            pnlBar.Width = this.Width - 5;
            output("ReLAUNCH started.");
            populateList();
            chkActive.Checked = Properties.Settings.Default.AutoActivate;
            if (chkActive.Checked) start();
            changeLogFill();

        }


        void changeLogFill()
        {
            // Ugly method of making a local changelog.
            changelog("1.0.2.1", true);
            changelog("Added Changelog");
            changelog("Added new Global setting \"Command Line\" to be used on all programs.");
            changelog("1.0.2.2", true);
            changelog("Styled the change log");
            changelog("Fixed tab ordering");
            changelog("1.0.2.3", true);
            changelog("Fixed database saving issue (this should solve start up issues, too)");
            changelog("Added new sleep time option for delay between launches in general settings.");
            changelog("1.0.2.4", true);
            changelog("Fixed another tab related issue.");
            changelog("Simplified changelog code to remove bulk");
            changelog("Removed System.Collections.Generic as Dictionaries are no longer used");
            changelog("Improved number formatting");

        }

        public bool profileExists(String name)
        {
            // Check if a profile with the name given arlready exists.
            bool result = false;
            foreach (DataGridViewRow row in ProgramsForm.dgvList.Rows)
            {
                if (row.Cells[0].Value.ToString() == name) result = true;
            }
            return result;
        }

        private void output(string text, string header = "info", Color? headerColour = null, Color? textColour = null)
        {
            // Custom output method, accepts the message, a [HEAD], a colour for the header, and a colour for the message.
            header = header.ToUpper();
            RichTextBox outputTo = (header == "DEBUG") ? debug : log;
            if (headerColour == null) headerColour = (Properties.Settings.Default.darkTheme) ? Color.FromArgb(0, 210, 255) : Color.FromArgb(0, 33, 157);
            if (textColour == null) textColour = (Properties.Settings.Default.darkTheme) ? Color.White : Color.Black;
            outputTo.AppendText("[" + DateTime.Now.ToString("hh:mm:ss tt") + "] ", Color.FromArgb(0, 255, 30));
            Color? newCol = (header == "INFO") ? (Properties.Settings.Default.darkTheme ? Color.FromArgb(255, 114, 0) : Color.FromArgb(158, 21, 187)) : (header == "ERROR") ? (Properties.Settings.Default.darkTheme ? Color.FromArgb(240, 85, 92) : Color.FromArgb(184, 22, 22)) : headerColour;
            outputTo.AppendText((header == "INFO" ? "INFO: " : header == "ERROR" ? "ERROR: " : header + ": "), newCol);
            outputTo.AppendText(text, textColour);
            outputTo.AppendText(Environment.NewLine);

        }

        private void changelog(string text = "", bool Version = false)
        {
            // Produce the changelog.
            if (Version)
            {
                rtbChangeLog.AppendText("[ Version Number " + text + " ]", Color.FromArgb(0, 255, 30));
                rtbChangeLog.AppendText(Environment.NewLine);
            }
            else
            {
                rtbChangeLog.AppendText("(commit: " + changeLogCommitCounter.ToString("N0") + ") ", Color.Aqua);
                rtbChangeLog.AppendText("\t" + text);
                rtbChangeLog.AppendText(Environment.NewLine);
                changeLogCommitCounter++;
            }

        }

        public void setTheme(bool dark = true)
        {
            // Messy theme engine: powered by autism.
            Color form = (dark) ? Color.FromArgb(45, 45, 48) : Color.FromArgb(206, 206, 206);
            Color content = (dark) ? Color.FromArgb(30, 30, 30) : Color.FromArgb(178, 178, 178);
            Color font = (dark) ? Color.White : Color.Black;
            Color backdvg = (dark) ? Color.FromArgb(40, 40, 40) : Color.FromArgb(190, 190, 190);
            Color backdgvselected = (dark) ? Color.FromArgb(50, 50, 50) : Color.FromArgb(180, 180, 180);
            Color backdvgalt = (dark) ? Color.FromArgb(45, 45, 45) : Color.FromArgb(195, 195, 195);
            Color backdgvselectedalt = (dark) ? Color.FromArgb(55, 55, 55) : Color.FromArgb(185, 185, 185);
            Color headerdgv = (dark) ? Color.FromArgb(60, 60, 60) : Color.FromArgb(170, 170, 170);
            Color headerdgvselected = (dark) ? Color.FromArgb(70, 70, 70) : Color.FromArgb(160, 160, 160);

            this.BackColor = form;
            log.BackColor = content;
            debug.BackColor = content;
            btnCheckNow.BackColor = content;
            btnClear.BackColor = content;
            btnClear2.BackColor = content;
            btnSelectPrograms.BackColor = content;
            lblActive.ForeColor = font;
            lblVersion.ForeColor = font;
            bgbControls.ForeColor = font;
            btnSettings.BackColor = content;
            tabLogs.BackColor = form;
            tabLogs.ForeColor = font;
            rtbChangeLog.BackColor = content;

            SettingsForm.BackColor = form;
            SettingsForm.btnBrowse.BackColor = content;
            SettingsForm.btnCancel.BackColor = content;
            SettingsForm.btnSave.BackColor = content;
            SettingsForm.nudDelay.BackColor = content;
            SettingsForm.nudDelayBetween.BackColor = content;
            SettingsForm.bgbApplicationSettings.ForeColor = font;
            SettingsForm.bgbGlobalDefaults.ForeColor = font;
            SettingsForm.bgbUI.ForeColor = font;
            SettingsForm.lblAutoActivate.ForeColor = font;
            SettingsForm.lblCheckResponding.ForeColor = font;
            SettingsForm.lblCloseDuplicates.ForeColor = font;
            SettingsForm.lblDarkTheme.ForeColor = font;
            SettingsForm.lblDBDir.ForeColor = font;
            SettingsForm.lblDelay.ForeColor = font;
            SettingsForm.lblDelayBetween.ForeColor = font;
            SettingsForm.lblStartWithWindows.ForeColor = font;
            SettingsForm.txtGlobalCommandLine.BackColor = content;
            SettingsForm.lblGlobalCommandLine.ForeColor = font;

            ProgramsForm.BackColor = form;
            ProgramsForm.btnAdd.BackColor = content;
            ProgramsForm.btnCancel.BackColor = content;
            ProgramsForm.btnDuplicate.BackColor = content;
            ProgramsForm.btnRemove.BackColor = content;
            ProgramsForm.btnSave.BackColor = content;
            ProgramsForm.btnImport.BackColor = content;
            ProgramsForm.dgvList.BackgroundColor = content;
            ProgramsForm.dgvList.AlternatingRowsDefaultCellStyle.BackColor = backdvgalt;
            ProgramsForm.dgvList.AlternatingRowsDefaultCellStyle.SelectionBackColor = backdgvselectedalt;
            ProgramsForm.dgvList.DefaultCellStyle.BackColor = backdvg;
            ProgramsForm.dgvList.DefaultCellStyle.SelectionBackColor = backdgvselected;
            ProgramsForm.dgvList.ColumnHeadersDefaultCellStyle.BackColor = headerdgv;
            ProgramsForm.dgvList.ColumnHeadersDefaultCellStyle.SelectionBackColor = headerdgvselected;
            ProgramsForm.dgvList.RowsDefaultCellStyle.BackColor = backdvg;
            ProgramsForm.dgvList.RowsDefaultCellStyle.SelectionBackColor = backdgvselected;

            ImportForm.BackColor = form;
            ImportForm.dgvList.BackgroundColor = content;
            ImportForm.dgvList.AlternatingRowsDefaultCellStyle.BackColor = backdvgalt;
            ImportForm.dgvList.AlternatingRowsDefaultCellStyle.SelectionBackColor = backdgvselectedalt;
            ImportForm.dgvList.DefaultCellStyle.BackColor = backdvg;
            ImportForm.dgvList.DefaultCellStyle.SelectionBackColor = backdgvselected;
            ImportForm.dgvList.ColumnHeadersDefaultCellStyle.BackColor = headerdgv;
            ImportForm.dgvList.ColumnHeadersDefaultCellStyle.SelectionBackColor = headerdgvselected;
            ImportForm.dgvList.RowsDefaultCellStyle.BackColor = backdvg;
            ImportForm.dgvList.RowsDefaultCellStyle.SelectionBackColor = backdgvselected;
            ImportForm.btnBrowse.BackColor = content;
            ImportForm.btnCancel.BackColor = content;
            ImportForm.btnLoadDatabase.BackColor = content;
            ImportForm.btnImport.BackColor = content;
            ImportForm.lblSelect.ForeColor = font;
            ImportForm.lblNotes.ForeColor = font;
            ImportForm.lblPass.ForeColor = font;
            ImportForm.bgbImportRules.ForeColor = font;
            ImportForm.bgbCheck.ForeColor = font;
            ImportForm.radioButton1.ForeColor = font;
            ImportForm.radioButton2.ForeColor = font;

            Properties.Settings.Default.darkTheme = dark;
            output("Updated theme globally", "debug");
        }

        public void manageProgram(string name, bool active, string execpath, string responding, string duplicates, bool loop, int loopcount, string Params, string notes)
        {
            // Initial program (profile) management.
            handleDatabase();
            using (SQLiteConnection db = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.Database + ";Version=3;"))
            {
                db.Open();
                int activeInt = active ? 1 : 0;
                int loopInt = loop ? 1 : 0;
                string SQL = @"REPLACE INTO programs (name, active, execpath, responding, duplicates, loop, loopcount, params, notes) VALUES ('" + name + "'," + activeInt + ",'" + execpath + "','" + responding + "','" + duplicates + "'," + loopInt + "," + loopcount + ",'" + Params + "','" + notes + "');";
                output("Executing SQL: " + SQL, "debug");
                SQLiteCommand command = new SQLiteCommand(SQL, db);
                command.ExecuteNonQuery();
                db.Close();

            }
        }

        public void setColours(Color? inputColour = null)
        {
            // Seporate colouring - differs from Theming. 
            Color outputColour = (inputColour == null) ? Properties.Settings.Default.color : inputColour.Value;
            btnCheckNow.ForeColor = outputColour;
            btnClear.ForeColor = outputColour;
            btnClear2.ForeColor = outputColour;
            btnClose.ForeColor = outputColour;
            lblReLAUNCH.ForeColor = outputColour;
            btnMinimise.ForeColor = outputColour;
            btnSelectPrograms.ForeColor = outputColour;
            btnSettings.ForeColor = outputColour;
            rtbChangeLog.ForeColor = outputColour;

            SettingsForm.lblSettings.ForeColor = outputColour;
            SettingsForm.btnBrowse.ForeColor = outputColour;
            SettingsForm.btnCancel.ForeColor = outputColour;
            SettingsForm.btnSave.ForeColor = outputColour;
            SettingsForm.nudDelay.ForeColor = outputColour;
            SettingsForm.nudDelayBetween.ForeColor = outputColour;
            SettingsForm.txtGlobalCommandLine.ForeColor = outputColour;

            ProgramsForm.btnAdd.ForeColor = outputColour;
            ProgramsForm.btnRemove.ForeColor = outputColour;
            ProgramsForm.btnSave.ForeColor = outputColour;
            ProgramsForm.btnCancel.ForeColor = outputColour;
            ProgramsForm.btnDuplicate.ForeColor = outputColour;
            ProgramsForm.btnImport.ForeColor = outputColour;
            ProgramsForm.dgvList.ColumnHeadersDefaultCellStyle.ForeColor = outputColour;
            ProgramsForm.dgvList.ColumnHeadersDefaultCellStyle.SelectionForeColor = outputColour;
            ProgramsForm.dgvList.AlternatingRowsDefaultCellStyle.ForeColor = outputColour;
            ProgramsForm.dgvList.AlternatingRowsDefaultCellStyle.SelectionForeColor = outputColour;
            ProgramsForm.dgvList.DefaultCellStyle.ForeColor = outputColour;
            ProgramsForm.dgvList.DefaultCellStyle.SelectionForeColor = outputColour;
            ProgramsForm.dgvList.RowHeadersDefaultCellStyle.ForeColor = outputColour;
            ProgramsForm.dgvList.RowHeadersDefaultCellStyle.SelectionForeColor = outputColour;
            ProgramsForm.dgvList.RowsDefaultCellStyle.ForeColor = outputColour;
            ProgramsForm.dgvList.RowsDefaultCellStyle.SelectionForeColor = outputColour;
            ProgramsForm.lblTitle.ForeColor = outputColour;

            ImportForm.dgvList.ColumnHeadersDefaultCellStyle.ForeColor = outputColour;
            ImportForm.dgvList.ColumnHeadersDefaultCellStyle.SelectionForeColor = outputColour;
            ImportForm.dgvList.AlternatingRowsDefaultCellStyle.ForeColor = outputColour;
            ImportForm.dgvList.AlternatingRowsDefaultCellStyle.SelectionForeColor = outputColour;
            ImportForm.dgvList.DefaultCellStyle.ForeColor = outputColour;
            ImportForm.dgvList.DefaultCellStyle.SelectionForeColor = outputColour;
            ImportForm.dgvList.RowHeadersDefaultCellStyle.ForeColor = outputColour;
            ImportForm.dgvList.RowHeadersDefaultCellStyle.SelectionForeColor = outputColour;
            ImportForm.dgvList.RowsDefaultCellStyle.ForeColor = outputColour;
            ImportForm.dgvList.RowsDefaultCellStyle.SelectionForeColor = outputColour;
            ImportForm.btnBrowse.ForeColor = outputColour;
            ImportForm.btnCancel.ForeColor = outputColour;
            ImportForm.btnImport.ForeColor = outputColour;
            ImportForm.btnLoadDatabase.ForeColor = outputColour;
            ImportForm.lblTitle.ForeColor = outputColour;

            Properties.Settings.Default.color = outputColour;
            output("Updated colours globally", "debug");
        }

        private void handleDatabase()
        {
            // Initial database creation/check.
            if (!File.Exists(Properties.Settings.Default.Database))
            {
                File.Create(Properties.Settings.Default.Database);
                output("Created database", "debug");
            }

            if (File.Exists(Properties.Settings.Default.Database))
            {
                try
                {
                    using (SQLiteConnection db = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.Database + ";Version=3;"))
                    {
                        db.Open();
                        string SQL = "CREATE TABLE IF NOT EXISTS settings (ID int PRIMARY KEY, NAME string NOT NULL, VALUE string NOT NULL);";
                        output("Executing SQL: " + SQL, "DEBUG");
                        SQLiteCommand command = new SQLiteCommand(SQL, db);
                        command.ExecuteNonQuery();
                        SQL = "CREATE TABLE IF NOT EXISTS programs (name string PRIMARY KEY, active bool, execpath string NOT NULL, responding string NOT NULL, duplicates string NOT NULL, loop bool, loopcount int, params string NOT NULL, notes string NOT NULL);";
                        output("Executing SQL: " + SQL, "DEBUG");
                        command = new SQLiteCommand(SQL, db);
                        command.ExecuteNonQuery();
                        db.Close();

                    }
                }
                catch (Exception)
                {

                }
            }
            else
            {
                MessageBox.Show("Please create a database file in the Settings menu");
            }
        }

        private string GetCommandLine(Process process)
        {
            // Returns the command line paramaters (arguments) of a given process.
            string returnvalue = "";

            using (var searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id))
            {
                foreach (var @object in searcher.Get())
                {
                    returnvalue = @object["CommandLine"].ToString();
                }
            }
            returnvalue = returnvalue.Replace(process.MainModule.FileName, "").Replace(getNameFromPath(process.MainModule.FileName, true), "").Replace("\"", "").Trim();
            output("Command Line: " + returnvalue, "debug");
            return returnvalue;
        }

        private void updateSettings()
        {
            // Update the config file for the application with the current configuration.
            Properties.Settings.Default.CommandLine = SettingsForm.txtGlobalCommandLine.Text;
            Properties.Settings.Default.KillDuplicates = SettingsForm.chkDuplicates.Checked;
            Properties.Settings.Default.CheckResponding = SettingsForm.chkResponding.Checked;
            Properties.Settings.Default.AutoActivate = SettingsForm.chkAutoActivate.Checked;
            Properties.Settings.Default.Delay = Convert.ToInt32(SettingsForm.nudDelay.Value);
            Properties.Settings.Default.DelayBetween = SettingsForm.nudDelayBetween.Value;
            Properties.Settings.Default.Database = SettingsForm.openFileDialog1.FileName;
            if (SettingsForm.openFileDialog1.FileName.ToString() != "") Properties.Settings.Default.Database = SettingsForm.openFileDialog1.FileName.ToString();
            Properties.Settings.Default.Save();
            populateList();
            output("Settings updated:\n\t\t\tKill Duplicates = " + Properties.Settings.Default.KillDuplicates + "\n\t\t\tCheck Responding = " + Properties.Settings.Default.CheckResponding + "\n\t\t\tDatabase = " + Properties.Settings.Default.Database + "\n\t\t\tDelay = " + Properties.Settings.Default.Delay + "\n\t\t\tColo[u]r = " + Properties.Settings.Default.color.Name, "debug");
        }

        private void launchProgram(string filepath, string fileparams)
        {
            // Luanch a program with the given parameters/arguments
            fileparams = (fileparams != "") ? fileparams + " " + Properties.Settings.Default.CommandLine : Properties.Settings.Default.CommandLine;
            Process.Start(filepath, fileparams);
            output("Process " + getNameFromPath(filepath) + " is now running", "debug");
        }

        private string getNameFromPath(String path, bool addExtension = false)
        {
            // Rturns the name of the program as given in the programs path (extension is optional).
            Regex rgx = new Regex(@"[^\\]*.exe$", RegexOptions.IgnoreCase);
            string match = rgx.Match(path).ToString();
            return (addExtension) ? match : match.Remove(match.Length - 4);
        }

        private int HasProcess(String processPath, String processParams = "")
        {
            // Check if a process exists that matches the given path and parameters/argumnts.
            Process[] process = Process.GetProcesses();
            string processName = getNameFromPath(processPath);
            int counter = 0;
            foreach (Process prs in process)
            {
                if (prs.ProcessName == processName && prs.MainModule.FileName == processPath && (GetCommandLine(prs) == processParams))
                {
                    counter++;
                }
            }
            return counter;
        }

        private int HasProcessReturnID(String processPath, String processParams = "")
        {
            // Check if a process exists that matches the given path and parameters/argumnts and return its ID if it does.
            Process[] process = Process.GetProcesses();
            string processName = getNameFromPath(processPath);

            foreach (Process prs in process)
            {
                if (prs.ProcessName == processName && prs.MainModule.FileName == processPath && (GetCommandLine(prs) == processParams))
                {
                    return prs.Id;
                }
            }
            return -1;
        }

        private void killBadProcesses(String processPath, String processParams = "")
        {
            // Simple process kill.
            Process[] process = Process.GetProcesses();
            string processName = getNameFromPath(processPath);
            foreach (Process prs in process)
            {
                if (prs.ProcessName == processName && prs.MainModule.FileName == processPath && (GetCommandLine(prs) == processParams) && !prs.Responding)
                {
                    prs.Kill();
                    output("Bad process: " + prs.Id.ToString() + " killed.");
                }
            }
        }

        private void start()
        {
            // Start the timer and enable monitoring.
            timer.Interval = Properties.Settings.Default.Delay * 1000;
            output("Started. Next check in " + Properties.Settings.Default.Delay + " seconds", "info");
            tick();
            timer.Enabled = true;

        }

        private void stop()
        {
            // Stop the timer and disable monitoring.
            timer.Enabled = false;
            output("Stopped", "info");
        }

        private void tick()
        {
            // Process to do every timer "tick", this is where the monitoring takes place.
            foreach (DataGridViewRow row in ProgramsForm.dgvList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[1].Value))
                {
                    int processes = HasProcess(row.Cells[3].Value.ToString(), row.Cells[8].Value.ToString());
                    int maxProcesses = Convert.ToBoolean(row.Cells[6].Value) ? Convert.ToInt32(row.Cells[7].Value) : 1;

                    if (processes > maxProcesses && (row.Cells[5].Value.ToString() == "Default" && Properties.Settings.Default.KillDuplicates || row.Cells[5].Value.ToString() == "Yes"))
                    {
                        while (processes > maxProcesses)
                        {
                            int ID = HasProcessReturnID(row.Cells[3].Value.ToString(), row.Cells[8].Value.ToString());
                            output("Killing duplicate process: " + ID.ToString(), "debug");
                            Process.GetProcessById(ID).Kill();
                            processes--;
                        }
                    }

                    if ((row.Cells[4].Value.ToString() == "Default" && Properties.Settings.Default.CheckResponding) || row.Cells[4].Value.ToString() == "Yes")
                    {
                        killBadProcesses(row.Cells[3].Value.ToString(), row.Cells[8].Value.ToString());
                    }

                    if (processes < maxProcesses)
                    {
                        while (processes < maxProcesses)
                        {
                            launchProgram(row.Cells[3].Value.ToString(), row.Cells[8].Value.ToString());
                            TimeSpan ts = TimeSpan.FromSeconds(Convert.ToDouble(Properties.Settings.Default.DelayBetween));
                            Thread.Sleep(ts);
                            processes++;
                        }
                    }
                }

            }
        }

        public void populateList()
        {
            // Create the list from te database.
            handleDatabase();
            try
            {
                using (SQLiteConnection db = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.Database + ";Version=3;"))
                {
                    db.Open();
                    string SQL = @"SELECT * FROM programs where 1;";
                    SQLiteCommand command = new SQLiteCommand(SQL, db);
                    SQLiteDataReader reader = command.ExecuteReader();

                    ProgramsForm.dgvList.Rows.Clear();
                    int count = 0;
                    while (reader.Read())
                    {
                        //if (count == 0)
                        ProgramsForm.dgvList.Rows.Add();
                        ProgramsForm.dgvList.Rows[count].Cells["Executable"].Value = "Browse";
                        ProgramsForm.dgvList.Rows[count].Cells["ProgramName"].Value = (reader["name"].ToString() != null) ? reader["name"].ToString() : "";
                        ProgramsForm.dgvList.Rows[count].Cells["RunActive"].Value = Convert.ToBoolean(reader["active"]);
                        ProgramsForm.dgvList.Rows[count].Cells["ExecutablePath"].Value = (reader["execpath"].ToString() != null) ? reader["execpath"].ToString() : "";
                        ProgramsForm.dgvList.Rows[count].Cells["CheckResponding"].Value = (reader["responding"].ToString() != null) ? reader["responding"].ToString() : "Default";
                        ProgramsForm.dgvList.Rows[count].Cells["KillDuplicates"].Value = (reader["duplicates"].ToString() != null) ? reader["duplicates"].ToString() : "Default";
                        ProgramsForm.dgvList.Rows[count].Cells["LoopLaunch"].Value = Convert.ToBoolean(reader["loop"]);
                        ProgramsForm.dgvList.Rows[count].Cells["LoopLaunchCounter"].Value = Convert.ToInt32(reader["loopcount"]);
                        ProgramsForm.dgvList.Rows[count].Cells["CustomParams"].Value = (reader["params"].ToString() != null) ? reader["params"].ToString() : "";
                        ProgramsForm.dgvList.Rows[count].Cells["Notes"].Value = (reader["notes"].ToString() != null) ? reader["notes"].ToString() : "";
                        count = count + 1;
                    }
                    db.Close();
                }
            }
            catch (Exception)
            {

            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked) start(); else stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tick();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (ProgramsForm.ShowDialog() == DialogResult.OK)
            {
                output("Programs list updated. " + ProgramsForm.dgvList.RowCount.ToString() + " programs declared.", "debug");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            tick();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            debug.Clear();
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {
            InstallUpdateSyncWithInfo(false);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (SettingsForm.ShowDialog() == DialogResult.OK)
            {
                updateSettings();
            }
        }

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            pnlBar.BackColor = Color.FromArgb(70, 70, 70);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            pnlBar.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void InstallUpdateSyncWithInfo(bool debug = true)
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;

                try
                {
                    info = ad.CheckForDetailedUpdate();

                }
                catch (DeploymentDownloadException dde)
                {
                    output("Update couldn't be completed at this time. err: " + dde.Message, "error");
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    output("Cannot check for a new version of the application. The deployment is corrupt. err: " + ide.Message, (debug) ? "debug" : "info");
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    output("This application cannot be updated. It is likely not a ClickOnce application. err: " + ioe.Message, (debug) ? "debug" : "info");
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        output("An update is available. We're going to try install it now...");
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        output("This application has detected a mandatory update from your current " +
                            "version to version " + info.MinimumRequiredVersion.ToString() +
                            ". The application will now install the update and restart.",
                            "Update Available");
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            output("The application has been upgraded and will now restart.");
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            output("Cannot install the latest version of the application. \n\nPlease check your network connection, or try again later. err: " + dde, "error");
                            return;
                        }
                    }
                }
                else
                {
                    output("No update available at this time", (debug) ? "debug" : "info");
                }
            }
            else
            {
                output("Not Deployed! Alert support.", "error");
            }
        }

    } // End of Form1 class...

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color? color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color.Value;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
            box.ScrollToCaret();
        }
    }

} // End of namespace.

public class BlackPanel : Panel
{
    private Color _borderColor = Color.Black;

    public Color BorderColor
    {
        get { return this._borderColor; }
        set { this._borderColor = value; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //get the text size in panel
        Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

        Rectangle borderRect = e.ClipRectangle;
        borderRect.Y = (borderRect.Y + (tSize.Height / 2));
        borderRect.Height = (borderRect.Height - (tSize.Height / 2));
        ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);

        Rectangle textRect = e.ClipRectangle;
        textRect.X = (textRect.X + 6);
        textRect.Width = tSize.Width;
        textRect.Height = tSize.Height;
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
    }
}

/* Old checkbox class
public class MyCheckBox : CheckBox
{
    public MyCheckBox()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        Padding = new Padding(2);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        this.OnPaintBackground(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using (var path = new GraphicsPath())
        {
            SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(70, Color.FromArgb(255, 16, 16, 16)));
            var d = Padding.All;
            var r = this.Height - 3 * d;
            path.AddArc(d, d, r, r, 90, 180);
            path.AddArc(this.Width - r - d, d, r, r, -90, 180);
            path.CloseFigure();
            e.Graphics.FillPath(Checked ? new SolidBrush(ColorTranslator.FromHtml("#627A6B")) : new SolidBrush(ColorTranslator.FromHtml("#9E9E9E")), path);
            r = Height - 4;
            var rectshaddow = Checked ? new Rectangle(Width - r, 1, r, r)
                               : new Rectangle(1, 1, r+1, r+1);

            var rect = Checked ? new Rectangle(Width - r - 1, 0, r, r)
                               : new Rectangle(0, 0, r, r);
            e.Graphics.FillEllipse(Checked ? shadowBrush : shadowBrush, rectshaddow);
            e.Graphics.FillEllipse(Checked ? new SolidBrush(ColorTranslator.FromHtml("#1BB015")) : Brushes.Red, rect);
            
        }
    }

}
*/
public class DarkNumericUpDown : NumericUpDown
{
    public DarkNumericUpDown()
    {
        foreach (Control control in Controls)
        {
            control.BackColor = Color.FromArgb(30, 30, 30);
            control.ForeColor = Color.FromArgb(0, 149, 255);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.Clear(SystemColors.Window);
        base.OnPaint(e);
    }
}
public class AutoStarter
{
    private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
    private const string VALUE_NAME = "ReLAUNCH";

    /// <summary>
    /// Set the autostart value for the assembly.
    /// </summary>
    public static void SetAutoStart()
    {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
        key.SetValue(VALUE_NAME, Assembly.GetExecutingAssembly().Location);
    }

    /// <summary>
    /// Returns whether auto start is enabled.
    /// </summary>
    public static bool IsAutoStartEnabled
    {
        get
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
            if (key == null)
                return false;

            string value = (string)key.GetValue(VALUE_NAME);
            if (value == null)
                return false;
            return (value == Assembly.GetExecutingAssembly().Location);
        }
    }

    /// <summary>
    /// Unsets the autostart value for the assembly.
    /// </summary>
    public static void UnSetAutoStart()
    {
        if (IsAutoStartEnabled == true)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.DeleteValue(VALUE_NAME);
        }
        else
        {

        }
    }
}
public class BlackGroupBox : GroupBox
{
    private Color _borderColor = Color.Black;

    public Color BorderColor
    {
        get { return this._borderColor; }
        set { this._borderColor = value; }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        //get the text size in groupbox
        Size tSize = TextRenderer.MeasureText(this.Text, this.Font);

        Rectangle borderRect = e.ClipRectangle;
        borderRect.Y = (borderRect.Y + (tSize.Height / 2));
        borderRect.Height = (borderRect.Height - (tSize.Height / 2));
        ControlPaint.DrawBorder(e.Graphics, borderRect, this._borderColor, ButtonBorderStyle.Solid);

        Rectangle textRect = e.ClipRectangle;
        textRect.X = (textRect.X + 6);
        textRect.Width = tSize.Width;
        textRect.Height = tSize.Height;
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
    }
}

