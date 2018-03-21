namespace ColorConverter
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
      this.tbRed = new System.Windows.Forms.TextBox();
      this.tbGreen = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.tbBlue = new System.Windows.Forms.TextBox();
      this.tbHue = new System.Windows.Forms.TextBox();
      this.tbSat = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.tbBright = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
// 
// tbRed
// 
      this.tbRed.Location = new System.Drawing.Point(45, 10);
      this.tbRed.Name = "tbRed";
      this.tbRed.Size = new System.Drawing.Size(47, 20);
      this.tbRed.TabIndex = 1;
      this.tbRed.TextChanged += new System.EventHandler(this.tbRed_TextChanged);
// 
// tbGreen
// 
      this.tbGreen.Location = new System.Drawing.Point(149, 10);
      this.tbGreen.Name = "tbGreen";
      this.tbGreen.Size = new System.Drawing.Size(47, 20);
      this.tbGreen.TabIndex = 2;
      this.tbGreen.TextChanged += new System.EventHandler(this.tbGreen_TextChanged);
// 
// label1
// 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(25, 14);
      this.label1.TabIndex = 8;
      this.label1.Text = "Red";
// 
// label2
// 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(106, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 14);
      this.label2.TabIndex = 9;
      this.label2.Text = "Green";
// 
// label3
// 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(212, 13);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 14);
      this.label3.TabIndex = 10;
      this.label3.Text = "Blue";
// 
// tbBlue
// 
      this.tbBlue.Location = new System.Drawing.Point(246, 10);
      this.tbBlue.Name = "tbBlue";
      this.tbBlue.Size = new System.Drawing.Size(47, 20);
      this.tbBlue.TabIndex = 3;
      this.tbBlue.TextChanged += new System.EventHandler(this.tbBlue_TextChanged);
// 
// tbHue
// 
      this.tbHue.Location = new System.Drawing.Point(45, 44);
      this.tbHue.Name = "tbHue";
      this.tbHue.ReadOnly = true;
      this.tbHue.Size = new System.Drawing.Size(47, 20);
      this.tbHue.TabIndex = 4;
// 
// tbSat
// 
      this.tbSat.Location = new System.Drawing.Point(149, 44);
      this.tbSat.Name = "tbSat";
      this.tbSat.ReadOnly = true;
      this.tbSat.Size = new System.Drawing.Size(47, 20);
      this.tbSat.TabIndex = 5;
// 
// label4
// 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 47);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(25, 14);
      this.label4.TabIndex = 11;
      this.label4.Text = "Hue";
// 
// label5
// 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(121, 45);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(21, 14);
      this.label5.TabIndex = 12;
      this.label5.Text = "Sat";
// 
// label6
// 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(205, 47);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(34, 14);
      this.label6.TabIndex = 13;
      this.label6.Text = "Bright";
// 
// tbBright
// 
      this.tbBright.Location = new System.Drawing.Point(246, 42);
      this.tbBright.Name = "tbBright";
      this.tbBright.ReadOnly = true;
      this.tbBright.Size = new System.Drawing.Size(47, 20);
      this.tbBright.TabIndex = 6;
// 
// Form1
// 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(431, 217);
      this.Controls.Add(this.tbBright);
      this.Controls.Add(this.tbBlue);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbSat);
      this.Controls.Add(this.tbHue);
      this.Controls.Add(this.tbGreen);
      this.Controls.Add(this.tbRed);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tbRed;
    private System.Windows.Forms.TextBox tbGreen;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tbBlue;
    private System.Windows.Forms.TextBox tbHue;
    private System.Windows.Forms.TextBox tbSat;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox tbBright;
  }
}

