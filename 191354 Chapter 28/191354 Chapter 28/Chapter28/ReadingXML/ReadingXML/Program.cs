#region Using directives

using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ReadingXML
{
	class Program
	{
		static void Main(string[] args)
		{
			DataSet thisDataSet = new DataSet();
			thisDataSet.ReadXml(@"c:\northwind\nwinddata.xml");

			foreach (DataRow custRow in thisDataSet.Tables["Customers"].Rows)
			{
				Console.WriteLine("Customer ID: " + custRow["CustomerID"] +
								  " Name: " + custRow["CompanyName"]);
			}

			Console.WriteLine("Table created by ReadXml is called {0}",
							   thisDataSet.Tables[0].TableName);
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
