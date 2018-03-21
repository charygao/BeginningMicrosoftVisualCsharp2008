using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page 
{
    public RegistrationInformation RegistrationInformation
    {
        get
        {
            return new RegistrationInformation()
            {
                FirstName = textFirstName.Text,
                LastName = textLastName.Text,
                Email = textEmail.Text,
                SelectedEvent = dropDownListEvents.SelectedValue
            };
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void buttonSubmit_Click(object sender, EventArgs e)
    {
        string selectedEvent = dropDownListEvents.SelectedValue;
        string firstName = textFirstName.Text;
        string lastName = textLastName.Text;
        string email = textEmail.Text;

        labelResult.Text = String.Format("{0} {1} selected the event {2}", firstName, lastName, selectedEvent);
    }
}
