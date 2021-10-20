<%@ Page Trace="true" Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="EventManagementSystem.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
     <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="Styles.css" type="text/css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="cont">
    <h2>My Profile</h2>
        <hr/>
    <p>Name
        <asp:Label ID="lblname" runat="server" Text="Label" CssClass="txtInput"></asp:Label>
    </p>
    <p>EmailID
        <asp:Label ID="lblemail" runat="server" Text="Label" CssClass="txtInput"></asp:Label>
    </p>
    <p>Phone
        <asp:Label ID="lblphone" runat="server" Text="Label" CssClass="txtInput"></asp:Label>
    </p>
    <p>Address
        <asp:Label ID="lbladdress" runat="server" Text="Label" CssClass="txtInput"></asp:Label>
    </p>
    <p>Events
        <asp:Button ID="btnevents" runat="server" CssClass="txtButton" OnClick="btnevents_Click" Text="Events" />
    </p>
    </div>
</asp:Content>
