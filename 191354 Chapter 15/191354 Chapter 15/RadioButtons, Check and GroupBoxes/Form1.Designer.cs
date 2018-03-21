namespace TextBoxTest
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
         this.labelName = new System.Windows.Forms.Label();
         this.textBoxName = new System.Windows.Forms.TextBox();
         this.buttonOK = new System.Windows.Forms.Button();
         this.textBoxAddress = new System.Windows.Forms.TextBox();
         this.labelAddress = new System.Windows.Forms.Label();
         this.buttonHelp = new System.Windows.Forms.Button();
         this.labelAge = new System.Windows.Forms.Label();
         this.textBoxAge = new System.Windows.Forms.TextBox();
         this.labelOutput = new System.Windows.Forms.Label();
         this.textBoxOutput = new System.Windows.Forms.TextBox();
         this.checkBoxProgrammer = new System.Windows.Forms.CheckBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.radioButtonMale = new System.Windows.Forms.RadioButton();
         this.radioButtonFemale = new System.Windows.Forms.RadioButton();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // labelName
         // 
         this.labelName.AutoSize = true;
         this.labelName.Location = new System.Drawing.Point(12, 9);
         this.labelName.Name = "labelName";
         this.labelName.Size = new System.Drawing.Size(35, 13);
         this.labelName.TabIndex = 0;
         this.labelName.Text = "Name";
         // 
         // textBoxName
         // 
         this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxName.Location = new System.Drawing.Point(98, 6);
         this.textBoxName.Name = "textBoxName";
         this.textBoxName.Size = new System.Drawing.Size(277, 20);
         this.textBoxName.TabIndex = 1;
         this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
         // 
         // buttonOK
         // 
         this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonOK.Location = new System.Drawing.Point(381, 4);
         this.buttonOK.Name = "buttonOK";
         this.buttonOK.Size = new System.Drawing.Size(75, 23);
         this.buttonOK.TabIndex = 2;
         this.buttonOK.Text = "OK";
         this.buttonOK.UseVisualStyleBackColor = true;
         this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
         // 
         // textBoxAddress
         // 
         this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxAddress.Location = new System.Drawing.Point(98, 32);
         this.textBoxAddress.Multiline = true;
         this.textBoxAddress.Name = "textBoxAddress";
         this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBoxAddress.Size = new System.Drawing.Size(277, 100);
         this.textBoxAddress.TabIndex = 3;
         this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
         // 
         // labelAddress
         // 
         this.labelAddress.AutoSize = true;
         this.labelAddress.Location = new System.Drawing.Point(12, 35);
         this.labelAddress.Name = "labelAddress";
         this.labelAddress.Size = new System.Drawing.Size(45, 13);
         this.labelAddress.TabIndex = 4;
         this.labelAddress.Text = "Address";
         // 
         // buttonHelp
         // 
         this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.buttonHelp.CausesValidation = false;
         this.buttonHelp.Location = new System.Drawing.Point(381, 30);
         this.buttonHelp.Name = "buttonHelp";
         this.buttonHelp.Size = new System.Drawing.Size(75, 23);
         this.buttonHelp.TabIndex = 5;
         this.buttonHelp.Text = "Help";
         this.buttonHelp.UseVisualStyleBackColor = true;
         this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
         // 
         // labelAge
         // 
         this.labelAge.AutoSize = true;
         this.labelAge.Location = new System.Drawing.Point(12, 255);
         this.labelAge.Name = "labelAge";
         this.labelAge.Size = new System.Drawing.Size(26, 13);
         this.labelAge.TabIndex = 8;
         this.labelAge.Text = "Age";
         // 
         // textBoxAge
         // 
         this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxAge.Location = new System.Drawing.Point(98, 252);
         this.textBoxAge.MaxLength = 3;
         this.textBoxAge.Name = "textBoxAge";
         this.textBoxAge.Size = new System.Drawing.Size(277, 20);
         this.textBoxAge.TabIndex = 9;
         this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
         this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
         // 
         // labelOutput
         // 
         this.labelOutput.AutoSize = true;
         this.labelOutput.Location = new System.Drawing.Point(12, 271);
         this.labelOutput.Name = "labelOutput";
         this.labelOutput.Size = new System.Drawing.Size(39, 13);
         this.labelOutput.TabIndex = 10;
         this.labelOutput.Text = "Output";
         // 
         // textBoxOutput
         // 
         this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                     | System.Windows.Forms.AnchorStyles.Left)
                     | System.Windows.Forms.AnchorStyles.Right)));
         this.textBoxOutput.Location = new System.Drawing.Point(15, 287);
         this.textBoxOutput.Multiline = true;
         this.textBoxOutput.Name = "textBoxOutput";
         this.textBoxOutput.ReadOnly = true;
         this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.textBoxOutput.Size = new System.Drawing.Size(360, 168);
         this.textBoxOutput.TabIndex = 11;
         // 
         // checkBoxProgrammer
         // 
         this.checkBoxProgrammer.AutoSize = true;
         this.checkBoxProgrammer.Checked = true;
         this.checkBoxProgrammer.CheckState = System.Windows.Forms.CheckState.Checked;
         this.checkBoxProgrammer.Location = new System.Drawing.Point(15, 138);
         this.checkBoxProgrammer.Name = "checkBoxProgrammer";
         this.checkBoxProgrammer.Size = new System.Drawing.Size(88, 17);
         this.checkBoxProgrammer.TabIndex = 12;
         this.checkBoxProgrammer.Text = "Programmer?";
         this.checkBoxProgrammer.UseVisualStyleBackColor = true;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButtonMale);
         this.groupBox1.Controls.Add(this.radioButtonFemale);
         this.groupBox1.Location = new System.Drawing.Point(15, 161);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(360, 85);
         this.groupBox1.TabIndex = 13;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Sex";
         // 
         // radioButtonMale
         // 
         this.radioButtonMale.AutoSize = true;
         this.radioButtonMale.Checked = true;
         this.radioButtonMale.Location = new System.Drawing.Point(187, 33);
         this.radioButtonMale.Name = "radioButtonMale";
         this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
         this.radioButtonMale.TabIndex = 1;
         this.radioButtonMale.TabStop = true;
         this.radioButtonMale.Text = "Male";
         this.radioButtonMale.UseVisualStyleBackColor = true;
         // 
         // radioButtonFemale
         // 
         this.radioButtonFemale.AutoSize = true;
         this.radioButtonFemale.Location = new System.Drawing.Point(58, 33);
         this.radioButtonFemale.Name = "radioButtonFemale";
         this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
         this.radioButtonFemale.TabIndex = 0;
         this.radioButtonFemale.Text = "Female";
         this.radioButtonFemale.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(468, 466);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.checkBoxProgrammer);
         this.Controls.Add(this.textBoxOutput);
         this.Controls.Add(this.labelOutput);
         this.Controls.Add(this.textBoxAge);
         this.Controls.Add(this.labelAge);
         this.Controls.Add(this.buttonHelp);
         this.Controls.Add(this.labelAddress);
         this.Controls.Add(this.textBoxAddress);
         this.Controls.Add(this.buttonOK);
         this.Controls.Add(this.textBoxName);
         this.Controls.Add(this.labelName);
         this.MinimumSize = new System.Drawing.Size(484, 370);
         this.Name = "Form1";
         this.Text = "Form1";
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label labelName;
      private System.Windows.Forms.TextBox textBoxName;
      private System.Windows.Forms.Button buttonOK;
      private System.Windows.Forms.TextBox textBoxAddress;
      private System.Windows.Forms.Label labelAddress;
      private System.Windows.Forms.Button buttonHelp;
      private System.Windows.Forms.Label labelAge;
      private System.Windows.Forms.TextBox textBoxAge;
      private System.Windows.Forms.Label labelOutput;
      private System.Windows.Forms.TextBox textBoxOutput;
      private System.Windows.Forms.CheckBox checkBoxProgrammer;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.RadioButton radioButtonFemale;
      private System.Windows.Forms.RadioButton radioButtonMale;
   }
}

