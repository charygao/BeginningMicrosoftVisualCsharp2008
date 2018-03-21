#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.OleDb;      // Use namespace for OLE DB .NET Data Provider
using System.Collections.Generic;
using System.Text;

#endregion

namespace ReadingAccessData
{
	class Program
	{
		static void Main(string[] args)
		{
      // Create connection object for Microsoft Access OLE DB Provider;
      // note @ sign prefacing string literal so backslashes in path name;
      // work
      OleDbConnection thisConnection = new OleDbConnection(
           @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\northwind\nwind.mdb");

      // Open connection object
      thisConnection.Open();

      // Create SQL command object on this connection 
      OleDbCommand thisCommand = thisConnection.CreateCommand();

      // Initialize SQL SELECT command to retrieve desired data
      thisCommand.CommandText = 
           "SELECT CustomerID, CompanyName FROM Customers";

      // Create a DataReader object based on previously defined command object
      OleDbDataReader thisReader = thisCommand.ExecuteReader();

      while (thisReader.Read())
      {
         Console.WriteLine("\t{0}\t{1}",
         thisReader["CustomerID"], thisReader["CompanyName"]);
      }
      thisReader.Close();
      thisConnection.Close();


	  Console.Write("Program finished, press Enter/Return to continue:");
	  Console.ReadLine();
	 }	

	}
}
