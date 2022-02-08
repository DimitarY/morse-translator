using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class MorseTranslator : Form
    {
        public MorseTranslator()
        {
            InitializeComponent();
        }

        private void MorseTranslator_Load(object sender, EventArgs e)
        {
            inputBox.BorderStyle = BorderStyle.FixedSingle;

            translateBtn.Size = new Size(translateBtn.Width, selctionBox.Height);

            // Трябва да се оптимизира, така че да взима какви езикови пакети има като JSON
            selctionBox.Items.Add("International to Morse");
            selctionBox.Items.Add("Morse to International");
        }

        private void translateBtn_Click(object sender, EventArgs e)
        {
            Translator translator = new Translator();

            switch (selctionBox.SelectedIndex)
            {
                case 0:
                    outputBox.Text = translator.languageToMorse(inputBox.Text.ToUpper(), "International");
                    break;
                case 1:
                    outputBox.Text = translator.morseToLanguage(inputBox.Text.ToUpper(), "International");
                    break;
                default:
                    MessageBox.Show("Please select a type.", "Error");
                    break;
            }
        }

        private void translateBtn_MouseEnter(object sender, EventArgs e)
        {
            translateBtn.BackColor = Color.SteelBlue;
            translateBtn.ForeColor = Color.Black;
        }

        private void translateBtn_MouseLeave(object sender, EventArgs e)
        {
            translateBtn.BackColor = Color.White;
            translateBtn.ForeColor = Color.Black;
        }
    }
}
