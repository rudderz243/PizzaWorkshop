<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PizzaFactory._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<h2>Welcome to the PizzaFactory Website!</h2>
	<div class="row">
		<div class="column">
			View our menu at by navigating to the Menu page, or place an order by navigating to the Order page.
			<br />
			PizzaFactory was founded in 2024 by a computer science graduate, after not being able to find a job in the IT industry.
			<br />
			<br />
			We are a small business that is dedicated to providing the best pizza in the world. We use only the freshest ingredients and our dough is made fresh daily. We have a variety of toppings to choose from, so you can create your own custom pizza. We also have a selection of specialty pizzas that are sure to please any palate.
		</div>
		<div class="column">
			<asp:Image ID="Image1" runat="server" ImageUrl="https://imageio.forbes.com/specials-images/imageserve/5f974a4f5210e336503abf92/Baked-tasty-margherita-pizza-in-Traditional-wood-oven-in-Naples-restaurant--Italy-/960x0.jpg?format=jpg&width=960" Width="480" Height="400" />
		</div>
	</div>
	<style>
		.row {
			display: flex;
			flex-wrap: wrap;
			justify-content: space-between;
		}

		.column {
			flex: 1;
			margin: 0 1em;
		}
	</style>

</asp:Content>
