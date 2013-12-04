using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CreateAccount.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (new DataService().authenticateUser(LoginUserText.Text, LoginPassText.Text))
            {
                Page.Response.Redirect("MyReservations.aspx");
            }
            else { clearPage(); }
        }

        private void clearPage()
        {
            LoginUserText.Text = string.Empty;
            LoginPassText.Text = string.Empty;
        }
    }
}