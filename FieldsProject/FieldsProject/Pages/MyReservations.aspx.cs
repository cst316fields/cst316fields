using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class MyReservations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["userName"] == null || !new DataService().authenticateUser((string)this.Session["userName"], (string)this.Session["password"]))
                Page.Response.Redirect("../default.aspx");
            GridView1.DataSource = new DataService().getReservationsByPerson((string)this.Session["userName"]);
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MakeReservation.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CancelReservation.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("../default.aspx");
        }
    }
}