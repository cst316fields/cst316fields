<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MakeReservation.aspx.cs" Inherits="FieldsProject.Pages.MakeReservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table class="container_main">

        <tr>

            <td class="container_button">

                <asp:Button CssClass="nav_button" ID="Button1" runat="server" OnClick="Button1_Click" Text="Make Reservation" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Cancel Reservation" />
                <br />
                <asp:Button CssClass="nav_button" ID="Button3" runat="server" OnClick="Button3_Click" Text="Main Menu" />

            </td>
            <td class="container_content">

                <div class="make_reservation_container">

                    <table class="form_container">

                        <tr>

                            <td class="form_text" style="font-weight: bold; color: #333333">Field Id:</td>
                            <td class="form_field">
                                <asp:DropDownList ID="makeReservationTextBox" runat="server"></asp:DropDownList>
                            </td>

                        </tr>

                    </table>

                    <br />

                    <asp:Calendar ID="calendarMakeRes" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender" BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="5px" ForeColor="#333333" BackColor="White">
                        <DayHeaderStyle BackColor="#5D7B9D" ForeColor="White" />
                        <NextPrevStyle BorderColor="#5D7B9D" BorderWidth="5px" ForeColor="White" />
                        <TitleStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    </asp:Calendar>

                    <br />

                    <div class="centered">

                        <asp:DropDownList style="width: 100%" ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Value="8">8:00am to 10:00am</asp:ListItem>
                            <asp:ListItem Value="10">10:00am to 12:00pm</asp:ListItem>
                            <asp:ListItem Value="12">12:00pm to 2:00pm</asp:ListItem>
                            <asp:ListItem Value="14">2:00pm to 4:00pm</asp:ListItem>
                            <asp:ListItem Value="16">4:00pm to 6:00pm</asp:ListItem>
                            <asp:ListItem Value="18">6:00pm to 8:00pm</asp:ListItem>
                            <asp:ListItem Value="20">8:00pm to 10:00pm</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                        </asp:DropDownList>

                        <br />
                        <br />

                        <asp:Button CssClass="nav_button" style="width: 100%" ID="Button4" runat="server" OnClick="Button4_Click" Text="Reserve" />

                    </div>

                </div>

            </td>
            <td class="far_right_content">

                <asp:GridView ID="GridViewFieldPage" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" BorderColor="#5D7B9D" BorderStyle="Solid" BorderWidth="5px">
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
