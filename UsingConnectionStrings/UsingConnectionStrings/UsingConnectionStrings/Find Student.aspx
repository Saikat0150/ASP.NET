<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Find Student.aspx.cs" Inherits="UsingConnectionStrings.Find_Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table width="40%" align="center">
           <tr>
               <td>
               <asp:TextBox ID="name" runat="server" Width="395px"></asp:TextBox>
               </td>
               <td>
                   <asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" Width="148px" />
               </td>
           </tr>
           
           <tr>
               <td>
                   <asp:Label ID="result" runat="server" Text=""></asp:Label>
               </td>
           </tr>
           <tr>
               <td colspan="2">
                   <asp:GridView ID="Goutput" runat="server" Height="58px" Width="341px"></asp:GridView>
               </td>
           </tr>
       </table>
    </form>
</body>
</html>
