using System;
using System.Threading;

public partial class UpdateProgressDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button_Click(object sender, EventArgs e)
    {
       Thread.Sleep(int.Parse(TextBox1.Text));
    }
}
