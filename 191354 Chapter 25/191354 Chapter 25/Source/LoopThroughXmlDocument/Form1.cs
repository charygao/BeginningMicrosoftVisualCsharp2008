using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LoopThroughXmlDocument
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void buttonLoopThroughDocument_Click(object sender, EventArgs e)
      {
         // Clear ListBox
         listBoxXmlNodes.Items.Clear();

         // Load the XML document
         XmlDocument document = new XmlDocument();
         document.Load(@"C:\Beginning Visual C#\Chapter 25\Books.xml");

         // Use recursion to loop through the document.
         RecurseXmlDocument((XmlNode)document.DocumentElement, 0);
      }

      private void RecurseXmlDocument(XmlNode root, int indent)
      {
         // Make sure we don't do anything if the root is null.
         if (root == null)
            return;

         if (root is XmlElement) // Root is an XmlElement type
         {
            // first, print the name
            listBoxXmlNodes.Items.Add(root.Name.PadLeft(root.Name.Length + indent));

            // Then check if there are any child nodes and if there are, call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);

            // Finally check to see if there are any siblings and if there are
            // call this method again to have them printed.
            if (root.NextSibling != null)
               RecurseXmlDocument(root.NextSibling, indent);
         }
         else if (root is XmlText)
         {
            // Print the text.
            string text = ((XmlText)root).Value;
            listBoxXmlNodes.Items.Add(text.PadLeft(text.Length + indent));
         }
         else if (root is XmlComment)
         {
            // Print text.
            string text = root.Value;
            listBoxXmlNodes.Items.Add(text.PadLeft(text.Length + indent));

            // Then check if there are any child nodes, and if there are call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);

            // Finally, check to see if there are any siblings, and if there are
            // call this method again to have them printed.
            if (root.NextSibling != null)
               RecurseXmlDocument(root.NextSibling, indent);
         }
      }

      private void buttonCreateNode_Click(object sender, EventArgs e)
      {
         // Load the XML document.
         XmlDocument document = new XmlDocument();
         document.Load(@"C:\Beginning Visual C#\Chapter 25\Books.xml");

         // Get the root element.
         XmlElement root = document.DocumentElement;

         // Create the new nodes.
         XmlElement newBook = document.CreateElement("book");
         XmlElement newTitle = document.CreateElement("title");
         XmlElement newAuthor = document.CreateElement("author");
         XmlElement newCode = document.CreateElement("code");
         XmlText title = document.CreateTextNode("Beginning Visual C# 2008");
         XmlText author = document.CreateTextNode("Karli Watson et al");
         XmlText code = document.CreateTextNode("1234567890");
         XmlComment comment = document.CreateComment("This is the book you are reading");

         // Insert the elements.
         newBook.AppendChild(comment);
         newBook.AppendChild(newTitle);
         newBook.AppendChild(newAuthor);
         newBook.AppendChild(newCode);
         newTitle.AppendChild(title);
         newAuthor.AppendChild(author);
         newCode.AppendChild(code);
         root.InsertAfter(newBook, root.FirstChild);

         document.Save(@"C:\Beginning Visual C#\Chapter 25\Books.xml");

      }

      private void buttonDeleteNode_Click(object sender, EventArgs e)
      {
         // Load the XML document.
         XmlDocument document = new XmlDocument();
         document.Load(@"C:\Beginning Visual C#\Chapter 25\Books.xml");

         // Get the root element.
         XmlElement root = document.DocumentElement;

         // Find the node. root is the <books> tag, so its last child 
         // which will be the last <book> node.
         if (root.HasChildNodes)
         {
            XmlNode book = root.LastChild;

            // Delete the child.
            root.RemoveChild(book);

            // Save the document back to disk.
            document.Save(@"C:\Beginning Visual C#\Chapter 25\Books.xml");
         }
      }
   }
}
