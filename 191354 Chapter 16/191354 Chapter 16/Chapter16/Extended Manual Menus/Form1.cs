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
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
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
    }
}
