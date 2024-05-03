<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="PizzaFactory.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<h2>Welcome to PizzaFactory. Please Sign Up Below.</h2>
	<asp:Label runat="server" Text="Name" />
	<asp:TextBox runat="server" Text="" ID="edtName" />
	<br />
	<br />
	<asp:Label runat="server" Text="Email" />
	<asp:TextBox runat="server" Text="" ID="edtSignUpEmail" />
	<br />
	<br />
	<asp:Label runat="server" Text="Password" />
	<asp:TextBox runat="server" Text="" ID="edtSignUpPassword" />
	<br />
	<br />
	<asp:Label runat="server" Text="Confirm Password" />
	<asp:TextBox runat="server" Text="" ID="edtSignUpConfirm" />
	<br />
	<br />
	<asp:Button runat="server" Text="Sign Up!" ID="btnSignUp" OnClick="btnSignUp_Click" />
</asp:Content>
