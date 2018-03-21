<%@ Page Language="C#" MasterPageFile="~/EventRegistration.master" AutoEventWireup="true" CodeFile="EventList.aspx.cs" Inherits="EventList" Title="Untitled Page" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style6
    {
        width: 100%;
    }
    .style7
    {
        width: 316px;
    }
</style>
</asp:Content>
<asp:Content ID="ContentMenu" ContentPlaceHolderID="ContentPlaceHolderMenu" Runat="Server">
  
</asp:Content>
<asp:Content ID="ContentMain" ContentPlaceHolderID="ContentPlaceHolderMain" Runat="Server">
  
    <table class="style6">
    <tr>
        <td class="style7">
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </td>
        <td>
            <asp:ListBox ID="ListBox1" runat="server" Width="276px"></asp:ListBox>
        </td>
    </tr>
    <tr>
        <td class="style7">
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>
  
</asp:Content>

