using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse_Translator
{
    internal class API_Worker
    {
        private static API_Worker instance = null;
        public static API_Worker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new API_Worker();
                }
                return instance;
            }
        }

        private string apiURL = "http://127.0.0.1:5000";
    }
}
