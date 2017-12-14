using System;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReLAUNCH
{
    public partial class ImportForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ImportForm()
        {
            InitializeComponent();
        }

        string fileName = "";

        public void populateList()
        {
            // Create the list from the database.
            using (SQLiteConnection db = new SQLiteConnection(@"Data Source=" + fileName + ";Version=3;"))
            {
                db.Open();

                if (radioButton1.Checked)
                {
                    //ReLAUNCH db
                    string SQL = @"SELECT programs WHERE 1";
                    SQLiteCommand command = new SQLiteCommand(SQL, db);
                    SQLiteDataReader reader = command.ExecuteReader();

                    dgvList.Rows.Clear();
                    int count = 0;
                    while (reader.Read())
                    {
                        dgvList.Rows.Add();
                        dgvList.Rows[count].Cells["Executable"].Value = "Browse";
                        dgvList.Rows[count].Cells["ProgramName"].Value = (reader["name"].ToString() != null) ? reader["name"].ToString() : "";
                        dgvList.Rows[count].Cells["RunActive"].Value = Convert.ToBoolean(reader["active"]);
                        dgvList.Rows[count].Cells["ExecutablePath"].Value = (reader["execpath"].ToString() != null) ? reader["execpath"].ToString() : "";
                        dgvList.Rows[count].Cells["CheckResponding"].Value = (reader["responding"].ToString() != null) ? reader["responding"].ToString() : "Default";
                        dgvList.Rows[count].Cells["KillDuplicates"].Value = (reader["duplicates"].ToString() != null) ? reader["duplicates"].ToString() : "Default";
                        dgvList.Rows[count].Cells["LoopLaunch"].Value = Convert.ToBoolean(reader["loop"]);
                        dgvList.Rows[count].Cells["LoopLaunchCounter"].Value = Convert.ToInt32(reader["loopcount"]);
                        dgvList.Rows[count].Cells["CustomParams"].Value = (reader["params"].ToString() != null) ? reader["params"].ToString() : "";
                        dgvList.Rows[count].Cells["Notes"].Value = (reader["notes"].ToString() != null) ? reader["notes"].ToString() : "";
                        count = count + 1;
                    }

                }
                else
                {
                    //DirectorConfig.db

                    string exec = "";
                    string customparams = "";

                    string SQL1 = @"SELECT * FROM settings where 1;";
                    SQLiteCommand commandSettings = new SQLiteCommand(SQL1, db);
                    SQLiteDataReader readerSettings = commandSettings.ExecuteReader();


                    if (readerSettings.HasRows)
                    {
                        while (readerSettings.Read())
                        {
                            if (readerSettings["SettingName"].ToString() != null && readerSettings["SettingName"].ToString() == "Binary" && readerSettings["Value"].ToString() != null) exec = readerSettings["Value"].ToString();
                            if (readerSettings["SettingName"].ToString() != null && readerSettings["SettingName"].ToString() == "CustomParams" && readerSettings["Value"].ToString() != null) customparams = readerSettings["Value"].ToString();

                        }
                    }

                    string SQL = @"SELECT * FROM profiles where 1;";
                    SQLiteCommand command = new SQLiteCommand(SQL, db);
                    SQLiteDataReader reader = command.ExecuteReader();

                    dgvList.Rows.Clear();
                    int count = 0;
                    while (reader.Read())
                    {
                        if (reader["Name"].ToString() != null && reader["Name"].ToString() != "")
                        {
                            dgvList.Rows.Add();
                            dgvList.Rows[count].Cells["Executable"].Value = "Browse";
                            dgvList.Rows[count].Cells["ProgramName"].Value = (reader["Name"].ToString() != null) ? reader["Name"].ToString() : "";
                            bool maintain = (reader["MaintainOn"].ToString().ToLower() == "yes") ? true : false;
                            dgvList.Rows[count].Cells["RunActive"].Value = (chkMaintainOn.Checked) ? maintain : false;
                            dgvList.Rows[count].Cells["ExecutablePath"].Value = (reader["SpecificExe"].ToString() != null && reader["SpecificExe"].ToString() != "") ? reader["SpecificExe"].ToString() : exec;
                            dgvList.Rows[count].Cells["CheckResponding"].Value = "Default";
                            dgvList.Rows[count].Cells["KillDuplicates"].Value = "Default";
                            dgvList.Rows[count].Cells["LoopLaunch"].Value = false;
                            dgvList.Rows[count].Cells["LoopLaunchCounter"].Value = 0;

                            string Params = customparams;
                            if (chkAddPassword.Checked && reader["Password"].ToString() != null && reader["Password"].ToString() != "") Params += (Params == "") ? "-Password " + reader["Password"].ToString() : " -Password " + reader["Password"].ToString();
                            if (reader["UserName"].ToString() != null && reader["UserName"].ToString() != "") Params += (Params == "") ? "-username " + reader["UserName"].ToString() : " -username " + reader["UserName"].ToString();
                            if (reader["Server"].ToString() != null && reader["Server"].ToString() != "") Params += (Params == "") ? "-Server " + reader["Server"].ToString() : " -Server " + reader["Server"].ToString();
                            if (reader["Title"].ToString() != null && reader["Title"].ToString() != "") Params += (Params == "") ? "-Title " + reader["Title"].ToString() : " -Title " + reader["Title"].ToString();
                            if (reader["Delay"].ToString() != null && reader["Delay"].ToString() != "") Params += (Params == "") ? "-Delay " + reader["Delay"].ToString() : " -Delay " + reader["Delay"].ToString();
                            if (reader["WindowState"].ToString() != null && reader["WindowState"].ToString() != "") Params += (Params == "") ? "-WindowState " + reader["WindowState"].ToString() : " -WindowState " + reader["WindowState"].ToString();
                            if (reader["AutoRunScripts"].ToString() != null && reader["AutoRunScripts"].ToString() != "") Params += (Params == "") ? "-AutoRunScripts " + reader["AutoRunScripts"].ToString() : " -AutoRunScripts " + reader["AutoRunScripts"].ToString();
                            if (reader["ProfileParams"].ToString() != null && reader["ProfileParams"].ToString() != "") Params += (Params == "") ? reader["ProfileParams"].ToString() : " " + reader["ProfileParams"].ToString();
                            if (reader["ProfileProxy"].ToString() != null && reader["ProfileProxy"].ToString() != "") Params += (Params == "") ? "-ProfileProxy " + reader["ProfileProxy"].ToString() : " -ProfileProxy " + reader["ProfileProxy"].ToString();
                            if (reader["PrependGoals"].ToString() != null && reader["PrependGoals"].ToString() != "") Params += (Params == "") ? "-PrependGoals " + reader["PrependGoals"].ToString() : " -PrependGoals " + reader["PrependGoals"].ToString();
                            if (reader["AppendGoals"].ToString() != null && reader["AppendGoals"].ToString() != "") Params += (Params == "") ? "-AppendGoals " + reader["AppendGoals"].ToString() : " -AppendGoals " + reader["AppendGoals"].ToString();
                            if (reader["RunScript"].ToString() != null && reader["RunScript"].ToString() != "") Params += (Params == "") ? "-RunScript " + reader["RunScript"].ToString() : " -RunScript " + reader["RunScript"].ToString();
                            dgvList.Rows[count].Cells["CustomParams"].Value = Params;
                            string Notes = "";
                            if (reader["Notes"].ToString() != null) Notes += "[NOTES 1]: " + reader["Notes"].ToString();
                            if (reader["Notes2"].ToString() != null) Notes += "[NOTES 2]: " + reader["Notes2"].ToString();
                            dgvList.Rows[count].Cells["Notes"].Value = Notes;
                            count = count + 1;
                        }
                    }
                }
                db.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                bgbImportRules.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                bgbImportRules.Visible = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Database Files (*.db)|*.DB";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName; 
            }
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLoadDatabase_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                MessageBox.Show("Please select a database first.");
            } else
            {
                if (File.Exists(fileName))
                {
                    populateList();
                } else
                {
                    MessageBox.Show("I can't find the database: " + fileName);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString();
                while ((Application.OpenForms["Form1"] as Form1).profileExists(name))
                {
                    name += " copy";
                }
                (Application.OpenForms["Form1"] as Form1).manageProgram(name, Convert.ToBoolean(row.Cells[1].Value), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), Convert.ToBoolean(row.Cells[6].Value), Convert.ToInt32(row.Cells[7].Value), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString());
            }
            (Application.OpenForms["Form1"] as Form1).populateList();
            this.Hide();
        }

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
