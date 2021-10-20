<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="EventManagementSystem.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="styles.css" type="text/css" rel="stylesheet"/>

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
    <h2>Admin Login</h2>
        <hr />
    <p>LoginID
        <asp:TextBox ID="txtadminloginid" runat="server" CssClass="txtInput"></asp:TextBox>
    </p>
    <p>Password
        <asp:TextBox ID="txtadminpassword" runat="server" TextMode="Password" CssClass="txtInput"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="txtadminsubmit" runat="server" CssClass="txtButton" OnClick="txtadminsubmit_Click" Text="Submit" />
        <asp:Button ID="txtadminreset" runat="server" CssClass="txtButton" PostBackUrl="~/AdminLogin.aspx" Text="Reset" />
 </p>
        </div>
</asp:Content>
