<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FieldsProject.Pages.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">




    <p>
        User Name:&nbsp;
        <asp:TextBox ID="LoginUserText" runat="server" Width="208px"></asp:TextBox>
    </p>
    <p>
        Password:&nbsp;&nbsp;
        <asp:TextBox ID="LoginPassText" runat="server" Width="214px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="139px" />
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create" Width="142px" />
    </p>




</asp:Content>
