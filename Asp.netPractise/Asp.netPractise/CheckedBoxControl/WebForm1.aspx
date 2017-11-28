<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckedBoxControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:300px">
                <legend>Education</legend>
                <asp:CheckBox ID="GraduateCheckBox" Text="Graduate" runat="server" Checked="true" AutoPostBack="True" OnCheckedChanged="GraduateCheckBox_CheckedChanged"></asp:CheckBox>
                <asp:CheckBox ID="PostGraduateCheckBox" Text="Post Graduate" runat="server"></asp:CheckBox>
                <asp:CheckBox ID="DoctorateCheckBox" Text="Doctorate" runat="server"></asp:CheckBox>
            </fieldset>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
