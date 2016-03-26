<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> CONVERSIONS :: Convert from-->to</title>
</head>
<body>
    <form id="form2" runat="server" method="post" action="Default.aspx">
    <div style="background-color: #C0C0C0; border-style: solid; border-width: 1px; margin: auto; width: 800px; padding: 10px">
    
        <h1 style="text-align: center">CONVERSIONS</h1>

            <br/>
             
        <asp:textbox ID="inputString" runat="server" style="width:147px"></asp:textbox>
        <asp:DropDownList ID="input1" runat="server"></asp:DropDownList>
        is equals to
        <asp:TextBox ID="outputString" runat="server" style="width:147px"></asp:TextBox>
        <asp:DropDownList ID="output1" runat="server"></asp:DropDownList>
    <br/>
        <br />
        
                

    <br />
        <br />
              <asp:Button ID="Button1" runat="server" Text="Convert" OnClick="Button1_Click"/>

        <br />
        <br />
        <asp:Label ID="comment" runat="server" style="text-decoration:solid"></asp:Label>
        
            
    </div>
        </form>
</body>



    

    

</html>
