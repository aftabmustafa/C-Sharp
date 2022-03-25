using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci Using While Loop
            var fN = new List<int> { 1, 1 };

            while(fN.Count < 20)
            {
                var p1 = fN[fN.Count - 1];
                var p2 = fN[fN.Count - 2];

                fN.Add(p1 + p2);
            }

            foreach(int i in fN) 
            {
                Console.WriteLine(i);
            }
        }
    }
}

// Declaring and initializing List
//var names = new List<string> { "<name>", "Ana", "Felipe" };

//// Printing list 'names"
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");
//}

//Console.WriteLine();

//// Adding items to list
//names.Add("Maria");
//names.Add("Bill");

//// Removing item to list
//names.Remove("Ana");

//// Printing the updated list
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");
//}

//// Accessing member of list using their index
//Console.WriteLine($"My name is {names[0]}");

//Console.WriteLine();

//// Counting items of a list
////Console.WriteLine($"The list has {names.Count} people in it");

//// Searching an item inside a list
//var index = names.IndexOf("Felipe");
//if (index != -1)
//{
//    Console.WriteLine($"the name {names[index]} is at index {index}");
//}

//// If an items is NOT found, C# returns -1
//var notFound = names.IndexOf("Not Found");
//Console.WriteLine($"Item not found, IndexOf returns {notFound}");

//Console.WriteLine();

//// Sorting the list names and printing its value
//names.Sort();
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");
//}
// Fibonacci Using For Loop
//var fN = new List<int> { 1, 1 };

//for (int i = 0; i < 18; i++)
//{
//    var p = fN[fN.Count - 1];
//    var p2 = fN[fN.Count - 2];

//    fN.Add(p + p2);
//}

//foreach (int n in fN)
//{
//    Console.WriteLine(n);
//}
