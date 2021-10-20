<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="EventManagementSystem.LoginPage" %>
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
    <h2>Login Page</h2>
    <hr />

    <table class="auto-style1">
        
        <tr>
            
            <td>Email ID
                <asp:TextBox ID="txtloginemailid" runat="server" CssClass="txtInput"></asp:TextBox>
            </td>
      
        </tr>
        <tr>
            <td>Password
                <asp:TextBox ID="txtloginpassword" runat="server" TextMode="Password" CssClass="txtInput"></asp:TextBox>
                <br />
        <asp:Button ID="txtsubmit" runat="server" CssClass="txtButton" Text="Submit" OnClick="txtsubmit_Click" />
              <asp:Button ID="txtresetlogin" runat="server" CssClass="txtButton" PostBackUrl="~/LoginPage.aspx" Text="Reset" />
              
                <asp:Label ID="txtloginlabel" runat="server" Text=""></asp:Label>
                <br />
       <asp:Label ID="txtlabel" runat="server" Text="No Account ? "></asp:Label>
                <asp:HyperLink ID="txthyperlink" runat="server" ForeColor="#3333FF" NavigateUrl="~/UserRegistration.aspx">Create One !</asp:HyperLink>
                <br />
            </td>
       
        </tr>
    </table>
        </div>
</asp:Content>
