<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PizzaFactory.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Our Signature Menu</h2>
	<div class="row">
		<div class="column">
			<h3>Pepperoni Pizza</h3>
			<asp:Image runat="server" ImageUrl="https://e7.pngegg.com/pngimages/935/770/png-clipart-pizza-pizza.png" Height="100" Width="100" />
			<p>Our signature pepperoni pizza is made with the finest ingredients and cooked to perfection.</p>
			<p>Price: $10.99</p>
			<asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="Button1_Click" />


		</div>
		<div class="column">
			<h3>Vegetarian Pizza</h3>
			<asp:Image runat="server" ImageUrl="https://e7.pngegg.com/pngimages/935/770/png-clipart-pizza-pizza.png" Height="100" Width="100" />
			<p>Our vegetarian pizza is made with the freshest vegetables and cooked to perfection.</p>
			<p>Price: $12.99</p>
			<asp:Button ID="Button2" runat="server" Text="Add to Cart" OnClick="Button2_Click" />
		</div>
		<div class="column">
			<h3>Meat Lovers Pizza</h3>
			<asp:Image runat="server" ImageUrl="https://e7.pngegg.com/pngimages/935/770/png-clipart-pizza-pizza.png" Height="100" Width="100" />
			<p>Our meat lovers pizza is made with the finest meats and cooked to perfection.</p>
			<p>Price: $14.99</p>
			<asp:Button ID="Button3" runat="server" Text="Add to Cart" OnClick="Button3_Click" />
		</div>
	</div>
	<style>
		.column {
			float: left;
			width: 33.33%;
			padding: 10px;
			height: 300px;
		}

		.row::after {
			content: "";
			clear: both;
			display: table;
		}
	</style>
</asp:Content>
