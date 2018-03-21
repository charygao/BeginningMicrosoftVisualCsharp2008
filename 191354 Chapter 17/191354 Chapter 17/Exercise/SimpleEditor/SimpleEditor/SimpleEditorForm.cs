using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace SimpleEditor
{
   public partial class SimpleEditorForm : Form
   {
      private string fileName = "Untitled";

      // Variables for printing
      private string[] lines;
      private int linesPrinted;
      private Brush printBrush;

      public SimpleEditorForm(string fileName)
      {
         InitializeComponent();

         if (fileName != null)
         {
            this.fileName = fileName;
            OpenFile();
         }        

      }

      private void OpenFile()
      {
         try
         {
            textBoxEdit.Clear();
            textBoxEdit.Text = File.ReadAllText(fileName);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }


      private void OnFileNew(object sender, EventArgs e)
      {
         fileName = "Untitled";
         SetFormTitle();
         textBoxEdit.Clear();

      }

      private void OnFileOpen(object sender, EventArgs e)
      {
         if (dlgOpenFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgOpenFile.FileName;
            SetFormTitle();
            OpenFile();
         }

      }

      private void SaveFile()
      {
         try
         {
            File.WriteAllText(fileName, textBoxEdit.Text);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
         }
      }

      private void OnFileSave(object sender, EventArgs e)
      {
         if (fileName == "Untitled")
         {
            OnFileSaveAs(sender, e);
         }
         else
         {
            SaveFile();
         }

      }

      private void SetFormTitle()
      {
         FileInfo fileInfo = new FileInfo(fileName);
         Text = fileInfo.Name + " - Simple Editor";
      }

      private void OnFileSaveAs(object sender, EventArgs e)
      {
         if (dlgSaveFile.ShowDialog() == DialogResult.OK)
         {
            fileName = dlgSaveFile.FileName;
            SetFormTitle();
            SaveFile();
         }

      }

      private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
      {
         int x = e.MarginBounds.Left;
         int y = e.MarginBounds.Top;

         while (linesPrinted < lines.Length)
         {
            e.Graphics.DrawString(lines[linesPrinted++],
                       this.textBoxEdit.Font, printBrush, x, y);
            y += this.textBoxEdit.Font.Height + 3;
            if (y >= e.MarginBounds.Bottom)
            {
               e.HasMorePages = true;
               return;
            }
         }

         linesPrinted = 0;
         e.HasMorePages = false;
      }

      private void OnFilePrint(object sender, EventArgs e)
      {
         try
         {
            if (textBoxEdit.SelectedText != "")
            {
               dlgPrint.AllowSelection = true;
            }

            if (dlgPrint.ShowDialog() == DialogResult.OK)
            {
               printDocument.Print();
            }
         }
         catch (InvalidPrinterException ex)
         {
            MessageBox.Show(ex.Message, "Simple Editor",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

      }

      private void OnBeginPrint(object sender, PrintEventArgs e)
      {
         char[] param = { '\n' };

         if (dlgPrint.PrinterSettings.PrintRange == PrintRange.Selection)
         {
            lines = textBoxEdit.SelectedText.Split(param);
         }
         else
         {
            lines = textBoxEdit.Text.Split(param);
         }

         int i = 0;
         char[] trimParam = { '\r' };
         foreach (string s in lines)
         {
            lines[i++] = s.TrimEnd(trimParam);
         }

         if (dlgPrint.PrinterSettings.SupportsColor)
         {
            printBrush = new SolidBrush(this.textBoxEdit.ForeColor);
         }
         else
         {
            printBrush = new SolidBrush(Color.Black);
         }
      }

      private void OnEndPrint(object sender, PrintEventArgs e)
      {
         lines = null;
         this.printBrush.Dispose();
      }

      private void OnFilePageSetup(object sender, EventArgs e)
      {
         dlgPageSetup.ShowDialog();
      }

      private void OnFilePrintPreview(object sender, EventArgs e)
      {
         dlgPrintPreview.ShowDialog();
      }

      private void OnFormatFont(object sender, EventArgs e)
      {
         if (dlgFont.ShowDialog() == DialogResult.OK)
         {
            this.textBoxEdit.Font = dlgFont.Font;
         }
      }

      private void OnFormatColor(object sender, EventArgs e)
      {
         if (dlgColor.ShowDialog() == DialogResult.OK)
         {
            this.textBoxEdit.ForeColor = this.dlgColor.Color;
         }
      }



 
   }
}
