<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderHistory.aspx.cs" Inherits="PizzaFactory.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Order History</h2>
	<asp:DataGrid ID="dgOrder" runat="server" />
	<br />
	<br />
	<asp:Label runat="server" ID="lblOrderSelect" Text="Select an Order to Edit: " />
	<asp:DropDownList ID="ddlOrderSelection" runat="server" />
	<br />
	<asp:Label runat="server" ID="lblOrderUpdate" Text="Select what you would like to mark the order as: " />

	<asp:DropDownList ID="ddlOrderUpdate" runat="server">
		<asp:ListItem Text="open" />
		<asp:ListItem Text="in progress" />
		<asp:ListItem Text="completed" />
	</asp:DropDownList>
	<br />
	<br />
	<asp:Button runat="server" ID="btnUpdateOrder" Text="Update Order" OnClick="btnUpdateOrder_Click" />
</asp:Content>
