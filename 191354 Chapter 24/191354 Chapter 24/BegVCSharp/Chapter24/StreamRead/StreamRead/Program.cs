using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string strLine;

            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                strLine = sr.ReadLine();
                // Read data in line by line.
                while (strLine != null)
                {
                    Console.WriteLine(strLine);
                    strLine = sr.ReadLine();
                }
                sr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(e.ToString());
                return;
            }
            Console.ReadKey();
        }
    }
}
