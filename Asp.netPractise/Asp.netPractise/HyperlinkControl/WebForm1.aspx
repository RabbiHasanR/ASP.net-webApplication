<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HyperlinkControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" Target="_blank" NavigateUrl="~/WebForm2.aspx" Text="Click here go to next page" ImageUrl="~/Images/Lossless-Decoder-icon.png" ToolTip="Click here go to next page"></asp:HyperLink>
        </p>
    </form>
</body>
</html>
