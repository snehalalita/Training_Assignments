<%@ Page Title="" Language="C#" MasterPageFile="~/eventmanagement.Master" AutoEventWireup="true" CodeBehind="food_order_details.aspx.cs" Inherits="EventManagementSystem.food_order_details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <link href="styles.css" type="text/css" rel="stylesheet"/>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="cont">
    <h2>Food Order Page</h2>
        <hr />

    <p>Food Type

        <asp:RadioButton ID="txtveg" runat="server" ForeColor="#3333FF"  Text="Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtveg_CheckedChanged" />
        <asp:RadioButton ID="txtnonveg" runat="server" ForeColor="#3333FF" Text="Non Veg" AutoPostBack="True" GroupName="FoodGroup" OnCheckedChanged="txtnonveg_CheckedChanged" />

        </p>
    <p>Meal Type <asp:RadioButton ID="txtlunch" runat="server" ForeColor="#3333FF" Text="Lunch" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtlunch_CheckedChanged" />
        <asp:RadioButton ID="txtdinner" runat="server" ForeColor="#3333FF" Text="Dinner" AutoPostBack="True" GroupName="MealGroup" OnCheckedChanged="txtdinner_CheckedChanged" />

        </p>
    <p>Dish Type
        <asp:CheckBox ID="txtSouthindian" runat="server" ForeColor="#3333FF" Text="South Indian" OnCheckedChanged="txtSouthindian_CheckedChanged" />
<asp:CheckBox ID="txtNorthindian" runat="server" ForeColor="#3333FF" Text="North Indian" OnCheckedChanged="txtNorthindian_CheckedChanged" />
   <asp:CheckBox ID="txtpunjabi" runat="server" ForeColor="#3333FF" Text="Punjabi " OnCheckedChanged="txtpunjabi_CheckedChanged" />
        &nbsp;</p>
    <p>User ID
        <asp:TextBox ID="txtuseridfood" runat="server" CssClass="txtInput"></asp:TextBox>
    </p>
    <p>Event ID
        <asp:TextBox ID="txteventidfood" runat="server" CssClass="txtInput"></asp:TextBox>
    </p>
    <p><asp:Button ID="txtbookfood" runat="server" CssClass="txtButton" Text="Book Food" OnClick="txtbookfood_Click" />
       <asp:Button ID="txtcancelfoodorder" runat="server" CssClass="txtButton" PostBackUrl="~/FoodOrder.aspx" Text="Cancel" />
       <asp:Button ID="btnorderflowers" runat="server" CssClass="txtButton" OnClick="btnorderflowers_Click" Text="Click To Order Flowers" />
      </p> </div>
</asp:Content>
