using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleClient
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         //WebServicesSample.Service1SoapClient client =
         //   new WebServicesSample.Service1SoapClient();
         //textBox2.Text = client.ReverseString(textBox1.Text);

         // asynchronous version
         WebServicesSample.Service1SoapClient client =
            new SimpleClient.WebServicesSample.Service1SoapClient();
         client.ReverseStringCompleted += new EventHandler<SimpleClient.WebServicesSample.ReverseStringCompletedEventArgs>(client_ReverseStringCompleted);
         client.ReverseStringAsync(textBox1.Text);

      }

      void client_ReverseStringCompleted(object sender, SimpleClient.WebServicesSample.ReverseStringCompletedEventArgs e)
      {
         textBox2.Text = e.Result;
      }
   }
}
