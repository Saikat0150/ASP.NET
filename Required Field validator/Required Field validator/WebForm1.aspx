<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Required_Field_validator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table width ="40%" align="center" bgcoloe ="#cccccc">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Entre Name" ControlToValidate="Name"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Mobile No: </td>
                <td>
                    <asp:TextBox ID="Mobile" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Mobile number" ControlToValidate="Mobile" ValidationExpression="^[6-9]\d{9}$" Display="Dynamic"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Enter the mobile number" ControlToValidate="Mobile" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Age</td>
                <td>
                    <asp:TextBox ID="Age" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter Age between 18 to 50" ControlToValidate="Age" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td align="left">
                    <asp:RadioButtonList ID="Gender" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="M">Male</asp:ListItem>
                        <asp:ListItem Value="F">Female</asp:ListItem>

                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid Email" ControlToValidate="Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please Enter Password" ControlToValidate="Password"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox ID="cpassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password doesn't match" ControlToCompare="cpassword" ControlToValidate="Password"></asp:CompareValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Reenter Password" ControlToValidate="cpassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="auto-style1">
                    <asp:Button ID="Submit" runat="server" Text="Click To Register" OnClick="Submit_Click" style="margin-left: 30px" Width="239px" />

                </td>
            </tr>
            <tr>
                <td colspan="2" >
                    <asp:Label ID="Registered" runat="server" Text="Registration Status" style="margin-left: 80px" Width="239px"></asp:Label>

                </td>
            </tr>

        </table>
    </form>
</body>
</html>
