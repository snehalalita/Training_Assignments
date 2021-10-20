<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="UserInformation.aspx.cs" Inherits="EventManagementSystem.UserInformation" %>
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
    <h2>User Information</h2>
        <hr />
    <p>
        <asp:GridView ID="gvuserinfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvuserinfo_RowCommand" OnRowDeleting="gvuserinfo_RowDeleting" OnRowEditing="gvuserinfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:BoundField DataField="first_name" HeaderText="Name" />
                <asp:BoundField DataField="email" HeaderText="Email ID" />
                <asp:BoundField DataField="address" HeaderText="Address" />
            </Columns>
        </asp:GridView>
        <br />
   </div>
</asp:Content>
