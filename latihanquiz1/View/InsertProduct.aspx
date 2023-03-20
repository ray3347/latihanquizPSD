<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu2.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="latihanquiz1.View.InsertProduct" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Insert Product</h1>
    <table>
        <tr>
            <td>Product Name</td>
            <td>
                <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Price</td>
            <td>
                <asp:TextBox ID="priceTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Image</td>
            <td>
                <asp:TextBox ID="imageTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Product Rating</td>
            <td>
                <asp:TextBox ID="ratingTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click" /></td>
        </tr>
    </table>
</asp:Content>
