<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFWithAjaxClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
    <script src="https://ajax.aspnetcdn.com/ajax/jquery/jquery-3.4.1.js"></script>
    <%--<script src="jquery-3.4.1.js"></script>--%>
    
    <script>
        // Fallback to loading jQuery from a local path if the CDN is unavailable
        (window.jQuery || document.write('<script src="jquery-3.4.1.js"><\/script>'));
    </script>

    <script type="text/javascript">
        $(document).ready(
            $('#btnGetData').click(function () {
                var id = $('#txtID').val();

                $.ajax({
                    url: ''
                });
            })
        )
        

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>ID: </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" Width="400"></asp:TextBox></td>

            </tr>
            <tr>
                <td>Name:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="400"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Salary:</td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server" Width="400"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Width="400"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save Details" OnClick="btnSave_Click" /></td>
                <td>
                    <%--<asp:Button ID="btnGetData" runat="server" Text="Get Details" OnClientClick="" OnClick="btnGetData_Click"/></td>--%>
                    <asp:Button ID="btnGetData" runat="server" Text="Get Details" /></td>

            </tr>
            <tr>
                <td>Page Reload Check</td>
                <td>
                    <asp:Label ID="reloadCheck" runat="server"></asp:Label>

                </td>
            </tr>
        </table>
        <asp:Label ID="lblResult" runat="server"></asp:Label>

    </form>

</body>
</html>
