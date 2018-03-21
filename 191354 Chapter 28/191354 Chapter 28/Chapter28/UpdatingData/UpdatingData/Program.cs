#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace UpdatingData
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

			// Fill DataSet using query defined previously for DataAdapter
			thisAdapter.Fill(thisDataSet, "Customers");

			// Show data before change
			Console.WriteLine("name before change: {0}",
				 thisDataSet.Tables["Customers"].Rows[9]["CompanyName"]);

			// Change data in Customers table, row 9, CompanyName column
			thisDataSet.Tables["Customers"].Rows[9]["CompanyName"] = "Acme, Inc.";

			// Call Update command to mark change in table
			thisAdapter.Update(thisDataSet, "Customers");

			Console.WriteLine("name after change: {0}",
				 thisDataSet.Tables["Customers"].Rows[9]["CompanyName"]);

			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
