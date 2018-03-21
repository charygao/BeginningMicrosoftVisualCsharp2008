<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationDemo.aspx.cs" Inherits="Scripting_ValidationDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script language="javascript" src="SampleScripts.js" type="text/javascript" />
  
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:CustomValidator ID="CustomValidator1" runat="server" 
            ClientValidationFunction="oddNumberValidation" ControlToValidate="TextBox1" 
            ErrorMessage="Enter an odd number" onservervalidate="OnServerOddNumber"></asp:CustomValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
