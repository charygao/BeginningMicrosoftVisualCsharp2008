﻿using System;
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

public partial class Scripting_ValidationDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnServerOddNumber(object source, ServerValidateEventArgs args)
    {
       if (int.Parse(args.Value) % 2 == 0)
       {
          args.IsValid = true;
       }
       else
       {
          args.IsValid = false;
       }
    }
}