using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CommaValues
{
    class Program
    {
        private static List<Dictionary<string, string>> GetData(out List<string> columns)
        {
            string strLine;
            string[] strArray;
            char[] charArray = new char[] { ',' };
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            columns = new List<string>();

            try
            {
                FileStream aFile = new FileStream(@"..\..\SomeData.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);

                // Obtain the columns from the first line.

                // Split row of data into string array
                strLine = sr.ReadLine();
                strArray = strLine.Split(charArray);

                for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                {
                    columns.Add(strArray[x]);
                }

                strLine = sr.ReadLine();
                while (strLine != null)
                {
                    // Split row of data into string array
                    strArray = strLine.Split(charArray);
                    Dictionary<string, string> dataRow = new Dictionary<string, string>();

                    for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                    {
                        dataRow.Add(columns[x], strArray[x]);
                    }

                    data.Add(dataRow);

                    strLine = sr.ReadLine();
                }

                sr.Close();
                return data;
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return data;
            }
        }

        static void Main(string[] args)
        {
            List<string> columns;
            List<Dictionary<string, string>> myData = GetData(out columns);

            foreach (string column in columns)
            {
                Console.Write("{0,-20}", column);
            }
            Console.WriteLine();

            foreach (Dictionary<string, string> row in myData)
            {
                foreach (string column in columns)
                {
                    Console.Write("{0,-20}", row[column]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
