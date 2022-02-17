using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Translator
{
    public partial class MainForm : Form
    {
        private Translator Translator;

        public MainForm()
        {
            InitializeComponent();

            Translator = Translator.Instance;
        }

        private void MorseTranslator_Load(object sender, EventArgs e)
        {
            inputBox.BorderStyle = BorderStyle.FixedSingle;

            translateBtn.Size = new Size(translateBtn.Width, selctionBox.Height);
            playBtn.Size = new Size(translateBtn.Width, selctionBox.Height);

            // Трябва да се оптимизира, така че да взима какви езикови пакети има като JSON
            selctionBox.Items.Add("International to Morse");
            selctionBox.Items.Add("Morse to International");
            selctionBox.Items.Add("Bulgarian to Morse");
            selctionBox.Items.Add("Morse to Bulgarian");
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
            switch (selctionBox.SelectedIndex)
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

        private void play_Click(object sender, EventArgs e)
        {
            this.translateBtn_Click(sender, e);

            SoundPlayer dit = new SoundPlayer("D:/Projects/morse-translator/Sounds/dit.wav");
            SoundPlayer dot = new SoundPlayer("D:/Projects/morse-translator/Sounds/dot.wav");
            switch (selctionBox.SelectedIndex)
            {
                case 0:
                case 2:
                    System.Threading.Thread.Sleep(500);
                    foreach (var item in outputBox.Text)
                    {
                        if (item == '.') dit.PlaySync();
                        else if (item == '-') dot.PlaySync();
                        else if (item == ' ') System.Threading.Thread.Sleep(5);
                    }
                    break;
                case 1:
                case 3:
                    System.Threading.Thread.Sleep(500);
                    foreach (var item in inputBox.Text)
                    {
                        if (item == '.') dit.PlaySync();
                        else if (item == '-') dot.PlaySync();
                        else if (item == ' ') System.Threading.Thread.Sleep(5);
                    }
                    break;
                default:
                    MessageBox.Show("Please select a type.", "Error");
                    break;
            }
        }
    }
}
