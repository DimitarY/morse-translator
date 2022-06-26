using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class UserControl_Translator : UserControl
    {
        // Synchronizing Multiline Textbox Positions
        const int WM_USER = 0x400;
        const int EM_GETSCROLLPOS = WM_USER + 221;
        const int EM_SETSCROLLPOS = WM_USER + 222;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref Point lParam);
        // END

        private static UserControl_Translator instance = null;

        public static UserControl_Translator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl_Translator();
                }
                return instance;
            }
        }

        private Translator translator;
        private Sound sound;
        private Thread playThread = new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;
        });

        public UserControl_Translator()
        {
            InitializeComponent();

            exchangeButton.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

            translator = Translator.Instance;
            sound = Sound.Instance;
        }

        private void UserControl_Translator_Load(object sender, EventArgs e)
        {
            inputBox.BringToFront();
            outputBox.BringToFront();
        }

        private void UserControl_Translator_Enter(object sender, EventArgs e)
        {
            inputBox.Text = "";
            selectionBox.Items.Clear();
            ushort index = 0;
            foreach (var item in Language.getLanguages())
            {
                selectionBox.Items.Add(item + " to Morse");
                selectionBox.Items.Add("Morse to " + item);
                if (item == "International") selectionBox.SelectedIndex = index;
                else index += 2;
            }
        }

        private void button_Enter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Silver;
            (sender as Button).ForeColor = Color.Black;
        }

        private void button_Leave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromArgb(255, 255, 255);
            (sender as Button).ForeColor = Color.FromArgb(62, 120, 138);
        }

        private void Translate()
        {
            if (selectionBox.SelectedIndex >= 0 && selectionBox.SelectedIndex % 2 == 0)
            {
                outputBox.Text = translator.languageToMorse(inputBox.Text.ToUpper());
            }
            else if (selectionBox.SelectedIndex >= 0 && selectionBox.SelectedIndex % 2 != 0)
            {
                outputBox.Text = translator.morseToLanguage(inputBox.Text.ToUpper());
            }
            else MessageBox.Show("Please select a type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.GC.Collect();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            inputBox.Focus();

            System.GC.Collect();
        }

        //TODO: проблем при заключване на конторлите по време на възпроизвеждането
        private void playButton_Click(object sender, EventArgs e)
        {
            if (playThread.IsAlive)
            {
                //inputBox.ReadOnly = false;
                //exchangeButton.Enabled = true;
                //clearButton.Enabled = true;
                //selectionBox.Enabled = true;
                playButton.BackgroundImage = Properties.Resources.play_button;
                playThread.Abort();
                sound.setWaveOut();
            }
            else
            {
                //inputBox.ReadOnly = true;
                //exchangeButton.Enabled = false;
                //clearButton.Enabled = false;
                //selectionBox.Enabled = false;
                int selectionIndex = selectionBox.SelectedIndex;
                string inBox = inputBox.Text, outBox = outputBox.Text;

                playButton.BackgroundImage = Properties.Resources.stop_button;
                playThread = new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    if (selectionIndex >= 0 && selectionIndex % 2 == 0) sound.playMorseAsSound(outBox);
                    else if (selectionIndex >= 0 && selectionIndex % 2 != 0) sound.playMorseAsSound(inBox);
                    //inputBox.ReadOnly = false;
                    //exchangeButton.Enabled = true;
                    //clearButton.Enabled = true;
                    //selectionBox.Enabled = true;
                    playButton.BackgroundImage = Properties.Resources.play_button;
                    Cursor.Position = Cursor.Position;
                });
                playThread.Start();
            }

            System.GC.Collect();
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = outputBox.Text;
            inputBox.Select(inputBox.Text.Length, 0);
            inputBox.ScrollToCaret();
            this.Translate();
            if (selectionBox.SelectedIndex % 2 != 0) selectionBox.SelectedIndex = (int)selectionBox.SelectedIndex - 1;
            else if (selectionBox.SelectedIndex % 2 == 0) selectionBox.SelectedIndex = (int)selectionBox.SelectedIndex + 1;
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Control.ModifierKeys == Keys.Shift) e.Handled = false;
                else e.Handled = true;
            }
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (selectionBox.SelectedIndex < 0)
            {
                e.Handled = true;
                MessageBox.Show("Please select a language.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (selectionBox.SelectedIndex % 2 != 0 && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            this.Translate();
        }

        private void selectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionBox.SelectedIndex % 2 != 0)
            {
                translator.loadGrammar(selectionBox.SelectedItem.ToString().Remove(0, 9));
            }
            else if (selectionBox.SelectedIndex % 2 == 0)
            {
                translator.loadGrammar(selectionBox.SelectedItem.ToString().Remove(selectionBox.SelectedItem.ToString().Length - 9));
            }
            inputBox.Focus();
            this.Translate();
        }

        private void inputBox_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();
            SendMessage(inputBox.Handle, EM_GETSCROLLPOS, 0, ref pt);
            SendMessage(outputBox.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }

        private void outputBox_VScroll(object sender, EventArgs e)
        {
            Point pt = new Point();
            SendMessage(outputBox.Handle, EM_GETSCROLLPOS, 0, ref pt);
            SendMessage(inputBox.Handle, EM_SETSCROLLPOS, 0, ref pt);
        }
    }
}
