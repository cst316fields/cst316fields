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

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorUser" runat="server"
                            ControlToValidate="CreateNameText"
                            ErrorMessage="User Name is a required field.">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr><tr>

                    <td class="form_text">Phone Num:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreatePhoneText" runat="server" OnTextChanged="CreatePhoneText_TextChanged"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorPhone" runat="server"
                            ControlToValidate="CreatePhoneText"
                            ErrorMessage="Phone number is a required field.">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr><tr>

                    <td class="form_text">Email:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreateEmailText" runat="server" OnTextChanged="CreateEmailText_TextChanged"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorEmail" runat="server"
                            ControlToValidate="CreateEmailText"
                            ErrorMessage="Email is a required field.">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr><tr>

                    <td class="form_text">Password:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreatePassText" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:RequiredFieldValidator id="RequiredFieldValidatorPass" runat="server"
                            ControlToValidate="CreatePassText"
                            ErrorMessage="Password is a required field.">
                        </asp:RequiredFieldValidator>
                    </td>

                </tr><tr>

                    <td class="form_text">Reenter Pass:
                    </td>
                    <td class="form_field">
                        <asp:TextBox ID="CreateRePassText" runat="server" TextMode="Password"></asp:TextBox>
                    </td>

                </tr><tr>

                    <td></td>
                    <td class="validate">
                        <asp:CompareValidator id="CompareFieldValidatorRePass" runat="server"
                           ControlToValidate="CreateRePassText"
                           ControlToCompare="CreatePassText"
                           Type="String"
                           Operator="Equal"
                           ErrorMessage="Passwords must match">
                        </asp:CompareValidator >
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
                        <asp:Button CssClass="nav_button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel" CausesValidation="false" />
                    </td>
                </tr>
            </table>

        </div>

    </div>

</asp:Content>
