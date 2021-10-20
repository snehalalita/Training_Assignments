<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventInformation.aspx.cs" Inherits="EventManagementSystem.EventInformation" %>
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
    <h2>Event Information</h2>
    <p>
        <asp:GridView ID="gvEventInfo" runat="server" AutoGenerateColumns="False" OnRowCommand="gvEventInfo_RowCommand" OnRowDeleting="gvEventInfo_RowDeleting" OnRowEditing="gvEventInfo_RowEditing">
            <Columns>
                <asp:BoundField DataField="event_id" HeaderText="Event ID" />
                <asp:BoundField DataField="event_type" HeaderText="Event Type" />
                <asp:BoundField DataField="guests" HeaderText="Guests" />
                <asp:BoundField DataField="book_date" HeaderText="Booking Date" />
                <asp:BoundField DataField="user_id" HeaderText="User ID" />
            </Columns>
        </asp:GridView>
    </p>
    
        </div>
</asp:Content>
