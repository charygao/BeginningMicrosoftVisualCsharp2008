<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpenWindow.aspx.cs" Inherits="Scripting_OpenWindow" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    function openWindow()
    {
        window.open("ObjectDemo.aspx", "_blank", "menubar=no, resizable=no, status=no, titlebar=no, width=300, height=300", false);
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Button1" type="button" value="button" onclick="openWindow();"/>   
    </div>
    </form>
</body>
</html>
