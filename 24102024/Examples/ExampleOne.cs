using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleOne
    {
        //Verilen herfi sozden cixardan funksiya
        // burada boyuk ve ya kiccik herf yazmaqimizin ferqi yoxdur.
        public string ToTakeOut(string _word, char _latter)
        {
            string result = "";
            for (int i = 0; i < _word.Length; i++)
            {
                if (_word[i].ToString().ToUpper() == _latter.ToString().ToUpper())
                {
                    continue;
                }
                result += _word[i];
            }
            return result;
        }
    }
}

