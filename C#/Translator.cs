using System;
using System.Collections.Generic;
using System.Linq;

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

        private List<Language> grammar = new List<Language>();

        public void loadGrammar(string s_language) { grammar = Language.getGramar(s_language); }

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
