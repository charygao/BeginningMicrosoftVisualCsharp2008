<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListEvents.ascx.cs" Inherits="ListEvents" %>
<style type="text/css">
    .style1
    {
        width: 100%;
        height: 272px;
    }
    .style2
    {
        height: 29px;
    }
    .style3
    {
        height: 167px;
    }
</style>
<table class="style1">
    <tr>
        <td class="style3">
            <asp:Calendar ID="EventCalendar" runat="server"></asp:Calendar>
        </td>
    </tr>
    <tr>
        <td class="style2">
            <asp:DropDownList ID="DropDownListCountries" runat="server" AutoPostBack="True" 
                Height="50px" Width="146px">
                <asp:ListItem Value="Austria"></asp:ListItem>
                <asp:ListItem Value="Germany"></asp:ListItem>
                <asp:ListItem Value="Switzerland"></asp:ListItem>
                <asp:ListItem Value="Italy"></asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
</table>
<p>
    &nbsp;</p>
