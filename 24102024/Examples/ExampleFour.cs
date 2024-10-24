using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Examples
{
    public class ExampleFour
    {
        //kv arrayin max duz diaqanalini out kimi cole cixardan metod
        //kvadrat arrayin olcusunu istifadeciden alaq
        public void ArrayMaxValueToDioganal(int _length, out int maxelement, out int maxdioganal,out int maxdioganal2)
        {



            Random rd = new Random();
            int[,] virtualArray = new int[_length, _length]; // kvadrat array
            maxelement = virtualArray[0, 0];
            maxdioganal = virtualArray[0, 0];
            maxdioganal2=virtualArray[0, 0];
            Console.WriteLine("*********************************************************");
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _length; j++)
                {
                    virtualArray[i, j] = rd.Next(10);
                    Console.Write(virtualArray[i, j] + ",");
                    if (maxelement < virtualArray[i, j])
                    {
                        maxelement = virtualArray[i, j];
                    }
                    if (i == j)
                    {
                        if (maxdioganal < virtualArray[i, j])
                        {
                            maxdioganal = virtualArray[i, j];
                        }
                    }
                    if ((i + j) == _length - 1)
                    {
                        if (maxdioganal2 < virtualArray[i, j])
                        {
                            maxdioganal2 = virtualArray[i, j];
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("*********************************************************");

        }
    }
}