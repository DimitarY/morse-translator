using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Morse_Translator
{
    internal class Language
    {
        private static Language instance = null;
        public static Language Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Language();
                }
                return instance;
            }
        }

        private static string path = Path.GetFullPath(Directory.GetCurrentDirectory());

        private char symbol;
        private string code;

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

        public List<Language> getGramar(string language)
        {
            try
            {
                List<Language> grammar = new List<Language>();
                // TODO: трябва да се направи така че обекта да не си създава сам "grammar"
                string json;

                using (StreamReader r = new StreamReader(path + "/JSON/" + language + ".json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Language>>(json));
                }

                //TODO: при липса на файловете дава грешка
                using (StreamReader r = new StreamReader(path + "/JSON/Numbers.json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Language>>(json));
                }

                using (StreamReader r = new StreamReader(path + "/JSON/Symbols.json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Language>>(json));
                }

                return grammar;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Необходимите файлове не можаха да бъдат намерени.", "Error");
                throw;
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                MessageBox.Show("Проблем в четенето на JSON файловете.\nЛипстващ елемент.", "Error");
                throw;
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Един или няколко JSON файловете не бяха намерени.", "Error");
                throw;
            }
            catch (Exception)
            {
                throw;
            }

            //TODO: tova e greshno. trqbva da se vgradi v grewkite
            return null;
        }
    }

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

        private Language language = Language.Instance;

        private List<Language> grammar = new List<Language>();

        public void loadGrammar(string s_language) { grammar = language.getGramar(s_language); }

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
                foreach (Language symbol in grammar)
                {
                    if (symbol.Code == item)
                    {
                        result += symbol.Symbol;
                        done = true;
                        break;
                    }
                }
                if (!done) result += "(unknown) ";
            }

            return result;
        }

        public String languageToMorse(string input)
        {
            string temp = "", result = "";
            List<String> data = new List<String>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    if (i > 0 && input[i - 1] != ' ') temp += "  ";
                    else temp += "     ";
                }
                else if (input[i] == 'S' && i >= 2 && input[i - 1] == 'O' && input[i - 2] == 'S')
                {
                    data.RemoveRange(data.Count - 2, 2);
                    temp += "...---...";
                }
                else if (input[i] == '\n') temp += input[i];
                else
                {
                    bool done = false;
                    foreach (Language symbol in grammar)
                    {
                        if (symbol.Symbol == input[i])
                        {
                            temp += symbol.Code;
                            done = true;
                            break;
                        }
                    }
                    if (!done) temp += "(unknown) ";
                }

                temp += "  ";
                data.Add(temp);
                temp = "";
            }

            // Clean up code so is human readable
            foreach (var item in data)
            {
                string buffer = "";
                for (int i = 0; i < item.Length; i++)
                {
                    buffer += item[i];
                    if (item[i] == '.' || item[i] == '-') buffer += ' ';
                    else if (item[i] == '\n') i += 2;
                }
                result += buffer;
            }

            return result;
        }
    }
}
