using Newtonsoft.Json;

namespace Morse
{
    public partial class Form1 : Form
    {
        public string path = "D:/Projects/C#/morse-translator/Morse/Morse/";

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

            List<string> input;

            input = translator.removeSpace(textBox1.Text);

            label1.Text = "Start:\n";
            
            try
            {
                List<Translator> International;
                List<Translator> Numbers;

                using (StreamReader r = new StreamReader(path + "JSON/International.json"))
                {
                    string json = r.ReadToEnd();

                    International = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                using (StreamReader r = new StreamReader(path + "JSON/Numbers.json"))
                {
                    string json = r.ReadToEnd();

                    Numbers = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                foreach (string item in input)
                {
                    if (item == " ")
                    {
                        label1.Text += item;
                        label1.Text += "\n";
                    }

                    foreach (Translator symbol in International)
                    {
                        if (symbol.Code == item)
                        {
                            label1.Text += symbol.Symbol;
                            label1.Text += "\n";
                        }
                    }

                    foreach (Translator symbol in Numbers)
                    {
                        if (symbol.Code == item)
                        {
                            label1.Text += symbol.Symbol;
                            label1.Text += "\n";
                        }
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Необходимите файлове не можаха да бъдат намерени", "Error");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Проблем в четенето на JSON файловете.\n" +
                    "Липстващ елемент.", "Error");
            }






            label1.Text += "*";
        }
    }
}