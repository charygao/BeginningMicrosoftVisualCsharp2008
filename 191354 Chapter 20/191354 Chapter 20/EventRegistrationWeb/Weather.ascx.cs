using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Weather : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
       Random r = new Random();
       int n = r.Next(1, 3);

       switch (n)
       {
          case 1:
             LabelWeather.Text = "Sun";
             break;
          case 2:
             LabelWeather.Text = "Rain";
             break;
          case 3:
             LabelWeather.Text = "Cloudy";
             break;
       }

    }
}
