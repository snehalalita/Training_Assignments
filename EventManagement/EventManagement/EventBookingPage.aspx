<%@ Page  trace="true" Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="EventBookingPage.aspx.cs" Inherits="EventManagementSystem.EventBookingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="styles.css" type="text/css" rel="stylesheet"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
   
    <hr />
    <div id="cont">

    <h2>Event Booking Page</h2>
    
    <hr />
    <p>Event Type <asp:DropDownList ID="droplistEventType" runat="server" CssClass="txtInput"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>--Select--</asp:ListItem>
            <asp:ListItem>Birthday Party</asp:ListItem>
            <asp:ListItem>Wedding </asp:ListItem>
            <asp:ListItem>Naming Ceremony</asp:ListItem>
            <asp:ListItem>Thread Ceremony</asp:ListItem>
            <asp:ListItem>Corporate Event</asp:ListItem>
        </asp:DropDownList>
      
    </p>
    <p>Number Of Guest
        <asp:TextBox ID="txtnumberofguest" runat="server" CssClass="txtInput" ></asp:TextBox>
    </p>
    <p>Booking Date
        <asp:TextBox ID="txtbookingdate" runat="server" CssClass="txtInput" ></asp:TextBox>
&nbsp;<asp:Calendar ID="Calendar1" runat="server" style="margin-left:100px" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="#3333FF" Height="190px" NextPrevFormat="FullMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#05386b" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar></p><p>
        User ID
        <asp:TextBox ID="txtuserid" CssClass="txtInput" runat="server" ></asp:TextBox>

    </p>
         <p><asp:LinkButton ID="txtsubmitbooking" CssClass="txtButton" runat="server" OnClick="txtsubmitbooking_Click1" >Submit</asp:LinkButton>
    <asp:LinkButton ID="lbtncancelEvent" CssClass="txtButton" runat="server"  PostBackUrl="~/EventBookingPage.aspx">Cancel</asp:LinkButton>
    </p>
    <p>&nbsp;</p>
        </div>
</asp:Content>
