#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataRelationExample
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

			// Print out nested customers and their order ids
			foreach (DataRow custRow in thisDataSet.Tables["Customers"].Rows)
			{
				Console.WriteLine("Customer ID: " + custRow["CustomerID"] +
								  " Name: " + custRow["CompanyName"]);
				foreach (DataRow orderRow in custRow.GetChildRows(custOrderRel))
				{
					Console.WriteLine("  Order ID: " + orderRow["OrderID"]);
				}
			}
            /*
             * to implement writexml as instructed in chapter 24 Writing XML from a DataSet
             * custOrderRel.Nested = true;
             *
             * thisDataSet.WriteXml(@"c:\northwind\nwinddata.xml");
             * Console.WriteLine(
             *	 @"Successfully wrote XML output to file c:\northwind\nwinddata.xml");
             */
            /*
             * to implement writexml as instructed in chapter 24 Writing XML from a DataSet*/
             custOrderRel.Nested = true;
             
              thisDataSet.WriteXml(@"c:\northwind\nwinddata.xml");
              Console.WriteLine(
             	 @"Successfully wrote XML output to file c:\northwind\nwinddata.xml");
             

            thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
