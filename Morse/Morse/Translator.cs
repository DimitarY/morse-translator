using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    internal class Translator
    {
        public string Symbol { get; set; }
        public string Code { get; set; }

        public List<string> removeSpace(string input)
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
    }
}
