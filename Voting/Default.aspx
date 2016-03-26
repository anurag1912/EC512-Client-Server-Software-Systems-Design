<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VOTE FOR A CANDIDATE</title>
</head>

<body>
    <form id="form2" runat="server" method="post" action="Default.aspx">
    <div style="background-color: #DDEEFF; border-style: dashed; margin: auto; border-width: 5px; width: 900px; padding: 20px">
    
        <h1 style="text-align: center">PLEASE CAST YOUR VOTE</h1>

            <br/>
        
    <br/>



        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Voting]" UpdateCommand="UPDATE Voting SET Count = @newcount WHERE (Id = @Id)">
            <UpdateParameters>
                <asp:ControlParameter ControlID="HiddenField1" Name="newcount" PropertyName="Value" />
                <asp:ControlParameter ControlID="RadioButtonList1" Name="Id" PropertyName="SelectedValue" />
            </UpdateParameters>
           
        </asp:SqlDataSource>

        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id"></asp:RadioButtonList>
        <asp:HiddenField ID="HiddenField1" runat="server" OnValueChanged="HiddenField1_ValueChanged" />
    <br />
        <br />
              <asp:Button ID="Button1" runat="server" Text="Click to Vote" OnClick="Button1_Click" /> &nbsp &nbsp

        <br />
        <br />
        <asp:Label ID="comment" runat="server" style="text-decoration:solid"></asp:Label>
            
    </div>
        </form>
</body>





    

</html>

