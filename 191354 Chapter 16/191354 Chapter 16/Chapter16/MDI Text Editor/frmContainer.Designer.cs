namespace Manual_Menus
{
    partial class frmContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemNewExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCascasde = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItemWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ToolStripMenuItemWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemOpen,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemNewExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItemNew.MergeIndex = 0;
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemNew.Text = "&New";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // ToolStripMenuItemOpen
            // 
            this.ToolStripMenuItemOpen.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItemOpen.MergeIndex = 1;
            this.ToolStripMenuItemOpen.Name = "ToolStripMenuItemOpen";
            this.ToolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItemOpen.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemOpen.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripMenuItem1.MergeIndex = 10;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripMenuItemNewExit
            // 
            this.ToolStripMenuItemNewExit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItemNewExit.MergeIndex = 11;
            this.ToolStripMenuItemNewExit.Name = "ToolStripMenuItemNewExit";
            this.ToolStripMenuItemNewExit.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemNewExit.Text = "E&xit";
            // 
            // ToolStripMenuItemWindow
            // 
            this.ToolStripMenuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTile,
            this.ToolStripMenuItemCascasde});
            this.ToolStripMenuItemWindow.Name = "ToolStripMenuItemWindow";
            this.ToolStripMenuItemWindow.Size = new System.Drawing.Size(63, 20);
            this.ToolStripMenuItemWindow.Text = "&Window";
            // 
            // ToolStripMenuItemTile
            // 
            this.ToolStripMenuItemTile.Name = "ToolStripMenuItemTile";
            this.ToolStripMenuItemTile.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemTile.Text = "&Tile";
            this.ToolStripMenuItemTile.Click += new System.EventHandler(this.ToolStripMenuItemTile_Click);
            // 
            // ToolStripMenuItemCascasde
            // 
            this.ToolStripMenuItemCascasde.Name = "ToolStripMenuItemCascasde";
            this.ToolStripMenuItemCascasde.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCascasde.Text = "&Cascade";
            this.ToolStripMenuItemCascasde.Click += new System.EventHandler(this.ToolStripMenuItemCascasde_Click);
            // 
            // frmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmContainer";
            this.Text = "Simple Text Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCascasde;
    }
}