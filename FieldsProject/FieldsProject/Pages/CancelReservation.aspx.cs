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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["userName"] == null || !new DataService().authenticateUser((string)this.Session["userName"], (string)this.Session["password"]))
                Page.Response.Redirect("../default.aspx");
            d = new DataService().getReservationsByPerson((string)this.Session["userName"]);
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
            Page.Response.Redirect("../default.aspx");
        }

        protected void ButtonCancelSelected_Click(object sender, EventArgs e)
        {
            int count = 1;
            foreach(DataRow row in d.Rows)
            {
                if (count == Convert.ToInt32(DropDownList1.Text))
                {
                    new DataService().deleteReservation(Convert.ToInt32(row.ItemArray[1]), (string)this.Session["userName"], (DateTime)row.ItemArray[4]);
                    Page.Response.Redirect("CancelReservation.aspx");
                }
                count++;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void GridViewResCancel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}