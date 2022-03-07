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

namespace Morse_Translator
{
    public partial class MainForm : Form
    {
        private Translator Translator;

        private Thread playThread = new Thread(() =>
        {
            Thread.CurrentThread.IsBackground = true;
        });

        public MainForm()
        {
            InitializeComponent();

            Translator = Translator.Instance;
        }

        private void MorseTranslator_Load(object sender, EventArgs e)
        {
            inputBox.BorderStyle = BorderStyle.FixedSingle;

            translateBtn.Size = new Size(translateBtn.Width, selectionBox.Height);
            playBtn.Size = new Size(translateBtn.Width, selectionBox.Height);
            stopBtn.Size = new Size(translateBtn.Width, selectionBox.Height);

            // Трябва да се оптимизира, така че да взима какви езикови пакети има като JSON
            selectionBox.Items.Add("International to Morse");
            selectionBox.Items.Add("Morse to International");
            selectionBox.Items.Add("Bulgarian to Morse");
            selectionBox.Items.Add("Morse to Bulgarian");

            selectionBox.SelectedIndex = 0;
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
            switch (selectionBox.SelectedIndex)
            {
                case 0:
                    outputBox.Text = Translator.languageToMorse(inputBox.Text.ToUpper(), "International");
                    break;
                case 1:
                    outputBox.Text = Translator.morseToLanguage(inputBox.Text.ToUpper(), "International");
                    break;
                case 2:
                    outputBox.Text = Translator.languageToMorse(inputBox.Text.ToUpper(), "Bulgarian");
                    break;
                case 3:
                    outputBox.Text = Translator.morseToLanguage(inputBox.Text.ToUpper(), "Bulgarian");
                    break;
                default:
                    MessageBox.Show("Please select a type.", "Error");
                    break;
            }

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playThread.IsAlive) playThread.Abort();
        }
    }
}
