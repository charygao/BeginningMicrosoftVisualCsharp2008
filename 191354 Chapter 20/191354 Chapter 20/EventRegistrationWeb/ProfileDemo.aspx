<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProfileDemo.aspx.cs" Inherits="ProfileDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelLastVisit" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelVisitCount" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelSelectedCountry" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListCountries" runat="server" AutoPostBack="True" 
            Height="50px" onselectedindexchanged="OnCountrySelection" Width="143px">
            <asp:ListItem>Austria</asp:ListItem>
            <asp:ListItem>Switzerland</asp:ListItem>
            <asp:ListItem>Germany</asp:ListItem>
            <asp:ListItem>Ireland</asp:ListItem>
        </asp:DropDownList>
    
    </div>
    </form>
</body>
</html>
