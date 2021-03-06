﻿using Service1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class showReservationsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now)
            {
                e.Cell.BackColor = ColorTranslator.FromHtml("#a9a9a9");
                e.Day.IsSelectable = false;
            }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("showReservationsPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("showFieldsPage.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (this.Session["userName"] != null)
                Page.Response.Redirect("MyReservations.aspx");
            Page.Response.Redirect("Login.aspx");
        }

        protected void GridViewShowResPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownShowResPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            GridViewShowResPage.DataSource = new DataService().getReservationsByDate(new DateTime(Calendar1.SelectedDate.Year,
                Calendar1.SelectedDate.Month, Calendar1.SelectedDate.Day, 0, 0, 0));
            GridViewShowResPage.DataBind();
            Calendar1.Visible = false;
        }
    }
}