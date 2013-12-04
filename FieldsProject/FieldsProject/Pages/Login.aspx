<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FieldsProject.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container_content">

        <div class="form_container">

            <div style="width: 100%; text-align: center; font-size: large; color: #333333">Please enter your login information.</div>

            <br />
            
            <table class="form_container">

                <tr>

                    <td class="form_text">User Name:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td class="form_text">Password:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>

                </tr>

            </table>

            <br />

            <table>
                <tr>
                    <td>
                        <asp:Button CssClass="nav_button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                    </td>
                    <td>
                        <asp:Button CssClass="nav_button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Create" />
                    </td>
                </tr>
            </table>

        </div>

    </div>

</asp:Content>
