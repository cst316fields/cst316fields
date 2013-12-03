<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showReservationsPage.aspx.cs" Inherits="FieldsProject.Pages.showReservationsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fields" Width="118px" />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reservations" Width="117px" />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MyReservations" Width="116px" />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    <asp:GridView ID="GridViewShowResPage" runat="server" OnSelectedIndexChanged="GridViewShowResPage_SelectedIndexChanged">
    </asp:GridView>
</asp:Content>
