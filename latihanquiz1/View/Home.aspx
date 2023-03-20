<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="latihanquiz1.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentBody" runat="server">
      <h1>Mukicik</h1>
    <div>
        <p>Lorem ipsum dolores sit amet</p>
    </div>
    <div>
        <asp:Button ID="registerBtn" runat="server" Text="Be a New Member" OnClick="registerBtn_Click" />
    </div>
    <div>
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
    </div>
 
</asp:Content>

