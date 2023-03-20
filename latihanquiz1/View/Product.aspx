<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu1.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="latihanquiz1.View.Product" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <h1>Our Products</h1>
    <table>
     <%foreach (var p in products)
            { %>
                <tr>
                    <td><%= p.ProductName %></td>
                    <td><%= p.ProductRating %></td>
                    <td><%= p.ProductPrice %></td>
                </tr>
        <%  } %>
    </table>
   
</asp:Content>
