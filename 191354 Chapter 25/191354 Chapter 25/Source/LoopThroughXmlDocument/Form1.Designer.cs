namespace LoopThroughXmlDocument
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
           this.listBoxXmlNodes = new System.Windows.Forms.ListBox();
           this.buttonLoopThroughDocument = new System.Windows.Forms.Button();
           this.buttonCreateNode = new System.Windows.Forms.Button();
           this.buttonDeleteNode = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // listBoxXmlNodes
           // 
           this.listBoxXmlNodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                       | System.Windows.Forms.AnchorStyles.Right)));
           this.listBoxXmlNodes.FormattingEnabled = true;
           this.listBoxXmlNodes.Location = new System.Drawing.Point(12, 12);
           this.listBoxXmlNodes.Name = "listBoxXmlNodes";
           this.listBoxXmlNodes.Size = new System.Drawing.Size(364, 225);
           this.listBoxXmlNodes.TabIndex = 0;
           // 
           // buttonLoopThroughDocument
           // 
           this.buttonLoopThroughDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.buttonLoopThroughDocument.Location = new System.Drawing.Point(383, 13);
           this.buttonLoopThroughDocument.Name = "buttonLoopThroughDocument";
           this.buttonLoopThroughDocument.Size = new System.Drawing.Size(75, 23);
           this.buttonLoopThroughDocument.TabIndex = 1;
           this.buttonLoopThroughDocument.Text = "Loop";
           this.buttonLoopThroughDocument.UseVisualStyleBackColor = true;
           this.buttonLoopThroughDocument.Click += new System.EventHandler(this.buttonLoopThroughDocument_Click);
           // 
           // buttonCreateNode
           // 
           this.buttonCreateNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.buttonCreateNode.Location = new System.Drawing.Point(383, 43);
           this.buttonCreateNode.Name = "buttonCreateNode";
           this.buttonCreateNode.Size = new System.Drawing.Size(75, 23);
           this.buttonCreateNode.TabIndex = 2;
           this.buttonCreateNode.Text = "Create Node";
           this.buttonCreateNode.UseVisualStyleBackColor = true;
           this.buttonCreateNode.Click += new System.EventHandler(this.buttonCreateNode_Click);
           // 
           // buttonDeleteNode
           // 
           this.buttonDeleteNode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
           this.buttonDeleteNode.Location = new System.Drawing.Point(383, 73);
           this.buttonDeleteNode.Name = "buttonDeleteNode";
           this.buttonDeleteNode.Size = new System.Drawing.Size(75, 23);
           this.buttonDeleteNode.TabIndex = 3;
           this.buttonDeleteNode.Text = "Delete Node";
           this.buttonDeleteNode.UseVisualStyleBackColor = true;
           this.buttonDeleteNode.Click += new System.EventHandler(this.buttonDeleteNode_Click);
           // 
           // Form1
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(466, 254);
           this.Controls.Add(this.buttonDeleteNode);
           this.Controls.Add(this.buttonCreateNode);
           this.Controls.Add(this.buttonLoopThroughDocument);
           this.Controls.Add(this.listBoxXmlNodes);
           this.Name = "Form1";
           this.Text = "XML Nodes";
           this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxXmlNodes;
        private System.Windows.Forms.Button buttonLoopThroughDocument;
        private System.Windows.Forms.Button buttonCreateNode;
        private System.Windows.Forms.Button buttonDeleteNode;
    }
}

