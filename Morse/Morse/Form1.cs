namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translator translator = new Translator();

            //label1.Text = translator.morseToLanguage(textBox1.Text);
            label1.Text = translator.languageToMorse(textBox1.Text.ToUpper());
        }
    }
}