using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelTextboxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctlLabelTextbox1_PositionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Changed");
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            ctlLabelTextbox1.Position = ctlLabelTextbox1.Position == LabelTextbox.ctlLabelTextbox.PositionEnum.Right ? LabelTextbox.ctlLabelTextbox.PositionEnum.Below : LabelTextbox.ctlLabelTextbox.PositionEnum.Right;
        }
    }
}
