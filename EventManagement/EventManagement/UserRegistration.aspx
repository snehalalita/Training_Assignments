<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="EventManagementSystem.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="Styles.css" type="text/css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="navbar navbar-inverse">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand" runat="server" href="~/">Event Management</a>
                </div>
            </div>
        </div><hr />
    <div id="cont">
    <h2>User Registration</h2>
    <hr />
    <p>&nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td>FirstName</td>
                <td><asp:TextBox ID="txtuserfirstname" runat="server" CssClass="txtInput"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>LastName</td>
                <td>
                <asp:TextBox ID="txtuserlastname" runat="server" CssClass="txtInput"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>EmailID</td>
                <td>
                <asp:TextBox ID="txtuseremailid" runat="server" CssClass="txtInput" ></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td>Password</td>
                <td>
                <asp:TextBox ID="txtuserpassword" runat="server" TextMode="Password" CssClass="txtInput"></asp:TextBox>
            </td>
    
        </tr>
        <tr>
            <td>Phone</td>
                <td>
                <asp:TextBox ID="txtuserphone" runat="server" CssClass="txtInput"></asp:TextBox>
            </td>
       
        </tr>
        <tr>
            <td>Address</td>
                <td>
                <asp:TextBox ID="txtuseraddress" runat="server" CssClass="txtInput"></asp:TextBox>
                <br />
                <asp:Label ID="lbluser" runat="server" Text="User" Visible="false"></asp:Label>
</td>
            
        </tr>
        <tr >
            <td colspan="2">
                <asp:Button ID="txtusersubmit" runat="server" CssClass="txtButton" Text="Submit" OnClick="txtusersubmit_Click" />
                <asp:Button ID="txtuserreset" runat="server" CssClass="txtButton" Text="Reset" />
            </td>
     
        </tr>
    </table>
        </div>
</asp:Content>
