<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="notificationPage.aspx.cs" Inherits="EventManagementSystem.notificationPage" %>
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
        <h2>Approval</h2>
        <hr />
    <p>
        <asp:GridView ID="gvnotification" runat="server" AutoGenerateColumns="False" OnRowCommand="gvnotification_RowCommand" OnRowDeleting="gvnotification_RowDeleting" OnRowEditing="gvnotification_RowEditing" >
            <Columns>
                <asp:BoundField DataField="booking_id" HeaderText="Booking ID" />
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
                <asp:TemplateField HeaderText="Approve">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnapprove" runat="server" CommandArgument='<%# Eval("booking_id") %>' CommandName="Approve">Approve</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reject">
                    <ItemTemplate>
                        <asp:LinkButton ID="lbtnreject" runat="server" CommandArgument='<%# Eval("booking_id") %>' CommandName="Reject">Reject</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
 
        </div>
</asp:Content>
