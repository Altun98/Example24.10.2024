using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleThree
    {
        //Sozu tersine ceviren out parametrli metod
        public void TranslateIntoWords(string _word, out string _traWord)
        {
            _traWord = null;
            for (int i = _word.Length - 1; i >= 0; i--)
            {
                _traWord += _word[i];
            }
        }
    }
}
