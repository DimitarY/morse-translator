using System.Collections.Generic;

namespace Morse_Translator
{
    internal class Trainer
    {
        private static Trainer instance = null;
        public static Trainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Trainer();
                }
                return instance;
            }
        }

        private Translator translator = Translator.Instance;

        private List<char> symbols = new List<char>();
        private List<string> codes = new List<string>();
        private ushort maxLength = 0;

        public List<char> Symbols { get { return this.symbols; } }
        public List<string> Codes { get { return this.codes; } }
        public ushort MaxLength { get { return this.maxLength; } }


        public void LoadData(string language)
        {
            symbols.Clear();
            codes.Clear();

            translator.loadGrammar(language);
            foreach (Language symbol in translator.Grammar)
            {
                this.symbols.Add(symbol.Symbol);
                this.codes.Add(symbol.Code);
            }

            // Clean up code so is human readable
            for (int i = 0; i < this.codes.Count; i++)
            {
                string buffer = "";
                for (int j = 0; j < codes[i].Length; j++)
                {
                    buffer += codes[i][j];
                    if (codes[i][j] == '.' || codes[i][j] == '-') buffer += '␣';
                    else if (codes[i][j] == '\n') i += 2;
                }
                codes[i] = buffer;
                if (codes[i].Length > maxLength) maxLength = (ushort)codes[i].Length;
            }
        }
    }
}
