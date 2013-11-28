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
            GridView1.DataSource = new FieldsProject.Service().getAllFields();
            GridView1.DataBind();
        }

        protected void Reservations_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = new FieldsProject.Service().getAllReservations();
            GridView1.DataBind();
        }

        protected void MyReservations_Click(object sender, EventArgs e)
        {

        }
    }
}