using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.WriteLine();
            Console.WriteLine($"Hello {aFriend}");

            Console.ReadKey();
        }
    }
}
