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
                Console.WriteLine("Customer: {0} {1}, {2}\n{3} orders:  Order ID\tOrder Date\tTotal Amount", 
                    item.Name, item.City, item.State, item.Orders.Count);
                foreach (Order o in item.Orders)
                    Console.WriteLine("\t{0,10}\t{1,10}\t{2,10}", 
                        o.OrderID, 
                        o.OrderDate.Value.ToShortDateString(), 
                        o.Order_Details.Sum(od => od.Quantity * od.UnitPrice).ToString("C2"));
            }

            Console.WriteLine("Press Enter/Return to continue...");
            Console.ReadLine();
        }
    }
}
