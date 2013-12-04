using Service1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class CancelReservation : System.Web.UI.Page
    {
        private DataTable d = new DataTable();
        private string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            name = (string)this.Session["username"];
            d = new DataService().getReservationsByPerson(name);
            GridViewResCancel.DataSource = d;
            GridViewResCancel.DataBind();

            int count = 1;
            foreach (var row in d.Rows)
            {
                DropDownList1.Items.Add(new ListItem(count.ToString(), count.ToString()));
                count++;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("CancelReservation.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("MakeReservation.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("showFieldsPage.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow row = d.Rows[Convert.ToInt32(DropDownList1.Text)];
            int fieldid = Convert.ToInt32(row[1]);
            DateTime date = Convert.ToDateTime(row[4]);
            new DataService().deleteReservation(fieldid, name, date);
            GridViewResCancel.DataSource = d;
        }

        protected void GridViewResCancel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}