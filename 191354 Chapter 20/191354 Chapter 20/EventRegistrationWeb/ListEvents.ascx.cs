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

public partial class ListEvents : System.Web.UI.UserControl, ICountry
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void Configure(DateTime date, params string[] countries)
    {
       DropDownListCountries.Items.Clear();

       EventCalendar.SelectedDate = date;
       ListItem[] items = new ListItem[countries.Length];
       for (int i = 0; i < countries.Length; i++)
       {
          items[i] = new ListItem(countries[i]);
       }
       DropDownListCountries.Items.AddRange(items);
    }


    #region ICountry Members

    public string GetCountry()
    {
       return DropDownListCountries.SelectedItem.Value;
    }

    #endregion

    [ConnectionProvider("Country", "CountryProvider")]
    public ICountry GetCountryInterface()
    {
       return this;
    }

}
