<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display Query Data.aspx.cs" Inherits="Display_Conditional_data_in_gridview.Display_Query_Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table align="center">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>

                </td>
                <td>
                    <asp:Button ID="btn" runat="server" Text="Search" OnClick="btn_Click" />

                </td>
            </tr>
            <tr>
                <td colspan="2"><asp:GridView ID="GridView1" runat="server"></asp:GridView></td>
            </tr>
         </table>
    </form>
</body>
</html>
