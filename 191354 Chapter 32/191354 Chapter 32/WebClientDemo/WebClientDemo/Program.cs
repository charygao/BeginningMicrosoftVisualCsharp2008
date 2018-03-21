using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebClientDemo
{
   class Program
   {
      static void Main()
      {
         WebClient client = new WebClient();
         client.BaseAddress = "http://www.microsoft.com";
         string data = client.DownloadString("Office");
         Console.WriteLine(data);

      }
   }
}
