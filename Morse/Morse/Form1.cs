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
            string input = textBox1.Text; // ����������� �� �������� �� ������� � �����.
                                          // ������ �� �� ������� ���������� �� ��������� �� ���������.

            try
            {
                List<Translator> International;
                List<Translator> Numbers;

                using (StreamReader r = new StreamReader(path + "JSON/International.json"))
                {
                    string json = r.ReadToEnd();

                    International = JsonConvert.DeserializeObject<List<Translator>>(json);

                    foreach (Translator item in International)
                    {
                        if (item.Code == input) MessageBox.Show(item.Symbol);
                    }
                }

                using (StreamReader r = new StreamReader(path + "JSON/Numbers.json"))
                {
                    string json = r.ReadToEnd();

                    Numbers = JsonConvert.DeserializeObject<List<Translator>>(json);

                    foreach (Translator item in Numbers)
                    {
                        if (item.Code == input) MessageBox.Show(item.Symbol);
                    }
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("������������ ������� �� ������ �� ����� ��������", "Error");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("������� � �������� �� JSON ���������.\n" +
                    "�������� �������.", "Error");
            }
        }
    }
}