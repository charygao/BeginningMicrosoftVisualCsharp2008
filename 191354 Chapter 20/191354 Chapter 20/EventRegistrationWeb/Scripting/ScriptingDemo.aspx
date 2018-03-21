<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScriptingDemo.aspx.cs" Inherits="Scripting_ScriptingDemo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        #TextArea1
        {
            height: 228px;
            width: 432px;
        }
    </style>
    
    <script language="javascript" type="text/javascript"   >  
    function walktree(level, tree)
    {
        var textArea = document.getElementById("TextArea1");
    
        var numItems = tree.length;
        
        for (var i = 0; i < numItems; i++)
        {
            var item = tree.item(i);
            textArea.value += level + " " + item.tagName + "\n";
 
            if (item.hasChildNodes)
            {
                walktree(level + 1, item.childNodes);
            }
            
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server" >
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="205px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                <input id="b1" type="button" value="Click" onclick="walktree(0, form1.childNodes);" />                    
                <div id="d4"></div>
                </td>
            </tr>
        </table>
    
    </div>
    <textarea id="TextArea1"></textarea>
    
    </form>
</body>
</html>
