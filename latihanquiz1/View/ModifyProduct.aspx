<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu2.Master" AutoEventWireup="true" CodeBehind="ModifyProduct.aspx.cs" Inherits="latihanquiz1.View.ModifyProduct" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div>
        <h1>Modify Products</h1>
    </div>
    <div>
        <asp:GridView ID="productsGridView" runat="server" AutoGenerateColumns="False" OnRowDeleting="productsGridView_RowDeleting" OnRowEditing="productsGridView_RowEditing">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowEditButton="True" />
                <asp:BoundField DataField="ProductId" HeaderText="ID Product" SortExpression="ProductId" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Price" SortExpression="ProductPrice" />
                <asp:BoundField DataField="ProductImage" HeaderText="Image" SortExpression="ProductImage" />
                <asp:BoundField DataField="ProductRating" HeaderText="Rating" SortExpression="ProductRating" />
                
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                
                
                
            </Columns>
        </asp:GridView>
       
    </div>
    <div>
        <table>
            <tr>
                <td>Product Id</td>
                <td>
                    <asp:TextBox ID="idTextBox" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product Name</td>
                <td>
                    <asp:TextBox ID="nameTextBox" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product Price</td>
                <td>
                    <asp:TextBox ID="priceTextBox" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Product Image</td>
                <td>
                    <asp:TextBox ID="imageTextBox" runat="server" Enabled="false"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Product Rating</td>
                <td>
                    <asp:TextBox ID="ratingTextBox" runat="server" Enabled="false"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" Enabled="false" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
</asp:Content>

