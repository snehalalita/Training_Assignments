<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="AdminAccess.aspx.cs" Inherits="EventManagementSystem.UserInfo" %>
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
    <p>

        <asp:Button ID="txtnotification" runat="server" CssClass="txtButton" OnClick="txtnotification_Click" Text="Notification" />

        <asp:Label ID="lblnotification" runat="server"></asp:Label>
        <asp:Button ID="btnuserinfo" runat="server" CssClass="txtButton" Text="User Information" Width="153px" OnClick="btnuserinfo_Click" />
      <asp:Button ID="btneventinfo" runat="server"  CssClass="txtButton" Text="Event Information" Width="168px" OnClick="btneventinfo_Click" />

        <br />
    </div>
</asp:Content>
