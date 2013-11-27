<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FieldsProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="FieldsButton" runat="server" OnClick="Fields_Click" Text="Fields" /><br />
    <asp:Button ID="ReservationsButton" runat="server" OnClick="Reservations_Click" Text="Reservations" /><br />
    <asp:Button ID="MyReservationsButton" runat="server" OnClick="MyReservations_Click" Text="My Reservations" /><br />
  
</asp:Content>
