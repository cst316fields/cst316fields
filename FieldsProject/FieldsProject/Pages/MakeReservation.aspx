<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakeReservation.aspx.cs" Inherits="FieldsProject.Pages.MakeReservation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Make" Width="141px" />
&nbsp;&nbsp;&nbsp; field Id
    <asp:TextBox ID="makeReservationTextBox" runat="server" Width="194px"></asp:TextBox>
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" Width="136px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Main Menu" Width="140px" />
    <asp:Calendar ID="calendarMakeRes" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    <asp:DropDownList ID="DropDownList1" runat="server" Width="201px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="8">8:00am to 10:00am</asp:ListItem>
        <asp:ListItem Value="10">10:00am to 12:00pm</asp:ListItem>
        <asp:ListItem Value="12">12:00pm to 2:00pm</asp:ListItem>
        <asp:ListItem Value="14">2:00pm to 4:00pm</asp:ListItem>
        <asp:ListItem Value="16">4:00pm to 6:00pm</asp:ListItem>
        <asp:ListItem Value="18">6:00pm to 8:00pm</asp:ListItem>
        <asp:ListItem Value="20">8:00pm to 10:00pm</asp:ListItem>
        <asp:ListItem></asp:ListItem>
    </asp:DropDownList>
&nbsp;<br />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Accept" Width="168px" />


</asp:Content>
