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

        private static List<Translator> Language;
        private static List<Translator> Numbers;
        private static List<Translator> Symbols;

        private string path = Path.GetFullPath(Directory.GetCurrentDirectory());

        private char symbol;
        private string code;

        public char Symbol { get { return this.symbol; } set { this.symbol = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }

        public List<string> getLanguages()
        {
            List<string> result = new List<string>();

            FileInfo[] files = new DirectoryInfo(path + "/JSON").GetFiles("*.json");
            foreach (FileInfo file in files)
            {
                if (file.Name != "Symbols.json" && file.Name != "Numbers.json") result.Add(file.Name.Remove(file.Name.Length - 5));
            }

            return result;
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

                if (item.index == input.Length - 1)
                {
                    result.Add(temp);
                }
            }

            return result;
        }

        private void loadData(string language)
        {
            try
            {
                string json;

                using (StreamReader r = new StreamReader(path + "/JSON/" + language + ".json"))
                {
                    json = r.ReadToEnd();

                    Language = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                using (StreamReader r = new StreamReader(path + "/JSON/Numbers.json"))
                {
                    json = r.ReadToEnd();

                    Numbers = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                using (StreamReader r = new StreamReader(path + "/JSON/Symbols.json"))
                {
                    json = r.ReadToEnd();

                    Symbols = JsonConvert.DeserializeObject<List<Translator>>(json);
                }
            }
            catch (Exception)
            {
                throw;
            }

            //catch (System.IO.DirectoryNotFoundException)
            //{
            //    return "Необходимите файлове не можаха да бъдат намерени.";
            //}
            //catch (Newtonsoft.Json.JsonReaderException)
            //{
            //    return "Проблем в четенето на JSON файловете.\nЛипстващ елемент.";
            //}
        }

        // Не е оптимизирано при откриване на символа да продължи към следвашия и да изпишва грешка при непознат символ.
        public String morseToLanguage(string input, string outputLanguage)
        {
            loadData(outputLanguage);

            string result = "";

            foreach (string item in this.removeSpaceFromMorse(input))
            {
                if (item == " ")
                {
                    result += item;
                }
                else if (item == "\n") result += item;
                else if (item == "...---...")
                {
                    result += "SOS";
                }

                foreach (Translator symbol in Language)
                {
                    if (symbol.Code == item)
                    {
                        result += symbol.Symbol;
                        break;
                    }
                }

                foreach (Translator symbol in Numbers)
                {
                    if (symbol.Code == item)
                    {
                        result += symbol.Symbol;
                        break;
                    }
                }

                foreach (Translator symbol in Symbols)
                {
                    if (symbol.Code == item)
                    {
                        result += symbol.Symbol;
                        break;
                    }
                }
            }

            return result;
        }

        public String languageToMorse(string input, string inputLanguage)
        {
            loadData(inputLanguage);

            string temp = "", result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (i > 0 && input[i - 1] != ' ') temp += "  ";
                    else temp += "     ";
                }
                else if (input[i] == 'S' && input.Length >= i + 2 && input[i + 1] == 'O' && input[i + 2] == 'S')
                {
                    temp += "...---...";
                    i += 2;
                }
                else if (Char.IsLetter(input[i]))
                {
                    foreach (Translator symbol in Language)
                    {
                        if (symbol.Symbol == input[i])
                        {
                            temp += symbol.Code;
                            break;
                        }
                    }
                }
                else if (Char.IsDigit(input[i]))
                {
                    foreach (Translator symbol in Numbers)
                    {
                        if (symbol.Symbol == input[i])
                        {
                            temp += symbol.Code;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (Translator symbol in Symbols)
                    {
                        if (symbol.Symbol == input[i])
                        {
                            temp += symbol.Code;
                            break;
                        }
                    }
                }

                temp += "  ";
                if (input[i] == '\n') temp += input[i];
            }

            // Clean up code so is human readable
            foreach (char item in temp)
            {
                result += item;
                if (item == '.' || item == '-') result += ' ';
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
