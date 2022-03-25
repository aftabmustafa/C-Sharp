using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iMax = int.MaxValue;
            int iMin = int.MinValue;

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            double dMax = double.MaxValue; 
            double dMin = double.MinValue;

            decimal dcMax = decimal.MaxValue;
            decimal dcMin = decimal.MinValue;

            Console.WriteLine(iMax);
            Console.WriteLine(iMin);

            Console.WriteLine();

            Console.WriteLine(fMax);
            Console.WriteLine(fMin);

            Console.WriteLine();

            Console.WriteLine(dMax);   
            Console.WriteLine(dMin);

            Console.WriteLine();

            Console.WriteLine(dcMax);
            Console.WriteLine(dcMin);
        }
    }
}
