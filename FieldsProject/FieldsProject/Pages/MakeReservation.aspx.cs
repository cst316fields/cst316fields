using Service1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class MakeReservation : System.Web.UI.Page
    {
        private bool calendarChanged = false;
        private bool timeChanged = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["userName"] == null || !new DataService().authenticateUser((string)this.Session["userName"], (string)this.Session["password"]))
                Page.Response.Redirect("../default.aspx");
            // Or set this to only get a few fields to cut down on width of gridview.
            GridViewFieldPage.DataSource = new DataService().getAllFields();
            GridViewFieldPage.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if(checkForm())
            {
                new DataService().addReservation(Convert.ToInt32(makeReservationTextBox.Text),(string)this.Session["userName"],
                    new DateTime(calendarMakeRes.SelectedDate.Year,calendarMakeRes.SelectedDate.Month,
                    calendarMakeRes.SelectedDate.Day, Convert.ToInt32(DropDownList1.SelectedValue), 0,0));
                Page.Response.Redirect("MyReservations.aspx");
            }
            else 
            {
                //clearing fields by reloading the page, bad selection made
                Page.Response.Redirect("MakeReservation.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MakeReservation.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("../default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CancelReservation.aspx");
        }

        private bool checkForm()
        {
            bool good = false;
            if (makeReservationTextBox.Text != string.Empty) 
                good = true;
            if (calendarChanged)
                good = true;
            if (timeChanged)
                good = true;
            return good;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            calendarChanged = true;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeChanged = true;
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date < DateTime.Now)
            {
                e.Cell.BackColor = ColorTranslator.FromHtml("#a9a9a9");
                e.Day.IsSelectable = false;
            }
        }
    }
}