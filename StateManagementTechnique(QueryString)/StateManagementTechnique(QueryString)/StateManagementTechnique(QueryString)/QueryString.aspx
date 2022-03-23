<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryString.aspx.cs" Inherits="StateManagementTechnique_QueryString_.QueryString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table align="Center">
            <tr>
                <td colspan="2" align="Center">
                    <h3>Bio Data</h3>
                </td>
            </tr>
            <tr>
                <td>
                    First Name:
                </td>
                <td>
                    <asp:TextBox ID="Fname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Last Name:
                </td>
                <td>
                    <asp:TextBox ID="Lname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="Center">
                    <asp:Button ID="Button1"  runat="server" Text="Button" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
