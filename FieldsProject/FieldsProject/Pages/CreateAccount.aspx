<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="FieldsProject.Pages.CreateAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <p>
        User name :&nbsp;
        <asp:TextBox ID="CreateNameText" runat="server" Width="194px"></asp:TextBox>
    </p>
    <p>
        Phone Num:&nbsp;
        <asp:TextBox ID="CreatePhoneText" runat="server" Width="192px" OnTextChanged="CreatePhoneText_TextChanged"></asp:TextBox>
    </p>
    <p>
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="CreateEmailText" runat="server" Width="201px"></asp:TextBox>
    </p>
    <p>
        Password:&nbsp;&nbsp;
        <asp:TextBox ID="CreatePassText" runat="server" TextMode="Password" Width="201px"></asp:TextBox>
    </p>
    <p>
        Reenter pass:&nbsp;
        <asp:TextBox ID="CreateRePassText" runat="server" TextMode="Password" Width="204px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go" Width="88px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Exit" Width="109px" />
    </p>



</asp:Content>
