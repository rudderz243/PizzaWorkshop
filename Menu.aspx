<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PizzaFactory.Menu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Our Signature Menu</h2>
	<div class="row">
		<asp:Repeater ID="pizzaRepeater" runat="server">
			<ItemTemplate>
				<div class="column">
					<h2><%# Eval("name") %></h2>
					<asp:Image runat="server" ImageUrl='<%# Eval("imageURL") %>' Height="150" Width="150" />
					<p>
						<%# Eval("description") %>
					</p>
					<p>
						Price: R<%# Eval("price") %>
					</p>
					<asp:Button runat="server" Text="Add to Cart" ID="btnAddToCart" OnCommand="btnAddToCart_Command" OnClick="btnAddToCart_Click" CommandArgument='<%# Eval("pizzaID") %>' />
				</div>
			</ItemTemplate>
		</asp:Repeater>

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
