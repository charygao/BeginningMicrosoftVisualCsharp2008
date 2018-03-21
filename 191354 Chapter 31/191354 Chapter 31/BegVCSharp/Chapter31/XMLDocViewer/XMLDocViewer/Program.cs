using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XMLDocViewer
{
   class Program
   {
      static void Main(string[] args)
      {
         // Load XML documentation file
         XmlDocument documentation = new XmlDocument();
         documentation.Load(@"..\..\..\..\DocumentedClasses"
            + @"\DocumentedClasses\bin\debug\DocumentedClasses.xml");

         // Get <member> elements.
         XmlNodeList memberNodes = documentation.SelectNodes("//member");

         // Extract <member> elements for types.
         List<XmlNode> typeNodes = new List<XmlNode>();
         foreach (XmlNode node in memberNodes)
         {
            if (node.Attributes["name"].Value.StartsWith("T"))
            {
               typeNodes.Add(node);
            }
         }

         // Write types to the console.
         Console.WriteLine("Types:");
         foreach (XmlNode node in typeNodes)
         {
            Console.WriteLine("- {0}", node.Attributes["name"].Value.Substring(2));
         }

         Console.ReadKey();
      }
   }
}
