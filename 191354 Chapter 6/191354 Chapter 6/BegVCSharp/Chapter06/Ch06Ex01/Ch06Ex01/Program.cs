using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex01
{
    // Code for first Try It Out
    class Program
    {
        static void Write()
        {
            Console.WriteLine("Text output from function.");
        }

        static void Main(string[] args)
        {
            Write();
            Console.ReadKey();
        }
    }

    //// Code for fourth Try It Out
    //class Program
    //{
    //    static void Write()
    //    {
    //        Console.WriteLine("myString = {0}", myString);
    //    }

    //    static void Main(string[] args)
    //    {
    //        string myString = "String defined in Main()";
    //        Write();
    //        Console.ReadKey();
    //    }
    //}

    //// Code for first part of How It Works in fourth Try It Out
    //class Program
    //{
    //    static void Write()
    //    {
    //        string myString = "String defined in Write()";
    //        Console.WriteLine("Now in Write()");
    //        Console.WriteLine("myString = {0}", myString);
    //    }

    //    static void Main(string[] args)
    //    {
    //        string myString = "String defined in Main()";
    //        Write();
    //        Console.WriteLine("\nNow in Main()");
    //        Console.WriteLine("myString = {0}", myString);
    //        Console.ReadKey();
    //    }
    //}

    //// Code for second part of How It Works in fourth Try It Out
    //class Program
    //{
    //    static string myString;

    //    static void Write()
    //    {
    //        string myString = "String defined in Write()";
    //        Console.WriteLine("Now in Write()");
    //        Console.WriteLine("Local myString = {0}", myString);
    //        Console.WriteLine("Global myString = {0}", Program.myString);
    //    }

    //    static void Main(string[] args)
    //    {
    //        string myString = "String defined in Main()";
    //        Program.myString = "Global string";
    //        Write();
    //        Console.WriteLine("\nNow in Main()");
    //        Console.WriteLine("Local myString = {0}", myString);
    //        Console.WriteLine("Global myString = {0}", Program.myString);
    //        Console.ReadKey();
    //    }
    //}
}
