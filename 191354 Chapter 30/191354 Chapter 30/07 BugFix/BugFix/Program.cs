using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugFix
{
    class Program
    {
        static void Main(string[] args)
        {
            BugFixAttribute.DisplayFixes(typeof(MyBuggyCode));
        }
    }
}
