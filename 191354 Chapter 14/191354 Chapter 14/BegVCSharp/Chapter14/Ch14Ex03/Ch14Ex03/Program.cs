using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtensionLib;

namespace Ch14Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to convert:");
            string sourceString = Console.ReadLine();
            Console.WriteLine("String with title casing: {0}", sourceString.ToTitleCase(true));
            Console.WriteLine("String backwards: {0}", sourceString.ReverseString());
            Console.WriteLine("String length backwards: {0}",
               sourceString.Length.ToStringReversed());
            Console.ReadKey();
        }
    }
}
