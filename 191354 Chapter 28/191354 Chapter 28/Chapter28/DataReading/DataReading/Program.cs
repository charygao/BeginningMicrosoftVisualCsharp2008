#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace


#endregion

namespace DataReading
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

			// Open connection
			thisConnection.Open();

			// Create command for this connection
			SqlCommand thisCommand = thisConnection.CreateCommand();

			// Specify SQL query for this command
			thisCommand.CommandText =
				 "SELECT CustomerID, CompanyName from Customers";

			// Execute DataReader for specified command
			SqlDataReader thisReader = thisCommand.ExecuteReader();

			// While there are rows to read
			while (thisReader.Read())
			{
				// Output ID and name columns
				Console.WriteLine("\t{0}\t{1}",
				thisReader["CustomerID"], thisReader["CompanyName"]);
			}

			// Close reader
			thisReader.Close();

			// Close connection
			thisConnection.Close();

			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();

		}
	}
}
