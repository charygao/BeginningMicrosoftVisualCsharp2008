using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XmlQueryExample
{
   public partial class Form1 : Form
   {
      private XmlDocument mDocument;
      private XmlNode mCurrentNode;

      public Form1()
      {
         InitializeComponent();

         mDocument = new XmlDocument();
         mDocument.Load(@"C:\Beginning Visual C#\Chapter 25\XPathQuery.xml");
         mCurrentNode = mDocument.DocumentElement;
         ClearListBox();
      }

      private void DisplayList(XmlNodeList nodeList)
      {
         foreach (XmlNode node in nodeList)
         {
            RecurseXmlDocumentNoSiblings(node, 0);
         }
      }

      private void RecurseXmlDocumentNoSiblings(XmlNode root, int indent)
      {
         // Make sure we don't do anything if the root is null.
         if (root == null)
            return;

         if (root is XmlElement) // Root is an XmlElement type
         {
            // First, print the name.
            listBoxResult.Items.Add(root.Name.PadLeft(root.Name.Length + indent));

            // Then check if there are any child nodes and if there are, call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);
         }
         else if (root is XmlText)
         {
            // Print the text.
            string text = ((XmlText)root).Value;
            listBoxResult.Items.Add(text.PadLeft(text.Length + indent));
         }
         else if (root is XmlComment)
         {
            // Print text.
            string text = root.Value;
            listBoxResult.Items.Add(text.PadLeft(text.Length + indent));

            // Then check if there are any child nodes and if there are, call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);
         }
      }

      private void RecurseXmlDocument(XmlNode root, int indent)
      {
         // Make sure we don't do anything if the root is null.
         if (root == null)
            return;

         if (root is XmlElement) // Root is an XmlElement type.
         {
            // First, print the name.
            listBoxResult.Items.Add(root.Name.PadLeft(root.Name.Length + indent));

            // Then check if there are any child nodes and if there are, call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);

            // Finally check to see if there are any siblings, and if there are
            // call this method again to have them printed.
            if (root.NextSibling != null)
               RecurseXmlDocument(root.NextSibling, indent);
         }
         else if (root is XmlText)
         {
            // Print the text.
            string text = ((XmlText)root).Value;
            listBoxResult.Items.Add(text.PadLeft(text.Length + indent));
         }
         else if (root is XmlComment)
         {
            // Print text.
            string text = root.Value;
            listBoxResult.Items.Add(text.PadLeft(text.Length + indent));

            // Then check if there are any child nodes. and if there are call this
            // method again to print them.
            if (root.HasChildNodes)
               RecurseXmlDocument(root.FirstChild, indent + 2);

            // Finally, check to see if there are any siblings, and if there are
            // call this method again to have them printed.
            if (root.NextSibling != null)
               RecurseXmlDocument(root.NextSibling, indent);
         }
      }

      private void ClearListBox()
      {
         listBoxResult.Items.Clear();
      }

      private void buttonClose_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void radioButtonSelectRoot_CheckedChanged(object sender, EventArgs e)
      {
         mCurrentNode = mDocument.DocumentElement.SelectSingleNode("//books");
         ClearListBox();
         RecurseXmlDocument(mCurrentNode, 0);
      }

      private void radioButtonSelectAllAuthors_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            XmlNodeList nodeList = mCurrentNode.SelectNodes("//book/author");
            ClearListBox();
            DisplayList(nodeList);
         }
         else
            ClearListBox();
      }

      private void radioButtonSelectBySpecifikAuthor_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            XmlNodeList nodeList = mCurrentNode.SelectNodes("//book[author='Jacob Hammer Pedersen']");
            ClearListBox();
            DisplayList(nodeList);
         }
         else
            ClearListBox();
      }

      private void radioButtonSelectAllBooks_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            XmlNodeList nodeList = mCurrentNode.SelectNodes("//book");
            ClearListBox();
            DisplayList(nodeList);
         }
         else
            ClearListBox();
      }

      private void radioButtonSetBookAsCurrent_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            mCurrentNode = mCurrentNode.SelectSingleNode("book[title='Beginning Visual C#']");
            ClearListBox();
            RecurseXmlDocumentNoSiblings(mCurrentNode, 0);
         }
         else
            ClearListBox();
      }

      private void radioButtonSetBooksAsCurrent_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            mCurrentNode = mCurrentNode.SelectSingleNode("//books");
            ClearListBox();
            RecurseXmlDocumentNoSiblings(mCurrentNode, 0);
         }
         else
            ClearListBox();
      }

      private void radioButtonSelectAllChildren_CheckedChanged(object sender, EventArgs e)
      {
         if (mCurrentNode != null)
         {
            XmlNodeList nodeList = mCurrentNode.SelectNodes("*");
            ClearListBox();
            DisplayList(nodeList);
         }
         else
            ClearListBox();
      }

      private void buttonExecute_Click(object sender, EventArgs e)
      {
         if (textBoxQuery.Text == "")
            return;

         try
         {
            XmlNodeList nodeList = mCurrentNode.SelectNodes(textBoxQuery.Text);
            ClearListBox();
            DisplayList(nodeList);
         }
         catch (System.Exception err)
         {
            MessageBox.Show(err.Message);
         }
      }

      private void buttonClose_Click_1(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
