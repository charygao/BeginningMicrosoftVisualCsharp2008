using System;

namespace BugFix
{
    [BugFix("101", "Created some methods")]
    public class MyBuggyCode
    {
        [BugFix("90125", "Removed call to base()", Author = "Morgan")]
        public MyBuggyCode()
        {
        }

        [BugFix("2112", "Returned a non null string")]
        [BugFix("38382", "Returned OK")]
        public string DoSomething()
        {
            return "OK";
        }
    }
}
