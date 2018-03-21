namespace LabelTextboxTest
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
            this.ctlLabelTextbox1 = new LabelTextbox.ctlLabelTextbox();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlLabelTextbox1
            // 
            this.ctlLabelTextbox1.LabelText = "Test";
            this.ctlLabelTextbox1.Location = new System.Drawing.Point(12, 12);
            this.ctlLabelTextbox1.Name = "ctlLabelTextbox1";
            this.ctlLabelTextbox1.Position = LabelTextbox.ctlLabelTextbox.PositionEnum.Below;
            this.ctlLabelTextbox1.Size = new System.Drawing.Size(213, 33);
            this.ctlLabelTextbox1.TabIndex = 0;
            this.ctlLabelTextbox1.TextboxMargin = 0;
            this.ctlLabelTextbox1.TextboxText = "Hey, what?";
            this.ctlLabelTextbox1.PositionChanged += new System.EventHandler(this.ctlLabelTextbox1_PositionChanged);
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(74, 73);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(75, 23);
            this.buttonToggle.TabIndex = 1;
            this.buttonToggle.Text = "Toggle";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.ctlLabelTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LabelTextbox.ctlLabelTextbox ctlLabelTextbox1;
        private System.Windows.Forms.Button buttonToggle;
    }
}

