<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ComandEvent.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="PrintButton" runat="server" Text="Print" OnCommand="CommandButton_Click" CommandName="Print"/>
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnCommand="CommandButton_Click" CommandName="Delete"/>
        <asp:Button ID="Top10Button" runat="server" Text="Show Top 10 Employee" OnCommand="CommandButton_Click" CommandName="Show" CommandArgument="Top10"/>
        <asp:Button ID="ShowTop10Button" runat="server" Text="Show Bottom Top 10 Employee" OnCommand="CommandButton_Click" CommandName="Show" CommandArgument="Bottom10"/>
            <br />
            <asp:Label ID="OutputLabel1" runat="server" Text="Label"></asp:Label>
        </div>
        <br />
    </form>
</body>
</html>
