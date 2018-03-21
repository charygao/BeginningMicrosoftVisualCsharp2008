<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TextBoxWatermark.aspx.cs" Inherits="TextBoxWatermark" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox1_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox1" 
            WatermarkText="Enter your firstname">
        </ajaxToolkit:TextBoxWatermarkExtender>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <ajaxToolkit:TextBoxWatermarkExtender ID="TextBox2_TextBoxWatermarkExtender" 
            runat="server" Enabled="True" TargetControlID="TextBox2" 
            WatermarkText="Enter your lastname:">
        </ajaxToolkit:TextBoxWatermarkExtender>
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
