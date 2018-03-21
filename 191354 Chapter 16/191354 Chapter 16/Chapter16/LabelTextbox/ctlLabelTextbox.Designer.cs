namespace LabelTextbox
{
    partial class ctlLabelTextbox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTextBox = new System.Windows.Forms.Label();
            this.txtLabelText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Location = new System.Drawing.Point(3, 0);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(33, 13);
            this.lblTextBox.TabIndex = 0;
            this.lblTextBox.Text = "Label";
            // 
            // txtLabelText
            // 
            this.txtLabelText.Location = new System.Drawing.Point(11, 8);
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.Size = new System.Drawing.Size(100, 20);
            this.txtLabelText.TabIndex = 1;
            this.txtLabelText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLabelText_KeyDown);
            this.txtLabelText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLabelText_KeyUp);
            this.txtLabelText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabelText_KeyPress);
            // 
            // ctlLabelTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLabelText);
            this.Controls.Add(this.lblTextBox);
            this.Name = "ctlLabelTextbox";
            this.Load += new System.EventHandler(this.ctlLabelTextbox_Load);
            this.SizeChanged += new System.EventHandler(this.ctlLabelTextbox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.TextBox txtLabelText;
    }
}
