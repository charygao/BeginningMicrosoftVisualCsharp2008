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

public partial class ProfileDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if (!Page.IsPostBack)
       {
          DropDownListCountries.SelectedValue = Profile.Country;
       }

       LabelLastVisit.Text = Profile.LastVisit.ToLongTimeString();
       LabelVisitCount.Text = Profile.Visits.ToString();
       LabelSelectedCountry.Text = Profile.Country;

       Profile.Visits++;
       Profile.LastVisit = DateTime.Now;
       Profile.Save();
    }

    protected void OnCountrySelection(object sender, EventArgs e)
    {
       Profile.Country = this.DropDownListCountries.SelectedItem.Value;
       Profile.Save();
    }
}
