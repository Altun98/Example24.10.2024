using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleSeven
    {
        //out parametrle array qaytaran metod ,uzunluqu parameter kimi verilsin
        public void ReturnArray(int length, out int[] arrayList)
        {
            Random rd = new Random();
            arrayList = new int[length];
            for (int i = 0; i < length; i++)
            {
                arrayList[i] = rd.Next(1,34);
            }
        }
    }
}
