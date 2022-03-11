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

            foreach (var item in Translator.getLanguages())
            {
                selectionBox.Items.Add(item + " to Morse");
                selectionBox.Items.Add("Morse to " + item);
            }

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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playThread.IsAlive) playThread.Abort();
        }
    }
}
