<%@Page Language ="C#" %> 
<script runat="server">
         protected void buttonclick(object sender, EventArgs e)
    {
        DateBox.Text = DateTime.Now.ToString("D");
        TimeBox.Text = DateTime.Now.ToString("T");

    }
    </script>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head><title>
	Get Date & Time
</title>
   
    <style type="text/css">
        .center {
            text-align: center;
        }
        .maindiv {
            margin: auto;
            border-style: solid;
            border-width: 1px;
            width: 800px;
            background-color: #C0C0C0;
            padding: 30px;
        }
    </style>
</head>
<body>
    <form method="post" action="default.aspx" id="form1" runat="server">
<div 
</div>

<div 
</div>
    <div class="maindiv" style="height: 160px">
    
        <h1 class="center">Date and Time</h1>
        Date: <asp:TextBox id="DateBox" readonly="true" runat="server"/>
&nbsp; Time:
        <asp:TextBox id="TimeBox" readonly="true" runat="server" />
        <br />
        <br />
        <asp:button id="Button1" text="Get" onclick="buttonclick" style="width:67px;" runat="server"/>
        <br />
    
    </div>
    </form>
</body>
</html>
