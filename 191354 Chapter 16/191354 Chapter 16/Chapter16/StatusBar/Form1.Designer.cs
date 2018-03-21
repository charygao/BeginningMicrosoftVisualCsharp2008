namespace Manual_Menus
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
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
          this.menuStrip1 = new System.Windows.Forms.MenuStrip();
          this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.MenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
          this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
          this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
          this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
          this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
          this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.ToolStripMenuItemBold = new System.Windows.Forms.ToolStripMenuItem();
          this.ToolStripMenuItemItalic = new System.Windows.Forms.ToolStripMenuItem();
          this.ToolStripMenuItemUnderline = new System.Windows.Forms.ToolStripMenuItem();
          this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
          this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
          this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
          this.richTextBoxText = new System.Windows.Forms.RichTextBox();
          this.toolStrip1 = new System.Windows.Forms.ToolStrip();
          this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
          this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
          this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
          this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
          this.ToolStripButtonBold = new System.Windows.Forms.ToolStripButton();
          this.ToolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
          this.ToolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
          this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
          this.ToolStripComboBoxFonts = new System.Windows.Forms.ToolStripComboBox();
          this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
          this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
          this.statusStrip1 = new System.Windows.Forms.StatusStrip();
          this.toolStripStatusLabelText = new System.Windows.Forms.ToolStripStatusLabel();
          this.toolStripStatusLabelBold = new System.Windows.Forms.ToolStripStatusLabel();
          this.toolStripStatusLabelItalic = new System.Windows.Forms.ToolStripStatusLabel();
          this.toolStripStatusLabelUnderline = new System.Windows.Forms.ToolStripStatusLabel();
          this.menuStrip1.SuspendLayout();
          this.toolStrip1.SuspendLayout();
          this.statusStrip1.SuspendLayout();
          this.SuspendLayout();
          // 
          // menuStrip1
          // 
          this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.MenuItemHelp});
          this.menuStrip1.Location = new System.Drawing.Point(0, 0);
          this.menuStrip1.Name = "menuStrip1";
          this.menuStrip1.Size = new System.Drawing.Size(454, 24);
          this.menuStrip1.TabIndex = 0;
          this.menuStrip1.Text = "menuStrip1";
          // 
          // fileToolStripMenuItem
          // 
          this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNew,
            this.MenuItemOpen,
            this.toolStripMenuItem1,
            this.MenuItemSave,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
          this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
          this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
          this.fileToolStripMenuItem.Text = "&File";
          // 
          // MenuItemNew
          // 
          this.MenuItemNew.Image = global::Manual_Menus.Properties.Resources.new_Image;
          this.MenuItemNew.Name = "MenuItemNew";
          this.MenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
          this.MenuItemNew.Size = new System.Drawing.Size(146, 22);
          this.MenuItemNew.Text = "&New";
          this.MenuItemNew.Click += new System.EventHandler(this.MenuItemNew_Click);
          // 
          // MenuItemOpen
          // 
          this.MenuItemOpen.Image = global::Manual_Menus.Properties.Resources.open_Image;
          this.MenuItemOpen.Name = "MenuItemOpen";
          this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
          this.MenuItemOpen.Size = new System.Drawing.Size(146, 22);
          this.MenuItemOpen.Text = "&Open";
          this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
          // 
          // toolStripMenuItem1
          // 
          this.toolStripMenuItem1.Name = "toolStripMenuItem1";
          this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
          // 
          // MenuItemSave
          // 
          this.MenuItemSave.Image = global::Manual_Menus.Properties.Resources.save_Image;
          this.MenuItemSave.Name = "MenuItemSave";
          this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
          this.MenuItemSave.Size = new System.Drawing.Size(146, 22);
          this.MenuItemSave.Text = "&Save";
          this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
          // 
          // saveAsToolStripMenuItem
          // 
          this.saveAsToolStripMenuItem.Image = global::Manual_Menus.Properties.Resources.save_Image;
          this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
          this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.saveAsToolStripMenuItem.Text = "Save &As";
          // 
          // toolStripMenuItem2
          // 
          this.toolStripMenuItem2.Name = "toolStripMenuItem2";
          this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 6);
          // 
          // printToolStripMenuItem
          // 
          this.printToolStripMenuItem.Image = global::Manual_Menus.Properties.Resources.print_Image;
          this.printToolStripMenuItem.Name = "printToolStripMenuItem";
          this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
          this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.printToolStripMenuItem.Text = "&Print";
          // 
          // printPreviewToolStripMenuItem
          // 
          this.printPreviewToolStripMenuItem.Image = global::Manual_Menus.Properties.Resources.printPreview_Image;
          this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
          this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.printPreviewToolStripMenuItem.Text = "Print Preview";
          // 
          // toolStripMenuItem3
          // 
          this.toolStripMenuItem3.Name = "toolStripMenuItem3";
          this.toolStripMenuItem3.Size = new System.Drawing.Size(143, 6);
          // 
          // exitToolStripMenuItem
          // 
          this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
          this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
          this.exitToolStripMenuItem.Text = "E&xit";
          // 
          // formatToolStripMenuItem
          // 
          this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBold,
            this.ToolStripMenuItemItalic,
            this.ToolStripMenuItemUnderline});
          this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
          this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
          this.formatToolStripMenuItem.Text = "Format";
          // 
          // ToolStripMenuItemBold
          // 
          this.ToolStripMenuItemBold.CheckOnClick = true;
          this.ToolStripMenuItemBold.Name = "ToolStripMenuItemBold";
          this.ToolStripMenuItemBold.Size = new System.Drawing.Size(125, 22);
          this.ToolStripMenuItemBold.Text = "Bold";
          this.ToolStripMenuItemBold.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemBold_CheckedChanged);
          // 
          // ToolStripMenuItemItalic
          // 
          this.ToolStripMenuItemItalic.CheckOnClick = true;
          this.ToolStripMenuItemItalic.Name = "ToolStripMenuItemItalic";
          this.ToolStripMenuItemItalic.Size = new System.Drawing.Size(125, 22);
          this.ToolStripMenuItemItalic.Text = "Italic";
          this.ToolStripMenuItemItalic.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemItalic_CheckedChanged);
          // 
          // ToolStripMenuItemUnderline
          // 
          this.ToolStripMenuItemUnderline.CheckOnClick = true;
          this.ToolStripMenuItemUnderline.Name = "ToolStripMenuItemUnderline";
          this.ToolStripMenuItemUnderline.Size = new System.Drawing.Size(125, 22);
          this.ToolStripMenuItemUnderline.Text = "Underline";
          this.ToolStripMenuItemUnderline.CheckedChanged += new System.EventHandler(this.ToolStripMenuItemUnderline_CheckedChanged);
          // 
          // MenuItemHelp
          // 
          this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripMenuItem4,
            this.aboutToolStripMenuItem});
          this.MenuItemHelp.Name = "MenuItemHelp";
          this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
          this.MenuItemHelp.Text = "&Help";
          // 
          // contentsToolStripMenuItem
          // 
          this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
          this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
          this.contentsToolStripMenuItem.Text = "Contents";
          // 
          // indexToolStripMenuItem
          // 
          this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
          this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
          this.indexToolStripMenuItem.Text = "Index";
          // 
          // searchToolStripMenuItem
          // 
          this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
          this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
          this.searchToolStripMenuItem.Text = "Search";
          // 
          // toolStripMenuItem4
          // 
          this.toolStripMenuItem4.Name = "toolStripMenuItem4";
          this.toolStripMenuItem4.Size = new System.Drawing.Size(119, 6);
          // 
          // aboutToolStripMenuItem
          // 
          this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
          this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
          this.aboutToolStripMenuItem.Text = "About";
          // 
          // richTextBoxText
          // 
          this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.richTextBoxText.Location = new System.Drawing.Point(0, 52);
          this.richTextBoxText.Name = "richTextBoxText";
          this.richTextBoxText.Size = new System.Drawing.Size(454, 212);
          this.richTextBoxText.TabIndex = 1;
          this.richTextBoxText.Text = "";
          this.richTextBoxText.TextChanged += new System.EventHandler(this.richTextBoxText_TextChanged);
          // 
          // toolStrip1
          // 
          this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.ToolStripButtonBold,
            this.ToolStripButtonItalic,
            this.ToolStripButtonUnderline,
            this.toolStripSeparator1,
            this.ToolStripComboBoxFonts,
            this.toolStripSeparator2,
            this.helpToolStripButton});
          this.toolStrip1.Location = new System.Drawing.Point(0, 24);
          this.toolStrip1.Name = "toolStrip1";
          this.toolStrip1.Size = new System.Drawing.Size(454, 25);
          this.toolStrip1.TabIndex = 2;
          this.toolStrip1.Text = "toolStrip1";
          // 
          // newToolStripButton
          // 
          this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
          this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.newToolStripButton.Name = "newToolStripButton";
          this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
          this.newToolStripButton.Text = "&New";
          this.newToolStripButton.Click += new System.EventHandler(this.MenuItemNew_Click);
          // 
          // openToolStripButton
          // 
          this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
          this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.openToolStripButton.Name = "openToolStripButton";
          this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
          this.openToolStripButton.Text = "&Open";
          this.openToolStripButton.Click += new System.EventHandler(this.MenuItemOpen_Click);
          // 
          // saveToolStripButton
          // 
          this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
          this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.saveToolStripButton.Name = "saveToolStripButton";
          this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
          this.saveToolStripButton.Text = "&Save";
          this.saveToolStripButton.Click += new System.EventHandler(this.MenuItemSave_Click);
          // 
          // printToolStripButton
          // 
          this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
          this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.printToolStripButton.Name = "printToolStripButton";
          this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
          this.printToolStripButton.Text = "&Print";
          // 
          // toolStripSeparator
          // 
          this.toolStripSeparator.Name = "toolStripSeparator";
          this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
          // 
          // ToolStripButtonBold
          // 
          this.ToolStripButtonBold.CheckOnClick = true;
          this.ToolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.ToolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonBold.Image")));
          this.ToolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.ToolStripButtonBold.Name = "ToolStripButtonBold";
          this.ToolStripButtonBold.Size = new System.Drawing.Size(23, 22);
          this.ToolStripButtonBold.Text = "toolStripButton1";
          this.ToolStripButtonBold.CheckedChanged += new System.EventHandler(this.ToolStripButtonBold_CheckedChanged);
          // 
          // ToolStripButtonItalic
          // 
          this.ToolStripButtonItalic.CheckOnClick = true;
          this.ToolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.ToolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonItalic.Image")));
          this.ToolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.ToolStripButtonItalic.Name = "ToolStripButtonItalic";
          this.ToolStripButtonItalic.Size = new System.Drawing.Size(23, 22);
          this.ToolStripButtonItalic.Text = "toolStripButton2";
          this.ToolStripButtonItalic.CheckedChanged += new System.EventHandler(this.ToolStripButtonItalic_CheckedChanged);
          // 
          // ToolStripButtonUnderline
          // 
          this.ToolStripButtonUnderline.CheckOnClick = true;
          this.ToolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.ToolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonUnderline.Image")));
          this.ToolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.ToolStripButtonUnderline.Name = "ToolStripButtonUnderline";
          this.ToolStripButtonUnderline.Size = new System.Drawing.Size(23, 22);
          this.ToolStripButtonUnderline.Text = "toolStripButton3";
          this.ToolStripButtonUnderline.CheckedChanged += new System.EventHandler(this.ToolStripButtonUnderline_CheckedChanged);
          // 
          // toolStripSeparator1
          // 
          this.toolStripSeparator1.Name = "toolStripSeparator1";
          this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
          // 
          // ToolStripComboBoxFonts
          // 
          this.ToolStripComboBoxFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.ToolStripComboBoxFonts.Items.AddRange(new object[] {
            "MS Sans Serif",
            "Times New Roman"});
          this.ToolStripComboBoxFonts.Name = "ToolStripComboBoxFonts";
          this.ToolStripComboBoxFonts.Size = new System.Drawing.Size(121, 25);
          this.ToolStripComboBoxFonts.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBoxFonts_SelectedIndexChanged);
          // 
          // toolStripSeparator2
          // 
          this.toolStripSeparator2.Name = "toolStripSeparator2";
          this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
          // 
          // helpToolStripButton
          // 
          this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
          this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
          this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
          this.helpToolStripButton.Name = "helpToolStripButton";
          this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
          this.helpToolStripButton.Text = "He&lp";
          // 
          // statusStrip1
          // 
          this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelText,
            this.toolStripStatusLabelBold,
            this.toolStripStatusLabelItalic,
            this.toolStripStatusLabelUnderline});
          this.statusStrip1.Location = new System.Drawing.Point(0, 242);
          this.statusStrip1.Name = "statusStrip1";
          this.statusStrip1.Size = new System.Drawing.Size(454, 22);
          this.statusStrip1.TabIndex = 3;
          this.statusStrip1.Text = "statusStrip1";
          // 
          // toolStripStatusLabelText
          // 
          this.toolStripStatusLabelText.AutoSize = false;
          this.toolStripStatusLabelText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
          this.toolStripStatusLabelText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
          this.toolStripStatusLabelText.Name = "toolStripStatusLabelText";
          this.toolStripStatusLabelText.Size = new System.Drawing.Size(259, 17);
          this.toolStripStatusLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // toolStripStatusLabelBold
          // 
          this.toolStripStatusLabelBold.AutoSize = false;
          this.toolStripStatusLabelBold.Enabled = false;
          this.toolStripStatusLabelBold.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
          this.toolStripStatusLabelBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelBold.Image")));
          this.toolStripStatusLabelBold.Name = "toolStripStatusLabelBold";
          this.toolStripStatusLabelBold.Size = new System.Drawing.Size(47, 17);
          this.toolStripStatusLabelBold.Text = "Bold";
          // 
          // toolStripStatusLabelItalic
          // 
          this.toolStripStatusLabelItalic.AutoSize = false;
          this.toolStripStatusLabelItalic.Enabled = false;
          this.toolStripStatusLabelItalic.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
          this.toolStripStatusLabelItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelItalic.Image")));
          this.toolStripStatusLabelItalic.Name = "toolStripStatusLabelItalic";
          this.toolStripStatusLabelItalic.Size = new System.Drawing.Size(48, 17);
          this.toolStripStatusLabelItalic.Text = "Italic";
          // 
          // toolStripStatusLabelUnderline
          // 
          this.toolStripStatusLabelUnderline.AutoSize = false;
          this.toolStripStatusLabelUnderline.Enabled = false;
          this.toolStripStatusLabelUnderline.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
          this.toolStripStatusLabelUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelUnderline.Image")));
          this.toolStripStatusLabelUnderline.Name = "toolStripStatusLabelUnderline";
          this.toolStripStatusLabelUnderline.Size = new System.Drawing.Size(76, 17);
          this.toolStripStatusLabelUnderline.Text = "Underline";
          // 
          // Form1
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(454, 264);
          this.Controls.Add(this.statusStrip1);
          this.Controls.Add(this.toolStrip1);
          this.Controls.Add(this.richTextBoxText);
          this.Controls.Add(this.menuStrip1);
          this.MainMenuStrip = this.menuStrip1;
          this.Name = "Form1";
          this.Text = "Form1";
          this.menuStrip1.ResumeLayout(false);
          this.menuStrip1.PerformLayout();
          this.toolStrip1.ResumeLayout(false);
          this.toolStrip1.PerformLayout();
          this.statusStrip1.ResumeLayout(false);
          this.statusStrip1.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBold;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemItalic;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUnderline;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton ToolStripButtonBold;
        private System.Windows.Forms.ToolStripButton ToolStripButtonItalic;
        private System.Windows.Forms.ToolStripButton ToolStripButtonUnderline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBoxFonts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBold;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelItalic;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUnderline;
    }
}

