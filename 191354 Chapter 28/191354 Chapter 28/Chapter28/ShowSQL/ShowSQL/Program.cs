#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace ShowSQL
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

			thisConnection.Open();

			SqlDataAdapter thisAdapter = new
			  SqlDataAdapter("SELECT CustomerID from Customers", thisConnection);

			SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

			Console.WriteLine("SQL SELECT Command is:\n{0}\n",
							  thisAdapter.SelectCommand.CommandText);

			SqlCommand updateCommand = thisBuilder.GetUpdateCommand();
			Console.WriteLine("SQL UPDATE Command is:\n{0}\n",
							  updateCommand.CommandText);

			SqlCommand insertCommand = thisBuilder.GetInsertCommand();
			Console.WriteLine("SQL INSERT Command is:\n{0}\n",
							  insertCommand.CommandText);

			SqlCommand deleteCommand = thisBuilder.GetDeleteCommand();
			Console.WriteLine("SQL DELETE Command is:\n{0}",
							  deleteCommand.CommandText);

			thisConnection.Close();

			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
