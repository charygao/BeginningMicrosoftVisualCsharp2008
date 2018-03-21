namespace XmlQueryExample
{
   partial class Form1
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
         this.buttonClose = new System.Windows.Forms.Button();
         this.radioButtonSelectRoot = new System.Windows.Forms.RadioButton();
         this.radioButtonSelectAllAuthors = new System.Windows.Forms.RadioButton();
         this.radioButtonSelectBySpecifikAuthor = new System.Windows.Forms.RadioButton();
         this.radioButtonSelectAllBooks = new System.Windows.Forms.RadioButton();
         this.radioButtonSetBookAsCurrent = new System.Windows.Forms.RadioButton();
         this.radioButtonSetBooksAsCurrent = new System.Windows.Forms.RadioButton();
         this.radioButtonSelectAllChildren = new System.Windows.Forms.RadioButton();
         this.buttonExecute = new System.Windows.Forms.Button();
         this.textBoxQuery = new System.Windows.Forms.TextBox();
         this.listBoxResult = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
         // 
         // buttonClose
         // 
         this.buttonClose.Location = new System.Drawing.Point(405, 12);
         this.buttonClose.Name = "buttonClose";
         this.buttonClose.Size = new System.Drawing.Size(75, 23);
         this.buttonClose.TabIndex = 1;
         this.buttonClose.Text = "Close";
         this.buttonClose.UseVisualStyleBackColor = true;
         this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
         // 
         // radioButtonSelectRoot
         // 
         this.radioButtonSelectRoot.AutoSize = true;
         this.radioButtonSelectRoot.Location = new System.Drawing.Point(13, 224);
         this.radioButtonSelectRoot.Name = "radioButtonSelectRoot";
         this.radioButtonSelectRoot.Size = new System.Drawing.Size(76, 17);
         this.radioButtonSelectRoot.TabIndex = 2;
         this.radioButtonSelectRoot.TabStop = true;
         this.radioButtonSelectRoot.Text = "Select root";
         this.radioButtonSelectRoot.UseVisualStyleBackColor = true;
         this.radioButtonSelectRoot.CheckedChanged += new System.EventHandler(this.radioButtonSelectRoot_CheckedChanged);
         // 
         // radioButtonSelectAllAuthors
         // 
         this.radioButtonSelectAllAuthors.AutoSize = true;
         this.radioButtonSelectAllAuthors.Location = new System.Drawing.Point(12, 247);
         this.radioButtonSelectAllAuthors.Name = "radioButtonSelectAllAuthors";
         this.radioButtonSelectAllAuthors.Size = new System.Drawing.Size(106, 17);
         this.radioButtonSelectAllAuthors.TabIndex = 3;
         this.radioButtonSelectAllAuthors.TabStop = true;
         this.radioButtonSelectAllAuthors.Text = "Select all authors";
         this.radioButtonSelectAllAuthors.UseVisualStyleBackColor = true;
         this.radioButtonSelectAllAuthors.CheckedChanged += new System.EventHandler(this.radioButtonSelectAllAuthors_CheckedChanged);
         // 
         // radioButtonSelectBySpecifikAuthor
         // 
         this.radioButtonSelectBySpecifikAuthor.AutoSize = true;
         this.radioButtonSelectBySpecifikAuthor.Location = new System.Drawing.Point(13, 272);
         this.radioButtonSelectBySpecifikAuthor.Name = "radioButtonSelectBySpecifikAuthor";
         this.radioButtonSelectBySpecifikAuthor.Size = new System.Drawing.Size(141, 17);
         this.radioButtonSelectBySpecifikAuthor.TabIndex = 4;
         this.radioButtonSelectBySpecifikAuthor.TabStop = true;
         this.radioButtonSelectBySpecifikAuthor.Text = "Select by specific author";
         this.radioButtonSelectBySpecifikAuthor.UseVisualStyleBackColor = true;
         this.radioButtonSelectBySpecifikAuthor.CheckedChanged += new System.EventHandler(this.radioButtonSelectBySpecifikAuthor_CheckedChanged);
         // 
         // radioButtonSelectAllBooks
         // 
         this.radioButtonSelectAllBooks.AutoSize = true;
         this.radioButtonSelectAllBooks.Location = new System.Drawing.Point(13, 295);
         this.radioButtonSelectAllBooks.Name = "radioButtonSelectAllBooks";
         this.radioButtonSelectAllBooks.Size = new System.Drawing.Size(100, 17);
         this.radioButtonSelectAllBooks.TabIndex = 5;
         this.radioButtonSelectAllBooks.TabStop = true;
         this.radioButtonSelectAllBooks.Text = "Select all books";
         this.radioButtonSelectAllBooks.UseVisualStyleBackColor = true;
         this.radioButtonSelectAllBooks.CheckedChanged += new System.EventHandler(this.radioButtonSelectAllBooks_CheckedChanged);
         // 
         // radioButtonSetBookAsCurrent
         // 
         this.radioButtonSetBookAsCurrent.AutoSize = true;
         this.radioButtonSetBookAsCurrent.Location = new System.Drawing.Point(170, 224);
         this.radioButtonSetBookAsCurrent.Name = "radioButtonSetBookAsCurrent";
         this.radioButtonSetBookAsCurrent.Size = new System.Drawing.Size(118, 17);
         this.radioButtonSetBookAsCurrent.TabIndex = 6;
         this.radioButtonSetBookAsCurrent.TabStop = true;
         this.radioButtonSetBookAsCurrent.Text = "Set book as current";
         this.radioButtonSetBookAsCurrent.UseVisualStyleBackColor = true;
         this.radioButtonSetBookAsCurrent.CheckedChanged += new System.EventHandler(this.radioButtonSetBookAsCurrent_CheckedChanged);
         // 
         // radioButtonSetBooksAsCurrent
         // 
         this.radioButtonSetBooksAsCurrent.AutoSize = true;
         this.radioButtonSetBooksAsCurrent.Location = new System.Drawing.Point(170, 247);
         this.radioButtonSetBooksAsCurrent.Name = "radioButtonSetBooksAsCurrent";
         this.radioButtonSetBooksAsCurrent.Size = new System.Drawing.Size(123, 17);
         this.radioButtonSetBooksAsCurrent.TabIndex = 7;
         this.radioButtonSetBooksAsCurrent.TabStop = true;
         this.radioButtonSetBooksAsCurrent.Text = "Set books as current";
         this.radioButtonSetBooksAsCurrent.UseVisualStyleBackColor = true;
         this.radioButtonSetBooksAsCurrent.CheckedChanged += new System.EventHandler(this.radioButtonSetBooksAsCurrent_CheckedChanged);
         // 
         // radioButtonSelectAllChildren
         // 
         this.radioButtonSelectAllChildren.AutoSize = true;
         this.radioButtonSelectAllChildren.Location = new System.Drawing.Point(170, 272);
         this.radioButtonSelectAllChildren.Name = "radioButtonSelectAllChildren";
         this.radioButtonSelectAllChildren.Size = new System.Drawing.Size(108, 17);
         this.radioButtonSelectAllChildren.TabIndex = 8;
         this.radioButtonSelectAllChildren.TabStop = true;
         this.radioButtonSelectAllChildren.Text = "Select all children";
         this.radioButtonSelectAllChildren.UseVisualStyleBackColor = true;
         this.radioButtonSelectAllChildren.CheckedChanged += new System.EventHandler(this.radioButtonSelectAllChildren_CheckedChanged);
         // 
         // buttonExecute
         // 
         this.buttonExecute.Location = new System.Drawing.Point(323, 224);
         this.buttonExecute.Name = "buttonExecute";
         this.buttonExecute.Size = new System.Drawing.Size(75, 23);
         this.buttonExecute.TabIndex = 9;
         this.buttonExecute.Text = "Execute";
         this.buttonExecute.UseVisualStyleBackColor = true;
         this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
         // 
         // textBoxQuery
         // 
         this.textBoxQuery.Location = new System.Drawing.Point(13, 319);
         this.textBoxQuery.Name = "textBoxQuery";
         this.textBoxQuery.Size = new System.Drawing.Size(385, 20);
         this.textBoxQuery.TabIndex = 10;
         // 
         // listBoxResult
         // 
         this.listBoxResult.FormattingEnabled = true;
         this.listBoxResult.Location = new System.Drawing.Point(12, 12);
         this.listBoxResult.Name = "listBoxResult";
         this.listBoxResult.Size = new System.Drawing.Size(386, 199);
         this.listBoxResult.TabIndex = 11;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(488, 352);
         this.Controls.Add(this.listBoxResult);
         this.Controls.Add(this.textBoxQuery);
         this.Controls.Add(this.buttonExecute);
         this.Controls.Add(this.radioButtonSelectAllChildren);
         this.Controls.Add(this.radioButtonSetBooksAsCurrent);
         this.Controls.Add(this.radioButtonSetBookAsCurrent);
         this.Controls.Add(this.radioButtonSelectAllBooks);
         this.Controls.Add(this.radioButtonSelectBySpecifikAuthor);
         this.Controls.Add(this.radioButtonSelectAllAuthors);
         this.Controls.Add(this.radioButtonSelectRoot);
         this.Controls.Add(this.buttonClose);
         this.Name = "Form1";
         this.Text = "XPath Queries";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button buttonClose;
      private System.Windows.Forms.RadioButton radioButtonSelectRoot;
      private System.Windows.Forms.RadioButton radioButtonSelectAllAuthors;
      private System.Windows.Forms.RadioButton radioButtonSelectBySpecifikAuthor;
      private System.Windows.Forms.RadioButton radioButtonSelectAllBooks;
      private System.Windows.Forms.RadioButton radioButtonSetBookAsCurrent;
      private System.Windows.Forms.RadioButton radioButtonSetBooksAsCurrent;
      private System.Windows.Forms.RadioButton radioButtonSelectAllChildren;
      private System.Windows.Forms.Button buttonExecute;
      private System.Windows.Forms.TextBox textBoxQuery;
      private System.Windows.Forms.ListBox listBoxResult;
   }
}

