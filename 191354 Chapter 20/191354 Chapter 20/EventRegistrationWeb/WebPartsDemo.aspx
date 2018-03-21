<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebPartsDemo.aspx.cs" Inherits="WebPartsDemo" %>

<%@ Register src="ListEvents.ascx" tagname="ListEvents" tagprefix="uc1" %>
<%@ Register src="Weather.ascx" tagname="Weather" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:WebPartManager ID="WebPartManager1" runat="server">
        </asp:WebPartManager>
        <asp:DropDownList ID="DropDownListDisplayModes" runat="server" 
            AutoPostBack="True" Height="60px" onselectedindexchanged="OnChangeDisplayMode " 
            Width="167px">
        </asp:DropDownList>
        <br />
    </div>
    <table class="style1">
        <tr>
            <td>
                <asp:EditorZone ID="EditorZone1" runat="server">
                    <ZoneTemplate>
                        <asp:AppearanceEditorPart ID="AppearanceEditorPart1" runat="server" />
                        <asp:LayoutEditorPart ID="LayoutEditorPart1" runat="server" />
                    </ZoneTemplate>
                </asp:EditorZone>
            </td>
            <td>
                <asp:CatalogZone ID="CatalogZone1" runat="server">
                    <ZoneTemplate>
                        <asp:DeclarativeCatalogPart ID="DeclarativeCatalogPart1" runat="server">
                        </asp:DeclarativeCatalogPart>
                        <asp:PageCatalogPart ID="PageCatalogPart1" runat="server" />
                    </ZoneTemplate>
                </asp:CatalogZone>
            </td>
        </tr>
        <tr>
            <td>
                <asp:WebPartZone ID="ZoneLeft" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" HeaderText="Events" Padding="6">
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <MenuLabelHoverStyle ForeColor="#E2DED6"></MenuLabelHoverStyle>
                    <MenuPopupStyle BackColor="#5D7B9D" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbStyle BorderColor="#5D7B9D" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <PartTitleStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                    <ZoneTemplate>
                        <uc1:ListEvents ID="ListEvents1" runat="server" />
                    </ZoneTemplate>
                    <MenuVerbHoverStyle BackColor="#F7F6F3" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <PartChromeStyle BackColor="#F7F6F3" BorderColor="#E2DED6" Font-Names="Verdana" ForeColor="White">
                    </PartChromeStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <MenuLabelStyle ForeColor="White"></MenuLabelStyle>
                </asp:WebPartZone>
            </td>
            <td>
                <asp:WebPartZone ID="ZoneRight" runat="server" BorderColor="#CCCCCC" 
                    Font-Names="Verdana" HeaderText="Weather" Padding="6">
                    <EmptyZoneTextStyle Font-Size="0.8em"></EmptyZoneTextStyle>
                    <PartStyle Font-Size="0.8em" ForeColor="#333333"></PartStyle>
                    <TitleBarVerbStyle Font-Size="0.6em" Font-Underline="False" ForeColor="White">
                    </TitleBarVerbStyle>
                    <MenuLabelHoverStyle ForeColor="#FFCC66"></MenuLabelHoverStyle>
                    <MenuPopupStyle BackColor="#990000" BorderColor="#CCCCCC" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.6em">
                    </MenuPopupStyle>
                    <MenuVerbStyle BorderColor="#990000" BorderWidth="1px" BorderStyle="Solid" ForeColor="White">
                    </MenuVerbStyle>
                    <PartTitleStyle BackColor="#990000" Font-Bold="True" Font-Size="0.8em" ForeColor="White">
                    </PartTitleStyle>
                    <ZoneTemplate>
                        <uc2:Weather ID="Weather1" runat="server" />
                    </ZoneTemplate>
                    <MenuVerbHoverStyle BackColor="#FFFBD6" BorderColor="#CCCCCC" BorderWidth="1px" BorderStyle="Solid" ForeColor="#333333">
                    </MenuVerbHoverStyle>
                    <PartChromeStyle BackColor="#FFFBD6" BorderColor="#FFCC66" Font-Names="Verdana" ForeColor="#333333">
                    </PartChromeStyle>
                    <HeaderStyle HorizontalAlign="Center" Font-Size="0.7em" ForeColor="#CCCCCC">
                    </HeaderStyle>
                    <MenuLabelStyle ForeColor="White"></MenuLabelStyle>
                </asp:WebPartZone>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>
