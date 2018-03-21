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

public partial class Country : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [ConnectionConsumer("Country", "CountryConsumer")]
    public void SetCountry(ICountry provider)
    {
       string country = provider.GetCountry();
       if (!string.IsNullOrEmpty(country))
       {
          LabelCountry.Text = country;
       }
    }

}
