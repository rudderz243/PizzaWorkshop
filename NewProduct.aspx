<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewProduct.aspx.cs" Inherits="PizzaFactory.NewProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<asp:Label ID="lblWarning" Text="You are not authorized to view this page. Go away." runat="server"></asp:Label>
	<div runat="server" id="divAdd">
		<h2>Add a New Product</h2>
		<asp:Label runat="server" Text="Product Name: " />
		<asp:TextBox runat="server" Text="" ID="txtName" />
		<br />
		<br />
		<asp:Label runat="server" Text="Product Description: " />
		<asp:TextBox runat="server" Text="" ID="txtDescription" />
		<br />
		<br />
		<asp:Label runat="server" Text="Product Price: " />
		<asp:TextBox runat="server" Text="" ID="txtPrice" />
		<br />
		<br />
		<asp:Label runat="server" Text="Product Image URL: " />
		<asp:TextBox runat="server" Text="" ID="txtURL" />
		<br />
		<br />
		<asp:Button ID="btnAddProduct" runat="server" Text="Add New Product" OnClick="btnAddProduct_Click" />
	</div>
</asp:Content>
