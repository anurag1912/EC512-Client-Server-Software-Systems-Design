<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Votes.aspx.cs" Inherits="Modify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Performance Page</title>
</head>

   
<body>
    <form id="form2" runat="server">

    <div style="background-color: #DDEEFF; border-style: dashed; margin: auto; border-width: 5px; width: 900px; padding: 20px">
    
        <h1 style="text-align: center">THANK YOU FOR VOTING!</h1>
        <br/>
        <h2 style="text-align: center">Performance of each candidate</h2>
        <br/> 
        <br />
        
            <asp:Table ID="Table1" runat="server" CssClass="collapse">
            </asp:Table>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Voting]"></asp:SqlDataSource>
    <br />
        <br />
        <asp:Label ID="comment1" runat="server" style="text-decoration:solid"></asp:Label>
         </div>

        </form>
</body>





    

</html>

