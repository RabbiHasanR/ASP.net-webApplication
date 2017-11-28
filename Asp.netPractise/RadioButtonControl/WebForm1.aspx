<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonControl.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset style="width:300px">
                <legend>Gender</legend>
            <asp:RadioButton ID="MaleRadioButton" Text="Male" runat="server" GroupName="GenderGroup" OnCheckedChanged="MaleRadioButton_CheckedChanged" />
                <asp:RadioButton ID="FemaleRadioButton" Text="Female" runat="server" GroupName="GenderGroup" />
                <asp:RadioButton ID="UnknownRadioButton" Text="Unknown" runat="server" GroupName="GenderGroup" />
        </fieldset>
                </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
    </form>
</body>
</html>
