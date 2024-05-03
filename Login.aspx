<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PizzaFactory.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Welcome to PizzaFactory. Please Login Below.</h2>
	<asp:Label runat="server" Text="Email" />
	<asp:TextBox runat="server" Text="" ID="edtLoginEmail" />
	<br />
	<br />
	<asp:Label runat="server" Text="Password" />
	<asp:TextBox runat="server" Text="" ID="edtLoginPassword" />
	<br />
	<br />
	<asp:Button runat="server" Text="Login!" ID="btnLogin" OnClick="btnLogin_Click" />
</asp:Content>
