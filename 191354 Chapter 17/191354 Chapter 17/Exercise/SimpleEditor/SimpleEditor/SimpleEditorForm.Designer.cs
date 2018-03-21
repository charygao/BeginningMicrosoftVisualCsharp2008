namespace SimpleEditor
{
   partial class SimpleEditorForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleEditorForm));
         this.textBoxEdit = new System.Windows.Forms.TextBox();
         this.mainMenu = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
         this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
         this.printDocument = new System.Drawing.Printing.PrintDocument();
         this.dlgPageSetup = new System.Windows.Forms.PageSetupDialog();
         this.dlgPrint = new System.Windows.Forms.PrintDialog();
         this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
         this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgFont = new System.Windows.Forms.FontDialog();
         this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgColor = new System.Windows.Forms.ColorDialog();
         this.mainMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // textBoxEdit
         // 
         this.textBoxEdit.AcceptsReturn = true;
         this.textBoxEdit.AcceptsTab = true;
         this.textBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxEdit.Location = new System.Drawing.Point(0, 24);
         this.textBoxEdit.Multiline = true;
         this.textBoxEdit.Name = "textBoxEdit";
         this.textBoxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBoxEdit.Size = new System.Drawing.Size(546, 203);
         this.textBoxEdit.TabIndex = 0;
         // 
         // mainMenu
         // 
         this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
         this.mainMenu.Location = new System.Drawing.Point(0, 0);
         this.mainMenu.Name = "mainMenu";
         this.mainMenu.Size = new System.Drawing.Size(546, 24);
         this.mainMenu.TabIndex = 1;
         this.mainMenu.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.newToolStripMenuItem.Text = "&New";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.OnFileNew);
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.openToolStripMenuItem.Text = "&Open...";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.OnFileOpen);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.saveToolStripMenuItem.Text = "&Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnFileSave);
         // 
         // saveAsToolStripMenuItem
         // 
         this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.saveAsToolStripMenuItem.Text = "Save &As...";
         this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnFileSaveAs);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
         // 
         // printToolStripMenuItem
         // 
         this.printToolStripMenuItem.Name = "printToolStripMenuItem";
         this.printToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.printToolStripMenuItem.Text = "&Print...";
         this.printToolStripMenuItem.Click += new System.EventHandler(this.OnFilePrint);
         // 
         // printPreviewToolStripMenuItem
         // 
         this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
         this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.printPreviewToolStripMenuItem.Text = "Print Pre&view...";
         this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.OnFilePrintPreview);
         // 
         // pageSetupToolStripMenuItem
         // 
         this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
         this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.pageSetupToolStripMenuItem.Text = "Page Set&up...";
         this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.OnFilePageSetup);
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         // 
         // dlgOpenFile
         // 
         this.dlgOpenFile.Filter = "Text Documents (*.txt)|*.txt|Wrox Documents (*.wroxtext)|*.wroxtext|All Files|*.*" +
             "";
         // 
         // dlgSaveFile
         // 
         this.dlgSaveFile.FileName = "Untitled";
         this.dlgSaveFile.Filter = "Text Document (*.txt)|*.txt|Wrox Document (*.wroxtext)|*.wroxtext";
         this.dlgSaveFile.FilterIndex = 2;
         // 
         // printDocument
         // 
         this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.OnPrintPage);
         this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.OnEndPrint);
         this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.OnBeginPrint);
         // 
         // dlgPageSetup
         // 
         this.dlgPageSetup.Document = this.printDocument;
         this.dlgPageSetup.ShowHelp = true;
         // 
         // dlgPrint
         // 
         this.dlgPrint.Document = this.printDocument;
         this.dlgPrint.UseEXDialog = true;
         // 
         // dlgPrintPreview
         // 
         this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
         this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
         this.dlgPrintPreview.Document = this.printDocument;
         this.dlgPrintPreview.Enabled = true;
         this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
         this.dlgPrintPreview.Name = "dlgPrintPreview";
         this.dlgPrintPreview.Visible = false;
         // 
         // formatToolStripMenuItem
         // 
         this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
         this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
         this.formatToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
         this.formatToolStripMenuItem.Text = "F&ormat";
         // 
         // fontToolStripMenuItem
         // 
         this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
         this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.fontToolStripMenuItem.Text = "&Font...";
         this.fontToolStripMenuItem.Click += new System.EventHandler(this.OnFormatFont);
         // 
         // colorToolStripMenuItem
         // 
         this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
         this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.colorToolStripMenuItem.Text = "&Color...";
         this.colorToolStripMenuItem.Click += new System.EventHandler(this.OnFormatColor);
         // 
         // SimpleEditorForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(546, 227);
         this.Controls.Add(this.textBoxEdit);
         this.Controls.Add(this.mainMenu);
         this.MainMenuStrip = this.mainMenu;
         this.Name = "SimpleEditorForm";
         this.Text = "Simple Editor";
         this.mainMenu.ResumeLayout(false);
         this.mainMenu.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBoxEdit;
      private System.Windows.Forms.MenuStrip mainMenu;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private System.Windows.Forms.OpenFileDialog dlgOpenFile;
      private System.Windows.Forms.SaveFileDialog dlgSaveFile;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Drawing.Printing.PrintDocument printDocument;
      private System.Windows.Forms.PageSetupDialog dlgPageSetup;
      private System.Windows.Forms.PrintDialog dlgPrint;
      private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
      private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
      private System.Windows.Forms.FontDialog dlgFont;
      private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
      private System.Windows.Forms.ColorDialog dlgColor;
   }
}

