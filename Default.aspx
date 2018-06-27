<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox runat="server" TextMode="multiline" Rows="7" id="lbltxt"/>
    <% Response.Write("Hello world"); %>
    <asp:Button runat="server" OnClick="getData" Text="GET"/>
    <asp:Button ID="Button2" runat="server" OnClick="asd" Text="POST"/>
    
    </div>
    </form>
</body>
</html>
