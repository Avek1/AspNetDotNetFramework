<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Part_57_OpenNewWindowUsingJavaScript.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Training Demo</title>
    <script type="text/javascript">
        function OpenNewWindow() {
            var Name = document.getElementById('txtName').value;
            var Email = document.getElementById('txtEmail').value;

            window.open('WebForm2.aspx?NameOfUser=' + Name + '&Email=' + Email, '_blank', 'location=no, resizable=no', false)
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td colspan="2">
                    <h1>This is WebForm1</h1>
                </td>
            </tr>
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

            <tr>
                <td colspan="2">
                    <input id="Button1" onclick="OpenNewWindow()" style="width: 300px" type="button" value="HTML Button - Window.Open" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button2" OnClientClick="OpenNewWindow()" runat="server" Text="ASP.NET Button - Window.Open" Width="300px" />
                </td>
            </tr>
                <tr>
                <td colspan="2">
                    <asp:Button ID="Button3" runat="server" Text="ASP.NET Button - Server Side" Width="300px" OnClick="Button3_Click" />
                </td>
            </tr>
        </table>

        <div>
        </div>
    </form>
</body>
</html>
