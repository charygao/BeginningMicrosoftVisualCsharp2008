<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EventsManagement.aspx.cs" Inherits="Admin_EventsManagement" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
            CellPadding="3" CellSpacing="1" DataKeyNames="Id" 
            DataSourceID="EventsDataSource" GridLines="None">
            <footerstyle backcolor="#C6C3C6" forecolor="Black" />
            <rowstyle backcolor="#DEDFDE" forecolor="Black" />
            <Columns>
                <asp:commandfield ShowEditButton="True"></asp:commandfield>
                <asp:boundfield DataField="Id" HeaderText="Id" InsertVisible="False" 
                    ReadOnly="True" SortExpression="Id" Visible="False"></asp:boundfield>
                <asp:boundfield DataField="Title" HeaderText="Title" SortExpression="Title">
                </asp:boundfield>
                <asp:boundfield DataField="Date" HeaderText="Date" SortExpression="Date">
                </asp:boundfield>
                <asp:boundfield DataField="Location" HeaderText="Location" 
                    SortExpression="Location"></asp:boundfield>
            </Columns>
            <pagerstyle backcolor="#C6C3C6" forecolor="Black" horizontalalign="Right" />
            <selectedrowstyle backcolor="#9471DE" font-bold="True" forecolor="White" />
            <headerstyle backcolor="#4A3C8C" font-bold="True" forecolor="#E7E7FF" />
        </asp:GridView>
        <asp:SqlDataSource ID="EventsDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:EventsConnectionString %>" 
            DeleteCommand="DELETE FROM [Events] WHERE [Id] = @Id" 
            InsertCommand="INSERT INTO [Events] ([Title], [Date], [Location]) VALUES (@Title, @Date, @Location)" 
            SelectCommand="SELECT [Id], [Title], [Date], [Location] FROM [Events]" 
            UpdateCommand="UPDATE [Events] SET [Title] = @Title, [Date] = @Date, [Location] = @Location WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:parameter Name="Title" Type="String" />
                <asp:parameter Name="Date" Type="DateTime" />
                <asp:parameter Name="Location" Type="String" />
                <asp:parameter Name="Id" Type="Int32" />
            </UpdateParameters>
            <InsertParameters>
                <asp:parameter Name="Title" Type="String" />
                <asp:parameter Name="Date" Type="DateTime" />
                <asp:parameter Name="Location" Type="String" />
            </InsertParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
