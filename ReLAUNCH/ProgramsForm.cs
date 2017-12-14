using System.Windows.Forms;
using System.Data.SQLite;
using System;
using System.Runtime.InteropServices;

namespace ReLAUNCH
{

    public partial class ProgramsForm : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ProgramsForm()
        {
            InitializeComponent();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                ofdSelectExec.Filter = "Executable Files (exe,bat,msi)|*.EXE;*.BAT;*.MSI";
                ofdSelectExec.ShowDialog();

                if (ofdSelectExec.FileName.ToString()!="") dgvList.CurrentRow.Cells[3].Value = ofdSelectExec.FileName.ToString();
            }
        }



        void removeProgram(string name)
        {
            using (SQLiteConnection db = new SQLiteConnection(@"Data Source=" + Properties.Settings.Default.Database + ";Version=3;"))
            {
                db.Open();
                string SQL = @"DELETE FROM programs WHERE name = '"+name+"';";
                SQLiteCommand command = new SQLiteCommand(SQL, db);
                command.ExecuteNonQuery();
                db.Close();
                (Application.OpenForms["Form1"] as Form1).populateList();

            }
        }

        private void ProgramsForm_Load(object sender, EventArgs e)
        {
            (Application.OpenForms["Form1"] as Form1).populateList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool failSave = false;
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Cells[0].Value == null) MessageBox.Show("Name cannot be blank... Please ensure you've entired all details correctly");
                if (row.Cells[0].Value == null) failSave = true;
                if (row.Cells[3].Value == null && !failSave) MessageBox.Show("No file selected... Please ensure you've entired all details correctly");
                if (row.Cells[3].Value == null) failSave = true; 
                if (row.Cells[4].Value == null) row.Cells[4].Value = "Default";
                if (row.Cells[5].Value == null) row.Cells[5].Value = "Default";
                if (row.Cells[7].Value == null) row.Cells[7].Value = 0;
                if (row.Cells[8].Value == null) row.Cells[8].Value = "";
                if (row.Cells[9].Value == null) row.Cells[9].Value = "";

                if (row.Cells[0].Value!=null && row.Cells[3].Value!=null) (Application.OpenForms["Form1"] as Form1).manageProgram(row.Cells[0].Value.ToString(), Convert.ToBoolean(row.Cells[1].Value), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), Convert.ToBoolean(row.Cells[6].Value), Convert.ToInt32(row.Cells[7].Value), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString());
            }

            if (!failSave) this.DialogResult = DialogResult.OK;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Add(null,null,"Browse");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.SelectedRows)
            {
                if (row.Cells[0].Value!=null) removeProgram(row.Cells[0].Value.ToString());
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


        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvList.SelectedRows)
            {
                string name = row.Cells[0].Value.ToString();
                while ((Application.OpenForms["Form1"] as Form1).profileExists(name))
                {
                    name += " copy";
                }
                (Application.OpenForms["Form1"] as Form1).manageProgram(name, Convert.ToBoolean(row.Cells[1].Value), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString(), Convert.ToBoolean(row.Cells[6].Value), Convert.ToInt32(row.Cells[7].Value), row.Cells[8].Value.ToString(), row.Cells[9].Value.ToString());
                (Application.OpenForms["Form1"] as Form1).populateList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (Application.OpenForms["Form1"] as Form1).ImportForm.Show();
        }
    }

}