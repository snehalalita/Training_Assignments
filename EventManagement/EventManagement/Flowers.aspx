<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="Flowers.aspx.cs" Inherits="EventManagementSystem.Flowers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="styles.css" type="text/css" rel="stylesheet"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <div id="cont">
    <h2>Flowers</h2>
    <p>Rose&nbsp;
        <asp:Image ID="Image1" runat="server" Height="86px" ImageUrl="~/images/heart-roses-valentines-day-made-red-isolated-white-background-36600776.jpg" Width="112px" />
        Cost:<asp:Label ID="txtrosecost" runat="server" CssClass="txtLabel" Text="1000"></asp:Label>
        <asp:CheckBox ID="txtheckboxrose" runat="server" OnCheckedChanged="txtheckboxrose_CheckedChanged" Text="Select Rose" />
 </p><p>Marigold&nbsp;
        <asp:Image ID="Image2" runat="server" Height="77px" ImageUrl="~/images/pexels-photo-1031628.jpeg" style="margin-right: 43px; margin-top: 0px" Width="100px" />
       Cost:<asp:Label ID="txtmarigoldcost" runat="server" CssClass="txtLabel" Text="950"></asp:Label>
        <asp:CheckBox ID="txtselectmarigold" runat="server" OnCheckedChanged="txtselectmarigold_CheckedChanged" Text="Select Marigold" />
    </p>
   
    <p>Event ID
        <asp:TextBox ID="txteventidflowers" runat="server" CssClass="txtInput"></asp:TextBox>
    </p>
    <p>User ID
        <asp:TextBox ID="txtuseridflowers" runat="server" CssClass="txtInput"></asp:TextBox>
    </p>
    <p><asp:Button ID="txtsubmitflowers" runat="server" CssClass="txtButton" OnClick="txtsubmitflowers_Click" Text="Submit" />
            </p>
        </div>
</asp:Content>
