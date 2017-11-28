<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TextBoxControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" ToolTip="Please enter your name"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" ToolTip="Please enter your name"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true" ToolTip="Please enter your name"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
