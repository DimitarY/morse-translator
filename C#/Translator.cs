using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Morse_Translator
{
    internal class Translator
    {
        // The space between symbols(dots and dashes) of the same letter is 1 time unit.
        // The space between letters is 3 time units.
        // The space between words is 7 time units.

        private static Translator instance = null;
        public static Translator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Translator();
                }
                return instance;
            }
        }

        private static string path = Path.GetFullPath(Directory.GetCurrentDirectory());

        private char symbol;
        private string code;
        private List<Translator> grammar = new List<Translator>();

        public char Symbol { get { return this.symbol; } set { this.symbol = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }

        public static List<string> getLanguages()
        {
            List<string> result = new List<string>();

            // TODO: try catch
            try
            {
                FileInfo[] files = new DirectoryInfo(path + "/JSON").GetFiles("*.json");
                foreach (FileInfo file in files)
                {
                    if (file.Name != "Symbols.json" && file.Name != "Numbers.json") result.Add(file.Name.Remove(file.Name.Length - 5));
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Необходимите файлове не можаха да бъдат намерени.", "Error");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Проблем в четенето на JSON файловете.\nЛипстващ елемент.", "Error");
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public void loadData(string language)
        {
            try
            {
                grammar.Clear();
                string json;

                using (StreamReader r = new StreamReader(path + "/JSON/" + language + ".json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Translator>>(json));
                }

                using (StreamReader r = new StreamReader(path + "/JSON/Numbers.json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Translator>>(json));
                }

                using (StreamReader r = new StreamReader(path + "/JSON/Symbols.json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Translator>>(json));
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Необходимите файлове не можаха да бъдат намерени.", "Error");
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Проблем в четенето на JSON файловете.\nЛипстващ елемент.", "Error");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private List<string> removeSpaceFromMorse(string input) // Convert Morse code from human type to computer type
        {
            List<string> result = new List<string>();

            string temp = "";
            ushort space = 0;

            foreach (var item in input.Select((value, index) => (value, index)))
            {
                if (item.value == '.' || item.value == '-')
                {
                    if (space == 3)
                    {
                        result.Add(temp);
                        temp = "";
                    }
                    else if (space >= 7)
                    {
                        result.Add(temp);
                        result.Add(" ");
                        temp = "";
                    }
                    space = 0;
                    temp += item.value;
                }
                else if (item.value == ' ') space++;
                else if (item.value == '\n')
                {
                    result.Add(temp);
                    result.Add("\n");
                    temp = "";
                }

                if (item.index == input.Length - 1 && temp != "")
                {
                    result.Add(temp);
                }
            }

            return result;
        }

        public String morseToLanguage(string input)
        {
            string result = "";

            foreach (string item in this.removeSpaceFromMorse(input))
            {
                if (item == " ")
                {
                    result += item;
                    continue;
                }
                else if (item == "\n")
                {
                    result += item;
                    continue;
                }
                else if (item == "...---...")
                {
                    result += "SOS";
                    continue;
                }

                bool done = false;
                foreach (Translator symbol in grammar)
                {
                    if (symbol.Code == item)
                    {
                        result += symbol.Symbol;
                        done = true;
                        break;
                    }
                }
                if (!done) result += "(unknown)";
            }

            return result;
        }

        public String languageToMorse(string input)
        {
            string temp = "", result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (i > 0 && input[i - 1] != ' ') temp += "  ";
                    else temp += "     ";
                }
                else if (input[i] == 'S' && i >= 2 && input[i - 1] == 'O' && input[i - 2] == 'S')
                {
                    temp = temp.Remove(temp.Length - 10);
                    temp += "...---...";
                }
                else if (input[i] == '\n') temp += input[i];
                else
                {
                    bool done = false;
                    foreach (Translator symbol in grammar)
                    {
                        if (symbol.Symbol == input[i])
                        {
                            temp += symbol.Code;
                            done = true;
                            break;
                        }
                    }
                    if (!done) temp += "(unknown)";
                }

                temp += "  ";
            }

            // Clean up code so is human readable
            for (int i = 0; i < temp.Length; i++)
            {
                result += temp[i];
                if (temp[i] == '.' || temp[i] == '-') result += ' ';
                else if (temp[i] == '\n') i += 2;
            }

            return result;
        }

        public void playMorseAsSound(RichTextBox richTextBox)
        {
            try
            {
                bool status = richTextBox.Enabled;
                richTextBox.Enabled = false;

                foreach (var item in richTextBox.Text)
                {
                    if (item == '.') Console.Beep(550, 100);
                    else if (item == '-') Console.Beep(550, 300);
                    else Task.Delay(300);
                }

                richTextBox.Enabled = status;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
