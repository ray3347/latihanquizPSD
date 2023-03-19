<%@ Page Title="" Language="C#" MasterPageFile="~/View/Menu1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="latihanquiz1.View.Register" %>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="title">
        <h1>Register</h1>
    </div>
   
        <table>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox runat="server" ID="emailTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox runat="server" ID="nameTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox runat="server" ID="passTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Confirm Password</td>
                <td>
                    <asp:TextBox runat="server" ID="confirmPassTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButton runat="server" groupname="apakek" text="Male" ID="maleRadio" value="1"></asp:RadioButton>
                    <asp:RadioButton runat="server" groupname="apakek" text="Female" ID="femaleRadio" value="2"></asp:RadioButton>
                </td>
            </tr>
            <tr>
                <td>Date of Birth</td>
                <td>
                    <asp:Calendar runat="server" ID="dobCalendar"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td></td>
                <td contenteditable="false">
                    <asp:TextBox runat="server" Enabled="False" ID="dobTextBox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Profile Picture</td>
                <td>
                    <asp:FileUpload runat="server" ID="proFile"></asp:FileUpload>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:CheckBox runat="server" text="I agree to terms and conditions" ID="tocCheckBox"></asp:CheckBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="error" ID="errorLabel" ForeColor="Red" Visible="False"></asp:Label>
                </td>
                <td>
                    <asp:Button runat="server" Text="Register" ID="regBtn" onclick="regBtn_Click"/>
                </td>
            </tr>
        </table>

</asp:Content>
