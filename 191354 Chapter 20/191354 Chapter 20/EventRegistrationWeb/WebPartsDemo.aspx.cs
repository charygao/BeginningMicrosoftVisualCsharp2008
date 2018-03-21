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

public partial class WebPartsDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Page_Init(object sender, EventArgs e)
    {
       foreach (WebPartDisplayMode mode in WebPartManager1.SupportedDisplayModes)
       {
          if (mode.IsEnabled(WebPartManager1))
          {
             DropDownListDisplayModes.Items.Add(new ListItem(mode.Name));
          }
       }

    }
    protected void OnChangeDisplayMode(object sender, EventArgs e)
    {
       string selectedMode = DropDownListDisplayModes.SelectedValue;
       WebPartDisplayMode mode = WebPartManager1.SupportedDisplayModes[selectedMode];
       if (mode != null)
       {
          WebPartManager1.DisplayMode = mode;
       }

    }
}
