﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<char> Symbols { get { return this.symbols; } }
        public List<string> Codes { get { return this.codes; } }


        public void LoadData()
        {
            symbols.Clear();
            codes.Clear();

            translator.loadData("Bulgarian");
            List<Translator> grammar = translator.Grammar;
            foreach (Translator symbol in grammar)
            {
                this.symbols.Add(symbol.Symbol);
                this.codes.Add(symbol.Code);
            }
        }
    }
}
