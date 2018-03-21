using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BegVCSharp_27_1_FirstLINQtoSQLQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindDataContext northWindDataContext = new NorthwindDataContext();
            
            var queryResults = from c in northWindDataContext.Customers
                               where c.Country == "USA"
                               select new
                               {
                                   ID = c.CustomerID,
                                   Name = c.CompanyName,
                                   City = c.City,
                                   State = c.Region,
                               };
            foreach (var item in queryResults) {
                    Console.WriteLine(item);
            }

            Console.WriteLine("Press Enter/Return to continue...");
            Console.ReadLine();
        }
    }
}
