using System;
using System.Reflection;

namespace BugFix
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor,
       AllowMultiple = true, Inherited=false)]
    public class BugFixAttribute : Attribute
    {
        public BugFixAttribute(string bugNumber, string comments)
        {
            BugNumber = bugNumber;
            Comments = comments;
        }

        public readonly string BugNumber;
        public readonly string Comments;
        public string Author = null;

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Author))
                return string.Format("BugFix {0} : {1}", BugNumber, Comments);
            else
                return string.Format("BugFix {0} by {1} : {2}", BugNumber, Author, Comments);
        }

        public static void DisplayFixes(System.Type t)
        {
            object[] fixes = t.GetCustomAttributes(typeof(BugFixAttribute), false);

            Console.WriteLine("Displaying fixes for {0}", t);

            foreach (BugFixAttribute bugFix in fixes)
            {
                Console.WriteLine("  {0}", bugFix);
            }

            foreach (MemberInfo member in t.GetMembers(BindingFlags.Instance |
                                                       BindingFlags.Public |
                                                       BindingFlags.NonPublic |
                                                       BindingFlags.Static))
            {
                object[] memberFixes = member.GetCustomAttributes(typeof(BugFixAttribute), false);

                if (memberFixes.Length > 0)
                {
                    Console.WriteLine("  {0}", member.Name);

                    foreach (BugFixAttribute memberFix in memberFixes)
                    {
                        Console.WriteLine("    {0}", memberFix);
                    }
                }
            }
        }
    }
}
