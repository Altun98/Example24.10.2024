using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleTwo
    {
        //Soz arrayi cumleye ceviren out parametrli metod
        public void WordIntoSentence(string[] _arr, out string sentence)
        {
            sentence = "";
            foreach (var item in _arr)
            {
                sentence = sentence + " " + item;
            }
        }
    }
}
