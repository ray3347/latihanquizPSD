<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="latihanquiz1.View.Login" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div>
        <h1>Login</h1>
    </div>
    <div>
        <table>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:CheckBox ID="cookieTextBox" runat="server" Text="Remember Me" /></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="errorLabel" runat="server" Text="error" Visible="False" ForeColor="Red"></asp:Label></td>
                <td>
                    <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginBtn_Click"/></td>
            </tr>
        </table>
    </div>
</asp:Content>
