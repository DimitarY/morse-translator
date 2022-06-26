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

        private List<char> symbols = new List<char>();
        private List<string> codes = new List<string>();
        private ushort maxLength = 0;

        public List<char> Symbols { get { return this.symbols; } }
        public List<string> Codes { get { return this.codes; } }
        public ushort MaxLength { get { return this.maxLength; } }


        public void LoadData(string s_language, bool getNumbers = true, bool getSymbols = true)
        {
            symbols.Clear();
            codes.Clear();

            foreach (Language symbol in Language.getGramar(s_language))
            {
                if (char.IsDigit(symbol.Symbol) && !getNumbers) continue;
                else if (!char.IsDigit(symbol.Symbol) && !char.IsLetter(symbol.Symbol) && !getSymbols) continue;

                this.symbols.Add(symbol.Symbol);
                this.codes.Add(symbol.Code);

            }

            this.maxLength = 0;
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
                if (codes[i].Length > this.maxLength) this.maxLength = (ushort)codes[i].Length;
            }
        }
    }
}
