<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Modify.aspx.cs" Inherits="Modify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Modify Existing Unit-Factor Database</title>
</head>
<body>
    <form id="form1" runat="server" method="post" action="Modify.aspx">
    <div style="background-color: #C0C0C0; border-style: solid; border-width: 1px; margin: auto; width: 800px; padding: 10px">
    
         <h1 style="text-align: center">Update Database</h1>
         <h2>Add units/factors</h2>
         <br />
      <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Conversions]" InsertCommand="INSERT INTO Conversions(Units, Factor) VALUES (@newunit, @convFactor)" DeleteCommand="DELETE FROM Conversions WHERE (Id = @Id)">
            <DeleteParameters>
                <asp:ControlParameter ControlID="output3" Name="Id" PropertyName="SelectedValue" />
            </DeleteParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="newunit" Name="newunit" PropertyName="Text" />
                <asp:ControlParameter ControlID="convFactor" Name="convFactor" PropertyName="Text" />
            </InsertParameters>
         </asp:SqlDataSource>
       
      <asp:Label ID="Label1" runat="server" Text="Enter unit:"></asp:Label> &nbsp 
          <asp:textbox ID="newunit" runat="server" style="width:147px"></asp:textbox> &nbsp &nbsp
      <asp:Label ID="Label2" runat="server" Text="Enter factor:"></asp:Label> &nbsp
          <asp:textbox ID="convFactor" runat="server" style="width:147px"></asp:textbox>
      <br />
        
                

    <br />
        <br />
      <asp:Button ID="add" runat="server" Text="Add" OnClick="add_Click" />
      
      <h2>Delete units/factors</h2>
      <br />
      <br />
       <asp:DropDownList ID="output3" runat="server" DataSourceID="SqlDataSource1" DataTextField="Units" DataValueField="Id"></asp:DropDownList> &nbsp &nbsp
     &nbsp &nbsp
      <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" /> &nbsp &nbsp
      <asp:Button ID="show" runat="server" Text="Show Factor" OnClick="show_Click" /> &nbsp &nbsp
      <asp:TextBox ID="sfactor" runat="server" Readonly="true"></asp:TextBox> &nbsp &nbsp
        <asp:Button ID="return" runat="server" Text="Return to Convert" OnClick="return_Click" />
          <br />
      <br />
      <br />
        <asp:Label ID="comment1" runat="server" style="text-decoration:solid"></asp:Label>



    </div>
    </form>
</body>
</html>
