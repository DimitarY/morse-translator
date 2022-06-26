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

        public Form_Main()
        {
            InitializeComponent();

            sound = Sound.Instance;
            settings = Settings.Instance;
            API_Worker.Instance.isAvailable();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            settings.startUp();

            //TODO: когато се стартира програмата tabidex застава на първия бутон и той остава селецтиран докато не се кликне някъде или не се ми с мишката
            // при страт да се провери за всички езици
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
            translatorButton.Font = new Font(translatorButton.Font, FontStyle.Regular);
            trainerButton.Font = new Font(trainerButton.Font, FontStyle.Regular);
            settingsButton.Font = new Font(trainerButton.Font, FontStyle.Regular);

            settings.loadSound();

            sound.setWaveOut();

            System.GC.Collect();
        }

        //TODO: не зарежда евента Enter при първи старт
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
            API_Worker.Instance.isAvailable();
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
