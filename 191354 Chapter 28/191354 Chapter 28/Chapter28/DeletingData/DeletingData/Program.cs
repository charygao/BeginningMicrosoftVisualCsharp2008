﻿#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace DeletingData
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
			// Set up keys object for defining primary key
			DataColumn[] keys = new DataColumn[1];
			keys[0] = thisDataSet.Tables["Customers"].Columns["CustomerID"];
			thisDataSet.Tables["Customers"].PrimaryKey = keys;

			DataRow findRow = thisDataSet.Tables["Customers"].Rows.Find("ZACZI");

			if (findRow != null)
			{
				Console.WriteLine("ZACZI already in Customers table");
				Console.WriteLine("Removing ZACZI  . . .");

				findRow.Delete();

				int rowsAffected = thisAdapter.Update(thisDataSet, "Customers");
                Console.WriteLine("Deleted {0} rows.", rowsAffected);

			}

			Console.WriteLine("# rows after change: {0}",
				 thisDataSet.Tables["Customers"].Rows.Count);
			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}