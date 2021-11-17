using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Morse
{
    internal class Translator
    {
        public string path = "D:/Projects/C#/morse-translator/Morse/Morse/";
        public string Symbol { get; set; }
        public string Code { get; set; }

        private List<string> removeSpaceFromMorse(string input)
        {
            List<string> result = new List<string>();

            string temp = "";
            int space = 0;

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

        public String morseToLanguage(string input) // В бъдеще ще приема и език
        {
            try
            {
                List<Translator> Language;
                List<Translator> Numbers;

                using (StreamReader r = new StreamReader(path + "JSON/International.json"))
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
                        result += " ";
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
                return "Необходимите файлове не можаха да бъдат намерени";
            }
            catch (Newtonsoft.Json.JsonReaderException)
            {
                return "Проблем в четенето на JSON файловете.\nЛипстващ елемент.";
            }
        }
    }
}
