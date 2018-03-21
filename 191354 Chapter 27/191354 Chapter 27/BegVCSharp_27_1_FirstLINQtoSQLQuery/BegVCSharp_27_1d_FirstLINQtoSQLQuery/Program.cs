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
            
            var totalResults = from c in northWindDataContext.Customers
                               select new 
                               {
                                   Country = c.Country,
                                   Sales = c.Orders.Sum(o => o.Order_Details.Sum(od => od.Quantity * od.UnitPrice))
                               };
            var groupResults =
                from c in totalResults
                group c by c.Country into cg
                select new { TotalSales = cg.Sum(c => c.Sales), Country = cg.Key }
            ;

            var orderedResults =
                from cg in groupResults
                orderby cg.TotalSales descending
                select cg
             ;

            Console.WriteLine("Country\t\tTotal Sales\n--------\t------------");
            foreach (var item in orderedResults) { 
                    Console.WriteLine("{0,-15}{1,12}", item.Country, item.TotalSales.ToString("C2"));
            }

            Console.WriteLine("Press Enter/Return to continue...");
            Console.ReadLine();
        }
    }
}
