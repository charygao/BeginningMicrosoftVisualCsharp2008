using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BegVCSharp_27_2_LINQtoSQLDataBinding
{

    public partial class Form1 : Form
    {
        //added by hand-editing
        private NorthwindDataContext northwindDataContext = new NorthwindDataContext();

        public Form1()
        {
            InitializeComponent();
            customerBindingSource.DataSource = northwindDataContext.Customers;

        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            northwindDataContext.SubmitChanges();
        }
    }
}
