using JCS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ReLAUNCH
{
    public partial class Settings : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Settings()
        {
            // Mostly ugly theme stuff.
            InitializeComponent();
            ToggleSwitchMetroRenderer cmr1 = new ToggleSwitchMetroRenderer();
            cmr1.LeftSideColor = Color.Green;
            cmr1.RightSideColor = Color.FromArgb(157, 0, 0);
            cmr1.RightSideColorHovered = Color.Red;
            cmr1.RightSideColorPressed = Color.Red;
            cmr1.BorderColor = Color.FromArgb(45, 45, 48);
            cmr1.ButtonColor = Color.FromArgb(70, 70, 70);
            cmr1.ButtonColorHovered = Color.FromArgb(100, 100, 100);
            cmr1.ButtonColorPressed = Color.FromArgb(100, 100, 100);
            chkDuplicates.SetRenderer(cmr1);
            ToggleSwitchMetroRenderer cmr2 = new ToggleSwitchMetroRenderer();
            cmr2.LeftSideColor = Color.Green;
            cmr2.RightSideColor = Color.FromArgb(157, 0, 0);
            cmr2.RightSideColorHovered = Color.Red;
            cmr2.RightSideColorPressed = Color.Red;
            cmr2.BorderColor = Color.FromArgb(45, 45, 48);
            cmr2.ButtonColor = Color.FromArgb(70, 70, 70);
            cmr2.ButtonColorHovered = Color.FromArgb(100, 100, 100);
            cmr2.ButtonColorPressed = Color.FromArgb(100, 100, 100);
            chkResponding.SetRenderer(cmr2);
            ToggleSwitchMetroRenderer cmr3 = new ToggleSwitchMetroRenderer();
            cmr3.LeftSideColor = Color.Green;
            cmr3.RightSideColor = Color.FromArgb(157, 0, 0);
            cmr3.RightSideColorHovered = Color.Red;
            cmr3.RightSideColorPressed = Color.Red;
            cmr3.BorderColor = Color.FromArgb(45, 45, 48);
            cmr3.ButtonColor = Color.FromArgb(70, 70, 70);
            cmr3.ButtonColorHovered = Color.FromArgb(100, 100, 100);
            cmr3.ButtonColorPressed = Color.FromArgb(100, 100, 100);
            chkStartWithWindows.SetRenderer(cmr3);
            ToggleSwitchMetroRenderer cmr4 = new ToggleSwitchMetroRenderer();
            cmr4.LeftSideColor = Color.Green;
            cmr4.RightSideColor = Color.FromArgb(157, 0, 0);
            cmr4.RightSideColorHovered = Color.Red;
            cmr4.RightSideColorPressed = Color.Red;
            cmr4.BorderColor = Color.FromArgb(45, 45, 48);
            cmr4.ButtonColor = Color.FromArgb(70, 70, 70);
            cmr4.ButtonColorHovered = Color.FromArgb(100, 100, 100);
            cmr4.ButtonColorPressed = Color.FromArgb(100, 100, 100);
            chkAutoActivate.SetRenderer(cmr4);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Load the settings from the configuration and set the matching elements.
            txtGlobalCommandLine.Text = Properties.Settings.Default.CommandLine;
            chkDarkTheme.Checked = Properties.Settings.Default.darkTheme;
            chkStartWithWindows.Checked = AutoStarter.IsAutoStartEnabled;
            pnlBar.Width = this.Width;
            chkResponding.Checked = Properties.Settings.Default.CheckResponding;
            chkDuplicates.Checked = Properties.Settings.Default.KillDuplicates;
            nudDelay.Value = Properties.Settings.Default.Delay;
            chkAutoActivate.Checked = Properties.Settings.Default.AutoActivate;
            btnCustomColour.BackColor = Properties.Settings.Default.color;
            colorDialog1.Color = Properties.Settings.Default.color;
        }

        private void MetroStyleToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && Application.OpenForms["Form1"] != null)
            {
                (Application.OpenForms["Form1"] as Form1).setColours(colorDialog1.Color);
                btnCustomColour.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setColours(Color.Aqua);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setColours(Color.IndianRed);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setColours(Color.Yellow);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setColours(Color.FromArgb(0, 149, 255));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setColours(Color.Magenta);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void pnlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void chkStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoStarter.IsAutoStartEnabled != chkStartWithWindows.Checked)
            {
                if (AutoStarter.IsAutoStartEnabled)
                {
                    AutoStarter.UnSetAutoStart();
                } else
                {
                    AutoStarter.SetAutoStart();
                }
            }
        }

        private void chkDuplicates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null) (Application.OpenForms["Form1"] as Form1).setTheme(chkDarkTheme.Checked);

        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}