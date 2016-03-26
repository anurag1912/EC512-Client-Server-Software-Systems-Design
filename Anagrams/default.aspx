<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server" method="post" action="Default.aspx">
    <div style="background-color: #C0C0C0; border-style: solid; border-width: 1px; margin: auto; width: 800px; padding: 10px">
    
        <h1 style="text-align: center">Find Anagrams</h1>

            <br/>
            Enter a character string:&nbsp;
        <asp:textbox ID="inputString" runat="server" style="width:147px"></asp:textbox>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Elminate Duplicates" />
    <br/>
        <br />
        <asp:TextBox textmode="MultiLine" runat="server" size="4"  id="outputList1" style="height:85px;width:150px;"> 
                
</asp:TextBox>
    <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Find Anagrams" OnClick="Button1_Click"/>
        <br />
        <br />
        <asp:Label ID="comment" runat="server" style="text-decoration:solid"></asp:Label>
        
            
    </div>
        </form>
</body>



    

    

</html>
