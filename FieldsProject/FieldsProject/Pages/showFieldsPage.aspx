<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showFieldsPage.aspx.cs" Inherits="FieldsProject.Pages.showFieldsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Fields" OnClick="Button1_Click" Width="111px" />








    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Reservations" Width="111px" />
&nbsp;<br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="MyReservations" Width="110px" />
    <br />
    <asp:GridView ID="GridViewFieldPage" runat="server" OnSelectedIndexChanged="GridViewFieldPage_SelectedIndexChanged">
    </asp:GridView>








</asp:Content>
