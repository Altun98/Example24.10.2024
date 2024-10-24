using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleFive
    {
        //whilw ile 5 e bolunen ededleri tapmaq
        public void DividToFive1(int length)
        {
            //1-ci usul
            int x = 0;
            while (x < length)
            {
                x+=5;
                Console.Write(x + ",");
            }
        }
        public void DividToFive2(int length)
        {
            //2-ci usul
            int x = 1;
            while (x < length)
            {
                if (x % 5 == 0)
                {
                    Console.Write(x + ",");
                }
                x++;
            }
        }

    }
}
