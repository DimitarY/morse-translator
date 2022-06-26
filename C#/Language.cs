using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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

        public static List<String> getLanguages()
        {
            List<String> result = new List<String>();

            try
            {
                FileInfo[] files = new DirectoryInfo(path + "/Languages").GetFiles("*.json");
                foreach (FileInfo file in files)
                {
                    if (file.Name != "Symbols.json" && file.Name != "Numbers.json") result.Add(file.Name.Remove(file.Name.Length - 5));
                }
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Directory.CreateDirectory("Languages");
            }
            catch (Exception)
            {

            }

            return result;
        }

        public static List<Language> getGramar(string language)
        {
            try
            {
                List<Language> grammar = new List<Language>();
                string json;

                using (StreamReader r = new StreamReader(path + "/JSON/" + language + ".json"))
                {
                    json = r.ReadToEnd();

                    grammar.AddRange(JsonConvert.DeserializeObject<List<Language>>(json));
                }

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
            catch (Exception)
            {
                return null;
            }
        }
    }
}
