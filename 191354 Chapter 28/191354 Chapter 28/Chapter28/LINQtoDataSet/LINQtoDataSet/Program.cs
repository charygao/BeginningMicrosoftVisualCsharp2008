using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Data.Linq;      // Use LINQ / ADO.NET connector
using System.Data.Common;
using System.Text;

namespace LINQtoDataSet
{

    class Program
    {
        static void Main(string[] args)
        {

            // Specify SQL Server-specific connection string
            SqlConnection thisConnection = new SqlConnection(
                @"Data Source=.\SQLEXPRESS;" +
                @"AttachDbFilename='C:\SQL Server 2000 Sample Databases\NORTHWND.MDF';" +
                @"Integrated Security=True;Connect Timeout=30;User Instance=true");

            // Create DataAdapter object for update and other operations
            SqlDataAdapter thisAdapter = new SqlDataAdapter(
                 "SELECT CustomerID, CompanyName FROM Customers", thisConnection);
            // Create CommandBuilder object to build SQL commands
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

            // Create DataSet to contain related data tables, rows, and columns
            DataSet thisDataSet = new DataSet();

            // Set up DataAdapter objects for each table and fill
            SqlDataAdapter custAdapter = new SqlDataAdapter(
                 "SELECT * FROM Customers", thisConnection);
            SqlDataAdapter orderAdapter = new SqlDataAdapter(
                 "SELECT * FROM Orders", thisConnection);
            custAdapter.Fill(thisDataSet, "Customers");
            orderAdapter.Fill(thisDataSet, "Orders");

            // Set up DataRelation between customers and orders
            DataRelation custOrderRel = thisDataSet.Relations.Add("CustOrders",
                 thisDataSet.Tables["Customers"].Columns["CustomerID"],
                 thisDataSet.Tables["Orders"].Columns["CustomerID"]);

            var customers = thisDataSet.Tables["Customers"].AsEnumerable();
            var orders = thisDataSet.Tables["Orders"].AsEnumerable();

            var preferredCustomers =
                from c in customers
                where c.GetChildRows("CustOrders").Length > 10
                orderby c.GetChildRows("CustOrders").Length
                select c;

            Console.WriteLine("Customers with > 10 orders:");
            foreach (var customer in preferredCustomers)
            {
                Console.WriteLine("{0} orders: {1} {2}, {3} {4}",
                    customer.GetChildRows("CustOrders").Length,
                    customer["CustomerID"], customer["CompanyName"], customer["City"], customer["Region"]
                    );
            }
            thisConnection.Close();
            Console.Write("Program finished, press Enter/Return to continue:");
            Console.ReadLine();

        }
    }
}