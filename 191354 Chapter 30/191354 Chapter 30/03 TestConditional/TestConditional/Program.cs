using System;
using System.Diagnostics;

namespace TestConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call a method only available if DEBUG is defined...
            Program.DebugOnly();
        }

        // This method is atributed, and will ONLY be included in
        // the emitted code if the DEBUG symbol is defined when
        // the program is compiled
        [Conditional("DEBUG")]
        public static void DebugOnly()
        {
            // This line will only be displayed in debug builds...
            Console.WriteLine("This string only displays in Debug");
        }
    }
}
