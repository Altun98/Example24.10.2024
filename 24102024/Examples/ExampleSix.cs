using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleSix
    {
        //verilen arrayin tek elementlerini out ile tapmaq
        public void ArrayOddElements(int length, out List<int> odd1)
        {
            odd1 = new List<int>();
            Random rd = new Random();
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]= rd.Next(1,219);
                if (arr[i]%2!= 0)
                {
                    odd1.Add(arr[i]);
                }
            }
        }
    }
}