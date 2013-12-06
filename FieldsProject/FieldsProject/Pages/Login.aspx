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
                        <asp:TextBox ID="LoginUserText" runat="server"></asp:TextBox>
                    </td>
                     
                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorLogUser" runat="server"
                            ControlToValidate="LoginUserText"
                            ErrorMessage="User name is a required field.">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr><tr>

                    <td class="form_text">Password:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="LoginPassText" runat="server" TextMode ="Password"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorLogPass" runat="server"
                            ControlToValidate="LoginPassText"
                            ErrorMessage="Password is a required field."
                            ForeColor="Red">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr>

            </table>

            <br />

            <div style="text-align: center">or <asp:LinkButton runat="server" CausesValidation ="false" OnClick="CreateNew_Click">Create a New Account</asp:LinkButton>.</div>

            <br />

            <table>
                <tr>
                    <td>
                        <asp:Button CssClass="nav_button" ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Login" />
                    </td>
                    <td>
                        <asp:Button CssClass="nav_button" ID="ButtonCancel" runat="server" CausesValidation="false" OnClick="ButtonCancel_Click" Text="Cancel" />
                    </td>
                </tr>
            </table>

        </div>

    </div>

</asp:Content>
