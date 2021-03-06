﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FieldsProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="container_main">

        <tr>
        
            <td class="container_button">

                <asp:Button CssClass="nav_button" ID="FieldsButton" runat="server" OnClick="Fields_Click" Text="Fields"/>
                <br />
                <asp:Button CssClass="nav_button" ID="ReservationsButton" runat="server" OnClick="Reservations_Click" Text="Reservations" />
                <br />
                <asp:Button CssClass="nav_button" ID="MyReservationsButton" runat="server" OnClick="MyReservations_Click" Text="My Reservations" />

            </td><td class="container_content">

                <p style="margin: 20px">
                    <span style="color: #333333; font-size: large">Welcome to Parks and Recreation.</span>
                    <br />
                    <br />
                    Make a selection on the left to view fields and their availability, make reservations or to check your existing reservations.
                </p>

            </td>

        </tr>
        <tr>
            <td>
                <hr />
            </td>
            <td>
                <hr />
            </td>
            <td>
                <hr />
            </td>
            <td>
                <hr />
            </td>
        </tr> 
        <tr>
            <td>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/baseball.jpg" />                
            </td>
            <td>
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/football.jpg" />
            </td>
            <td>
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/soccer.jpg" />
            </td>
            <td>
                <asp:Image ID="Image4" runat="server" ImageUrl="~/images/softball.jpg" />
            </td>

        </tr>

    </table>
  
</asp:Content>
