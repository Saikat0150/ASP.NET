<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert using Procedure.aspx.cs" Inherits="Insert_using_Procedure.Insert_using_Procedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table width="40%", align="center">
            <tr>
                <td>
                    Name 
                </td>
                <td> 
                    <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Phone 
                </td>
                <td> 
                    <asp:TextBox ID="Phone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Gender 
                </td>
                <td align="left">
                    <asp:RadioButtonList ID="genderBtn" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>

                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btn" runat="server" Text="Submit" Width="78px" OnClick="btn_Click"  />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
