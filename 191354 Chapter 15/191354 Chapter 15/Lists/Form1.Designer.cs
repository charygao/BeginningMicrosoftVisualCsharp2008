namespace Lists
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
         this.listBoxSelected = new System.Windows.Forms.ListBox();
         this.checkedListBoxPossibleValue = new System.Windows.Forms.CheckedListBox();
         this.buttonMove = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // listBoxSelected
         // 
         this.listBoxSelected.FormattingEnabled = true;
         this.listBoxSelected.Location = new System.Drawing.Point(317, 12);
         this.listBoxSelected.Name = "listBoxSelected";
         this.listBoxSelected.Size = new System.Drawing.Size(218, 290);
         this.listBoxSelected.TabIndex = 0;
         // 
         // checkedListBoxPossibleValue
         // 
         this.checkedListBoxPossibleValue.CheckOnClick = true;
         this.checkedListBoxPossibleValue.FormattingEnabled = true;
         this.checkedListBoxPossibleValue.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"});
         this.checkedListBoxPossibleValue.Location = new System.Drawing.Point(12, 12);
         this.checkedListBoxPossibleValue.Name = "checkedListBoxPossibleValue";
         this.checkedListBoxPossibleValue.Size = new System.Drawing.Size(218, 289);
         this.checkedListBoxPossibleValue.TabIndex = 1;
         // 
         // buttonMove
         // 
         this.buttonMove.Location = new System.Drawing.Point(236, 149);
         this.buttonMove.Name = "buttonMove";
         this.buttonMove.Size = new System.Drawing.Size(75, 23);
         this.buttonMove.TabIndex = 2;
         this.buttonMove.Text = "Move";
         this.buttonMove.UseVisualStyleBackColor = true;
         this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(549, 320);
         this.Controls.Add(this.buttonMove);
         this.Controls.Add(this.checkedListBoxPossibleValue);
         this.Controls.Add(this.listBoxSelected);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ListBox listBoxSelected;
      private System.Windows.Forms.CheckedListBox checkedListBoxPossibleValue;
      private System.Windows.Forms.Button buttonMove;
   }
}

