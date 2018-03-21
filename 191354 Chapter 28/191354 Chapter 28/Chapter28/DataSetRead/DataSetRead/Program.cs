#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataSetRead
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

			// Create DataAdapter object 
			SqlDataAdapter thisAdapter = new SqlDataAdapter(
				 "SELECT CustomerID, ContactName FROM Customers", thisConnection);

			// Create DataSet to contain related data tables, rows, and columns
			DataSet thisDataSet = new DataSet();

			// Fill DataSet using query defined previously for DataAdapter
			thisAdapter.Fill(thisDataSet, "Customers");
			foreach (DataRow theRow in thisDataSet.Tables["Customers"].Rows)
			{
				Console.WriteLine(theRow["CustomerID"] + "\t" +
													  theRow["ContactName"]);
			}

			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();

		}
	}
}
