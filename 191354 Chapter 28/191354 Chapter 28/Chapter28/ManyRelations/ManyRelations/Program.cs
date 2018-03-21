#region Using directives

using System;
using System.Data;            // Use ADO.NET namespace
using System.Data.SqlClient;  // Use SQL Server data provider namespace
using System.Collections.Generic;
using System.Text;

#endregion

namespace ManyRelations
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

			DataSet thisDataSet = new DataSet();
			SqlDataAdapter custAdapter = new SqlDataAdapter(
				 "SELECT * FROM Customers", thisConnection);
			custAdapter.Fill(thisDataSet, "Customers");

			SqlDataAdapter orderAdapter = new SqlDataAdapter(
				 "SELECT * FROM Orders", thisConnection);
			orderAdapter.Fill(thisDataSet, "Orders");

			SqlDataAdapter detailAdapter = new SqlDataAdapter(
				 "SELECT * FROM [Order Details]", thisConnection);
			detailAdapter.Fill(thisDataSet, "Order Details");

			SqlDataAdapter prodAdapter = new SqlDataAdapter(
				 "SELECT * FROM Products", thisConnection);
			prodAdapter.Fill(thisDataSet, "Products");

			DataRelation custOrderRel = thisDataSet.Relations.Add("CustOrders",
						thisDataSet.Tables["Customers"].Columns["CustomerID"],
						thisDataSet.Tables["Orders"].Columns["CustomerID"]);

			DataRelation orderDetailRel = thisDataSet.Relations.Add("OrderDetail",
						thisDataSet.Tables["Orders"].Columns["OrderID"],
						thisDataSet.Tables["Order Details"].Columns["OrderID"]);

			DataRelation orderProductRel = thisDataSet.Relations.Add(
			  "OrderProducts", thisDataSet.Tables["Products"].Columns["ProductID"],
			   thisDataSet.Tables["Order Details"].Columns["ProductID"]);

			foreach (DataRow custRow in thisDataSet.Tables["Customers"].Rows)
			{
				Console.WriteLine("Customer ID: " + custRow["CustomerID"]);

				foreach (DataRow orderRow in custRow.GetChildRows(custOrderRel))
				{
					Console.WriteLine("\tOrder ID: " + orderRow["OrderID"]);
					Console.WriteLine("\t\tOrder Date: " + orderRow["OrderDate"]);

					foreach (DataRow detailRow in
							 orderRow.GetChildRows(orderDetailRel))
					{
						Console.WriteLine("\t\tProduct: " +
						detailRow.GetParentRow(orderProductRel)["ProductName"]);
						Console.WriteLine("\t\tQuantity: " + detailRow["Quantity"]);
					}
				}
			}
			thisConnection.Close();
			Console.Write("Program finished, press Enter/Return to continue:");
			Console.ReadLine();
		}
	}
}
