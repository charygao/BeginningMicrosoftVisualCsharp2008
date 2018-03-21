#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace AddingData
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

			Console.WriteLine("# rows before change: {0}",
							   thisDataSet.Tables["Customers"].Rows.Count);

			DataRow thisRow = thisDataSet.Tables["Customers"].NewRow();
			thisRow["CustomerID"] = "ZACZI";
			thisRow["CompanyName"] = "Zachary Zithers Ltd.";
			thisDataSet.Tables["Customers"].Rows.Add(thisRow);

			Console.WriteLine("# rows after change: {0}",
							  thisDataSet.Tables["Customers"].Rows.Count);

			// Call Update command to mark change in table
			thisAdapter.Update(thisDataSet, "Customers");

			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
