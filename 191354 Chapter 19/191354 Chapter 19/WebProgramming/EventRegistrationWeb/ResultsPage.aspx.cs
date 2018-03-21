using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class ResultsPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!PreviousPage.IsValid)
            {
                labelResult.Text = "Error in previous page";
                return;
            }

            RegistrationInformation ri = PreviousPage.RegistrationInformation;

            labelResult.Text = String.Format("{0} {1} selected the event {2}", 
                ri.FirstName, ri.LastName, ri.SelectedEvent);

            //DropDownList dropDownListEvents =
            //   (DropDownList)PreviousPage.FindControl("dropDownListEvents");

            //string selectedEvent = dropDownListEvents.SelectedValue;

            //string firstName =
            //   ((TextBox)PreviousPage.FindControl("textFirstName")).Text;
            //string lastName =
            //   ((TextBox)PreviousPage.FindControl("textLastName")).Text;
            //string email = ((TextBox)PreviousPage.FindControl("textEmail")).Text;

            //labelResult.Text = String.Format("{0} {1} selected the event {2}",
            //      firstName, lastName, selectedEvent);
        }
        catch
        {
            labelResult.Text = "The originating page must contain " +
                  "textFirstName, textLastName, textEmail controls";
        }


    }
}
