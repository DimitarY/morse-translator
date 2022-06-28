using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class Form_Main : Form
    {
        // On Mouse Down on topPanel move window
        const int HT_CAPTION = 0x2;
        const int WM_NCLBUTTONDOWN = 0xA1;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        // END

        // Get default context menu
        private const int WS_SYSMENU = 0x80000;
        private const int WS_MINIMIZEBOX = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams p = base.CreateParams;
                p.Style = WS_SYSMENU | WS_MINIMIZEBOX;
                return p;
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_POPUPSYSTEMMENU = 0x313;
        // END

        private Sound sound;
        private Settings settings;
        private API_Worker worker;

        public Form_Main()
        {
            InitializeComponent();

            sound = Sound.Instance;
            settings = Settings.Instance;
            worker = API_Worker.Instance;
            worker.isAvailable();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            settings.startUp();
            topPanel.Select();
        }

        private void Form_Main_Shown(object sender, EventArgs e)
        {
            if (!centerPanel.Controls.Contains(UserControl_HomePage.Instance))
            {
                centerPanel.Controls.Add(UserControl_HomePage.Instance);
                UserControl_HomePage.Instance.Dock = DockStyle.Fill;
            }

            UserControl_HomePage.Instance.BringToFront();
            UserControl_HomePage.Instance.Focus();
            homePageButton.Font = new Font(homePageButton.Font, FontStyle.Underline);

            // Must be at end
            if (worker.Available)
            {
                if (this.ProductVersion != worker.getNewestVersion())
                {
                    if (MessageBox.Show("There is a new version of the program.\nDo you want to download it?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(worker.DownloadLink);
                    }
                }
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else if (e.Button == MouseButtons.Right)
            {
                var p = MousePosition.X + (MousePosition.Y * 0x10000);
                SendMessage(this.Handle, WM_POPUPSYSTEMMENU, (IntPtr)0, (IntPtr)p);
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }

        private void closeButton_Click(object sender, EventArgs e) { this.Close(); }

        private void menuChange()
        {
            homePageButton.Font = new Font(translatorButton.Font, FontStyle.Regular);
            translatorButton.Font = new Font(translatorButton.Font, FontStyle.Regular);
            trainerButton.Font = new Font(trainerButton.Font, FontStyle.Regular);
            settingsButton.Font = new Font(trainerButton.Font, FontStyle.Regular);

            settings.loadSound();

            sound.setWaveOut();

            System.GC.Collect();
        }

        private void homePageButton_Click(object sender, EventArgs e)
        {
            if (!centerPanel.Controls.Contains(UserControl_HomePage.Instance))
            {
                centerPanel.Controls.Add(UserControl_HomePage.Instance);
                UserControl_HomePage.Instance.Dock = DockStyle.Fill;
            }

            UserControl_HomePage.Instance.BringToFront();
            UserControl_HomePage.Instance.Focus();
            menuChange();
            (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Underline);
        }

        private void translaorButton_Click(object sender, EventArgs e)
        {
            if (!centerPanel.Controls.Contains(UserControl_Translator.Instance))
            {
                centerPanel.Controls.Add(UserControl_Translator.Instance);
                UserControl_Translator.Instance.Dock = DockStyle.Fill;
            }

            UserControl_Translator.Instance.BringToFront();
            UserControl_Translator.Instance.Focus();
            menuChange();
            (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Underline);
        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            if (!centerPanel.Controls.Contains(UserControl_Trainer.Instance))
            {
                centerPanel.Controls.Add(UserControl_Trainer.Instance);
                UserControl_Trainer.Instance.Dock = DockStyle.Fill;
            }

            UserControl_Trainer.Instance.BringToFront();
            UserControl_Trainer.Instance.Focus();
            menuChange();
            (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Underline);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (!centerPanel.Controls.Contains(UserControl_Settings.Instance))
            {
                centerPanel.Controls.Add(UserControl_Settings.Instance);
                UserControl_Settings.Instance.Dock = DockStyle.Fill;
            }

            this.Cursor = Cursors.WaitCursor;
            worker.isAvailable();
            this.Cursor = Cursors.Default;
            UserControl_Settings.Instance.BringToFront();
            UserControl_Settings.Instance.Focus();
            menuChange();
            (sender as Button).Font = new Font((sender as Button).Font, FontStyle.Underline);
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(62, 120, 138);
        }

        private void Button_Leave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
        }
    }
}
