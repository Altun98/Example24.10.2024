using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24102024.Models
{
    public class Duzbucaqli
    {
        //  Duzbucaqli klasi ucun virtual metod yazmaq
        public virtual double Peremetr(double width, double length)
        {
            return width * length;
        }
    }
}
