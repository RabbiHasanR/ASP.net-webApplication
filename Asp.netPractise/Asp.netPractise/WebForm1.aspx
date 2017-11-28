<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Asp.netPractise.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2"><b>Employee Details</b></td>
                </tr>
                 <tr>
                     <td>First Name</td>
                     <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>Last Name</td>
                     <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>City</td>
                     <td><asp:DropDownList ID="ddlCity" runat="server"></asp:DropDownList></td>
                 </tr>
            </table>
        </div>
    </form>
</body>
</html>
