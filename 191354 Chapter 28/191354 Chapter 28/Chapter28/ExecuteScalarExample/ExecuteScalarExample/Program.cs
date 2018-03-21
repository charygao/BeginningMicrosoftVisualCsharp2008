#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace ExecuteScalarExample
{
	class Program
	{
		static void Main(string[] args)
		{
			SqlConnection thisConnection = new
            SqlConnection(
                @"Data Source=.\SQLEXPRESS;" +
                @"AttachDbFilename='C:\SQL Server 2000 Sample Databases\NORTHWND.MDF';" +
                @"Integrated Security=True;Connect Timeout=30;User Instance=true");

			thisConnection.Open();
			SqlCommand thisCommand = thisConnection.CreateCommand();
			thisCommand.CommandText = "SELECT COUNT(*) FROM Customers";
			Object countResult = thisCommand.ExecuteScalar();
			Console.WriteLine("Count of Customers = {0}", countResult);

			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
