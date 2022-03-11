using System;
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
    }
}
