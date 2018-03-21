using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiBasic
{
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();

            // Create a new instance of the child form.
            MdiBasic.frmChild child = new MdiBasic.frmChild(this);

            // Show the form.
            child.Show();

        }
    }
}
