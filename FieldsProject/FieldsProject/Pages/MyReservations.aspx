<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyReservations.aspx.cs" Inherits="FieldsProject.Pages.MyReservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Make" Width="118px" />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="118px" />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Main Menu" Width="120px" />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />




</asp:Content>
