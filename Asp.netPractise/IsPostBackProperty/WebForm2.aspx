<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="IsPostBackProperty.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="font-family:Arial">
                <tr>
                    <td colspan="2"><b>Employee Detail Form</b></td>
                </tr>
                <tr>
                    <td>First Name</td>
                     <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td><asp:TextBox ID="TextBoox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td><asp:DropDownList ID="ddlCity" runat="server" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged"></asp:DropDownList></td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
    </form>
</body>
</html>
