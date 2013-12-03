<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelReservation.aspx.cs" Inherits="FieldsProject.Pages.CancelReservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Make" Width="122px" />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="126px" />
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Main Menu" Width="126px" />
    <br />
    <asp:GridView ID="GridViewResCancel" runat="server">
    </asp:GridView>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="162px">
    </asp:DropDownList>


</asp:Content>
