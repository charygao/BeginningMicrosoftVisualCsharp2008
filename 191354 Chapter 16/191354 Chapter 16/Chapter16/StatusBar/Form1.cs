using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manual_Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ToolStripComboBoxFonts.SelectedIndex = 0;
        }

        private void MenuItemShowHelpMenu_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            MenuItemHelp.Visible = item.Checked;
        }

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile(@".\Example.rtf");
            }
            catch
            {
                // Ignore errors
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile(@".\Example.rtf");
            }
            catch
            {
                // Ignore errors
            }
        }

        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
        }

        private void ToolStripButtonBold_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            // Get the font that is being used in the selected text.
            oldFont = this.richTextBoxText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            // Insert the new font and return focus to the RichTextBox.
            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();

            this.ToolStripMenuItemBold.CheckedChanged -= new EventHandler(ToolStripMenuItemBold_CheckedChanged);
            this.ToolStripMenuItemBold.Checked = checkState;
            this.ToolStripMenuItemBold.CheckedChanged += new EventHandler(ToolStripMenuItemBold_CheckedChanged);
            toolStripStatusLabelBold.Enabled = checkState;
        }

        private void ToolStripButtonItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            // Get the font that is being used in the selected text.
            oldFont = this.richTextBoxText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            // Insert the new font.
            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();

            this.ToolStripMenuItemItalic.CheckedChanged -= new EventHandler(ToolStripMenuItemItalic_CheckedChanged);
            this.ToolStripMenuItemItalic.Checked = checkState;
            this.ToolStripMenuItemItalic.CheckedChanged += new EventHandler(ToolStripMenuItemItalic_CheckedChanged);
            toolStripStatusLabelItalic.Enabled = checkState;
        }

        private void ToolStripButtonUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            // Get the font that is being used in the selected text.
            oldFont = this.richTextBoxText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            // Insert the new font.
            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();

            this.ToolStripMenuItemUnderline.CheckedChanged -= new EventHandler(ToolStripMenuItemUnderline_CheckedChanged);
            this.ToolStripMenuItemUnderline.Checked = checkState;
            this.ToolStripMenuItemUnderline.CheckedChanged += new EventHandler(ToolStripMenuItemUnderline_CheckedChanged);
            toolStripStatusLabelUnderline.Enabled = checkState;
        }

        private void ToolStripMenuItemBold_CheckedChanged(object sender, EventArgs e)
        {
            this.ToolStripButtonBold.Checked = ToolStripMenuItemBold.Checked;
        }

        private void ToolStripMenuItemItalic_CheckedChanged(object sender, EventArgs e)
        {
            this.ToolStripButtonItalic.Checked = ToolStripMenuItemItalic.Checked;
        }

        private void ToolStripMenuItemUnderline_CheckedChanged(object sender, EventArgs e)
        {
            this.ToolStripButtonUnderline.Checked = ToolStripMenuItemUnderline.Checked;
        }

        private void ToolStripComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
          string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
          Font newFont = null;

          // Create a new font with the correct font family.
          if (richTextBoxText.SelectionFont == null)
            newFont = new Font(text, richTextBoxText.Font.Size);
          else
            newFont = new Font(text, richTextBoxText.SelectionFont.Size,
                                  richTextBoxText.SelectionFont.Style);
          richTextBoxText.SelectionFont = newFont;
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelText.Text = "Number of characters: " + richTextBoxText.Text.Length;
        }
    }
}
