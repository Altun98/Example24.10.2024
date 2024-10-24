using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleEight
    {
        //sozu herflere parcalayib char array kimi qaytaran metod

        public char[] WordChars(string word)
        {
            char[] _carray= new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                _carray[i] = word[i];
            }
            return _carray;
        }
    }
}
