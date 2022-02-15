using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Morse
{
    internal class Translator
    {
        private string path = "D:/Projects/C#/morse-translator/";
        private char symbol;
        private string code;

        public char Symbol { get { return this.symbol; } set { this.symbol = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }

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

                if (item.index == input.Length - 1)
                {
                    result.Add(temp);
                }
            }

            return result;
        }

        public String morseToLanguage(string input, string outputLanguage)
        {
            try
            {
                string transtalateLanguagePath = "";

                switch (outputLanguage)
                {
                    case "International":
                        transtalateLanguagePath = path + "JSON/International.json";
                        break;
                    case "Bulgarian":
                        transtalateLanguagePath = path + "JSON/Bulgarian.json";
                        break;
                }

                List<Translator> Language;
                List<Translator> Numbers;

                using (StreamReader r = new StreamReader(transtalateLanguagePath))
                {
                    string json = r.ReadToEnd();

                    Language = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                using (StreamReader r = new StreamReader(path + "JSON/Numbers.json"))
                {
                    string json = r.ReadToEnd();

                    Numbers = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                List<string> array = this.removeSpaceFromMorse(input);
                string result = "";

                foreach (string item in array)
                {
                    if (item == " ")
                    {
                        result += item;
                    }

                    if (item == "...---...")
                    {
                        result += "SOS";
                    }

                    foreach (Translator symbol in Language)
                    {
                        if (symbol.Code == item)
                        {
                            result += symbol.Symbol;
                        }
                    }

                    foreach (Translator symbol in Numbers)
                    {
                        if (symbol.Code == item)
                        {
                            result += symbol.Symbol;
                        }
                    }
                }

                return result;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                return "Необходимите файлове не можаха да бъдат намерени.";
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                return "Проблем в четенето на JSON файловете.\nЛипстващ елемент.";
            }
        }

        public String languageToMorse(string input, string inputLanguage)
        {
            try
            {
                string transtalateLanguagePath = "";

                switch (inputLanguage)
                {
                    case "International":
                        transtalateLanguagePath = path + "JSON/International.json";
                        break;
                    case "Bulgarian":
                        transtalateLanguagePath = path + "JSON/Bulgarian.json";
                        break;
                }

                List<Translator> Language;
                List<Translator> Numbers;

                using (StreamReader r = new StreamReader(transtalateLanguagePath))
                {
                    string json = r.ReadToEnd();

                    Language = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                using (StreamReader r = new StreamReader(path + "JSON/Numbers.json"))
                {
                    string json = r.ReadToEnd();

                    Numbers = JsonConvert.DeserializeObject<List<Translator>>(json);
                }

                string temp = "", result = "";

                foreach (char item in input)
                {
                    if (item == ' ')
                    {
                        temp += "       "; // Word end
                    }
                    else
                    {
                        foreach (Translator symbol in Language)
                        {
                            if (symbol.Symbol == item)
                            {
                                temp += symbol.Code;
                                temp += "  "; // Letter end
                            }
                        }

                        foreach (Translator symbol in Numbers)
                        {
                            if (symbol.Symbol == item)
                            {
                                temp += symbol.Code;
                                temp += "  "; // Letter end
                            }
                        }
                    }
                }

                foreach (char item in temp)
                {
                    result += item;
                    if (item == '.' || item == '-') result += ' ';
                }

                return result;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                return "Необходимите файлове не можаха да бъдат намерени";
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                return "Проблем в четенето на JSON файловете.\nЛипстващ елемент.";
            }
        }
    }
}
