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
                                   Orders = c.Orders
                               };
            foreach (var item in queryResults) {
                Console.WriteLine(
                    "Customer: {0} {1}, {2}\n{3} orders:\tOrder ID\tOrder Date",
                    item.Name, item.City, item.State, item.Orders.Count
                );
                foreach (Order o in item.Orders) {
                    Console.WriteLine("\t\t{0}\t{1}", o.OrderID, o.OrderDate);
                }                
            }

            Console.WriteLine("Press Enter/Return to continue...");
            Console.ReadLine();
        }
    }
}
