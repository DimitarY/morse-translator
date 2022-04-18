using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadUserControls();
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadUserControls()
        {
            Panel clearPanel = new Panel();
            clearPanel.Size = new Size(centerPanel.Width, centerPanel.Height);
            clearPanel.BackColor = Color.FromArgb(41, 44, 51);

            if (!centerPanel.Controls.Contains(clearPanel))
            {
                centerPanel.Controls.Add(clearPanel);
            }

            if (!centerPanel.Controls.Contains(UserControl_Translator.Instance))
            {
                centerPanel.Controls.Add(UserControl_Translator.Instance);
                UserControl_Translator.Instance.Dock = DockStyle.Fill;
            }

            //if (!centerPanel.Controls.Contains(UserControl_Hire.Instance))
            //{
            //    centerPanel.Controls.Add(UserControl_Hire.Instance);
            //    UserControl_Hire.Instance.Dock = DockStyle.Fill;
            //}

            //if (!centerPanel.Controls.Contains(UserControl_ReleaseEmployee.Instance))
            //{
            //    centerPanel.Controls.Add(UserControl_ReleaseEmployee.Instance);
            //    UserControl_ReleaseEmployee.Instance.Dock = DockStyle.Fill;
            //}

            //if (!centerPanel.Controls.Contains(UserControl_UpdateEmployee.Instance))
            //{
            //    centerPanel.Controls.Add(UserControl_UpdateEmployee.Instance);
            //    UserControl_UpdateEmployee.Instance.Dock = DockStyle.Fill;
            //}

            clearPanel.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Font = new Font("Century Gothic", (float)10.8, FontStyle.Underline);
            UserControl_Translator.Instance.BringToFront();
            UserControl_Translator.Instance.Focus();
        }
    }
}
