using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class MakeReservation : System.Web.UI.Page
    {
        private calendarChanged = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if(checkForm())
            {


            }
            //try to add 
            // if it adds go back to MyReservations
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MakeReservation.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CancelReservation.aspx");
        }

        private bool checkForm()
        {
            bool good = false;
            if (MakeResText.Text != string.Empty)
                good = true;
            if ()
            return good;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}