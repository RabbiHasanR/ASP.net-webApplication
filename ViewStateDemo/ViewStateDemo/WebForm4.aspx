<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ViewStateDemo.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-left: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="ASP.net Server Control"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 71px"></asp:TextBox>
        <div>
            <asp:Label ID="Label2" runat="server" Text="HTML Control"></asp:Label>
            <input id="Text1" type="text"runat="server" /></div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
