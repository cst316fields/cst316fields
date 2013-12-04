<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="showFieldsPage.aspx.cs" Inherits="FieldsProject.Pages.showFieldsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="container_main">

        <tr>
        
            <td class="container_button">

                <asp:Button CssClass="nav_button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Fields" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Reservations" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button3" runat="server" OnClick="Button3_Click" Text="My Reservations" />

            </td><td class="container_content">

                <asp:GridView ID="GridViewFieldPage" runat="server" OnSelectedIndexChanged="GridViewFieldPage_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="5px">
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
