<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="PizzaFactory.Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Cart</h2>
	<asp:Label ID="lblEmpty" runat="server" Text="Your shopping cart is currently empty. Please add items to your cart from the menu page." />
	<asp:DataGrid ID="dgCart" runat="server" />
	<br />
	<br />
	<asp:Button ID="btnSubmitOrder" runat="server" OnClick="btnSubmitOrder_Click" Text="Complete Order" />
	<asp:Button ID="btnClearCart" runat="server" OnClick="btnClearCart_Click" Text="Clear Cart" />
</asp:Content>
