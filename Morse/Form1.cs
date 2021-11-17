using System.Media;

namespace Morse
{
    public partial class Form1 : Form
    {
        public string path = "D:/Projects/C#/morse-translator/";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selctionBox.Items.Add("International to Morse");
            selctionBox.Items.Add("Morse to International");
        }

        private void transpate_Click(object sender, EventArgs e)
        {
            Translator translator = new Translator();

            switch (selctionBox.SelectedIndex)
            {
                case 0:
                    richTextBox2.Text = translator.languageToMorse(richTextBox1.Text.ToUpper());
                    break;
                case 1:
                    richTextBox2.Text = translator.morseToLanguage(richTextBox1.Text.ToUpper());
                    break;
                default:
                    MessageBox.Show("Please select a type.", "Error");
                    break;
            }
        }

        private void play_Click(object sender, EventArgs e)
        {
            SoundPlayer dit = new SoundPlayer(path + "Sounds/dit.wav");
            SoundPlayer dot = new SoundPlayer(path + "Sounds/dot.wav");
            switch (selctionBox.SelectedIndex)
            {
                case 0:
                    foreach (var item in richTextBox2.Text)
                    {
                        if (item == '.') dit.PlaySync();
                        else if (item == '-') dot.PlaySync();
                    }
                    break;
                case 1:
                    foreach (var item in richTextBox1.Text)
                    {
                        if (item == '.') dit.PlaySync();
                        else if (item == '-') dot.PlaySync();
                    }
                    break;
                default:
                    MessageBox.Show("Please select a type.", "Error");
                    break;
            }
        }
    }
}