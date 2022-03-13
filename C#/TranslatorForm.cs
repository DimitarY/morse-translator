using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Morse_Translator
{
    public partial class TranslatorForm : Form
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
        private const int WS_MAXIMIZEBOX = 0x10000;
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

        private Translator Translator;

        private Thread playThread = new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;
        });

        public TranslatorForm()
        {
            InitializeComponent();

            Translator = Translator.Instance;
        }

        private void TranslatorForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            translateBtn.Size = new Size(translateBtn.Width, selectionBox.Height);
            playBtn.Size = new Size(translateBtn.Width, selectionBox.Height);
            stopBtn.Size = new Size(translateBtn.Width, selectionBox.Height);

            ushort index = 0;
            foreach (var item in Translator.getLanguages())
            {
                selectionBox.Items.Add(item + " to Morse");
                selectionBox.Items.Add("Morse to " + item);
                if (item == "International") selectionBox.SelectedIndex = index;
                else index += 2;
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.SteelBlue;
            btn.ForeColor = Color.Black;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex >= 0 && selectionBox.SelectedIndex % 2 == 0)
            {
                outputBox.Text = Translator.languageToMorse(inputBox.Text.ToUpper(), selectionBox.SelectedItem.ToString().Remove(selectionBox.SelectedItem.ToString().Length - 9));
            }
            else if (selectionBox.SelectedIndex >= 0 && selectionBox.SelectedIndex % 2 != 0)
            {
                outputBox.Text = Translator.morseToLanguage(inputBox.Text.ToUpper(), selectionBox.SelectedItem.ToString().Remove(0, 9));
            }
            else MessageBox.Show("Please select a type.", "Error");

            System.GC.Collect();
        }

        private void playMorse(object sender, EventArgs e)
        {
            this.translateBtn_Click(sender, e);

            Button btn = (Button)sender;

            switch (selectionBox.SelectedIndex)
            {
                case 0:
                case 2:
                    if (btn.Name == "playBtn")
                    {
                        playThread = new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            Translator.playMorseAsSound(outputBox);
                        });
                        playThread.Start();
                    }
                    else if (btn.Name == "stopBtn") if (playThread.IsAlive) playThread.Abort();
                    break;
                case 1:
                case 3:
                    if (btn.Name == "playBtn")
                    {
                        playThread = new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            Translator.playMorseAsSound(inputBox);
                        });
                        playThread.Start();
                    }
                    else if (btn.Name == "stopBtn") if (playThread.IsAlive) playThread.Abort();
                    break;
            }
        }

        private void TranslatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playThread.IsAlive) playThread.Abort();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    inputBox.Text += "\n";
                    inputBox.Select(inputBox.Text.Length, 0);
                }
                this.translateBtn_Click(sender, e);
                e.Handled = true;
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

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
