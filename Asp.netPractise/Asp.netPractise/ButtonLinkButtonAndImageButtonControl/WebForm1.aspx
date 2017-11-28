<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ButtonLinkButtonAndImageButtonControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" ToolTip="Submit plz" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" OnClientClick="alert('You go to next page');" ToolTip="Click plz">Click me</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/Button-Next-icon.png" OnClientClick="return confirm('Are you sure delete thi?');" OnClick="ImageButton1_Click" Width="82px" ToolTip="Click here" />
        </div>
    </form>
</body>
</html>
