using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class showFieldsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewFieldPage.DataSource = new DataService().getAllFields();
            GridViewFieldPage.DataBind();
        }

        protected void GridViewFieldPage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if ((bool)this.Session["userLoggedOn"] == true)
                Page.Response.Redirect("MyReservations.aspx");
            Page.Response.Redirect("Login.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("showReservationsPage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page_Load(sender, e);
        }
    }
}