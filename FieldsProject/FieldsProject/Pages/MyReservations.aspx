<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyReservations.aspx.cs" Inherits="FieldsProject.Pages.MyReservations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="container_main">

        <tr>

            <td class="container_button">

                <asp:Button CssClass="nav_button" ID="Button4" runat="server" OnClick="Button1_Click" Text="Make Reservation" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button5" runat="server" OnClick="Button2_Click" Text="Cancel Reservation" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button6" runat="server" OnClick="Button3_Click" Text="Main Menu" />

            </td><td class="container_content">

                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="5px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>

            </td>

        </tr>

    </table>

</asp:Content>
