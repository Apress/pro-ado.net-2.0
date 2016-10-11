<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       &nbsp;
    
    &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
          BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4"
          DataKeyNames="DemoID" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display."
          ForeColor="Black" GridLines="Horizontal">
          <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
          <Columns>
             <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
             <asp:BoundField DataField="DemoID" HeaderText="DemoID" ReadOnly="True" SortExpression="DemoID" />
             <asp:BoundField DataField="DemoValue" HeaderText="DemoValue" SortExpression="DemoValue" />
          </Columns>
          <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
          <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
          <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
       </asp:GridView>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TestConnectionString1 %>"
          DeleteCommand="DELETE FROM [Demo] WHERE [DemoID] = @original_DemoID" InsertCommand="INSERT INTO [Demo] ([DemoValue]) VALUES (@DemoValue)"
          ProviderName="<%$ ConnectionStrings:TestConnectionString1.ProviderName %>" SelectCommand="SELECT [DemoID], [DemoValue] FROM [Demo]"
          UpdateCommand="UPDATE [Demo] SET [DemoValue] = @DemoValue WHERE [DemoID] = @original_DemoID">
          <InsertParameters>
             <asp:Parameter Name="DemoValue" Type="String" />
          </InsertParameters>
          <UpdateParameters>
             <asp:Parameter Name="DemoValue" Type="String" />
             <asp:Parameter Name="original_DemoID" Type="Int32" />
          </UpdateParameters>
          <DeleteParameters>
             <asp:Parameter Name="original_DemoID" Type="Int32" />
          </DeleteParameters>
       </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
