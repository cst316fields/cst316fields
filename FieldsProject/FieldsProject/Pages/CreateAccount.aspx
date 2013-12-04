<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="FieldsProject.Pages.CreateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container_content">

        <div class="form_container">

            <div style="width: 100%; text-align: center; font-size: large; color: #333333">Creating a new user.</div>

            <br />
            
            <table class="form_container">

                <tr>

                    <td class="form_text">User Name:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreateNameText" runat="server"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td class="form_text">Phone Num:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreatePhoneText" runat="server" OnTextChanged="CreatePhoneText_TextChanged"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td class="form_text">Email:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreateEmailText" runat="server" OnTextChanged="CreateEmailText_TextChanged"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td class="form_text">Password:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreatePassText" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td class="form_text">Reenter Pass:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreateRePassText" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr>

            </table>

            <br />

            <table>
                <tr>
                    <td>
                        <asp:Button CssClass="nav_button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Create" />
                    </td>
                    <td>
                        <asp:Button CssClass="nav_button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" />
                    </td>
                </tr>
            </table>

        </div>

    </div>

</asp:Content>
