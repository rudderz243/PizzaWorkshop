<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PizzaFactory.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Send Us a Message!</h2>
	<div class="row">
		<div class="column">
			<asp:Label Text="Email" runat="server" />
			<asp:TextBox Text="" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Label Text="Subject" runat="server" />
			<asp:TextBox Text="" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Label Text="Message" runat="server" />
			<asp:TextBox TextMode="MultiLine" runat="server" CssClass="form-control"></asp:TextBox>
			<br />
			<asp:Button Text="Send" runat="server" CssClass="btn btn-primary" />
		</div>
		<div class="column">
			<asp:Image ImageUrl="https://t3.ftcdn.net/jpg/06/11/01/26/360_F_611012694_YztSwcyDjHflPhlil3LfeSDXMtew2Scy.jpg" runat="server" />
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
	<h2>Additional Contact Details</h2>
	<address>
		1 Ring Road<br />
		Port Elizabeth, ZA, 6001<br />
		<abbr title="Phone">Phone:</abbr>
		+27 (041) - 111 - 1111
	</address>
</asp:Content>
