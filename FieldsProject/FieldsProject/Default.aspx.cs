using Service1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Fields_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("/Pages/showFieldsPage.aspx");
        }

        protected void Reservations_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("/Pages/showReservationsPage.aspx");
        }

        protected void MyReservations_Click(object sender, EventArgs e)
        {
            if (this.Session["userName"] != null)
                Page.Response.Redirect("/Pages/MyReservations.aspx");
            Page.Response.Redirect("/Pages/Login.aspx");    
        }
    }
}