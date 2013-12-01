<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FieldsProject._Default" %>

<asp:Content class="container_main" ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container_button">
            <asp:Button class="nav_button" ID="FieldsButton" runat="server" OnClick="Fields_Click" Text="Fields"/>
            <br />
            <asp:Button class="nav_button" ID="ReservationsButton" runat="server" OnClick="Reservations_Click" Text="Reservations"/>
            <br />
            <asp:Button class="nav_button" ID="MyReservationsButton" runat="server" OnClick="MyReservations_Click" Text="My Reservations"/>
            <!-- Not sure what this textbox is for, but uncomment it if you still need it.
                <br />
                <asp:TextBox ID="TestTextBox" runat="server" Width="252px"></asp:TextBox> -->
        </div>

        <div class="container_content">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" BorderColor="#5D7B9D" BorderWidth="5px">
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
        </div>
  
</asp:Content>
