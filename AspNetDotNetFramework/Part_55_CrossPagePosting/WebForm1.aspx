<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_55_CrossPagePosting.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>This is WebForm1</h1>
        </div>

        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>

        </table>

        <div>
            <asp:Button ID="Button1" runat="server" PostBackUrl="~/WebForm2.aspx" Text="Cross Page Postback - Webform2" />
        </div>
        <div>
            <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
