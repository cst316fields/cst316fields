﻿using Service1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FieldsProject.Pages
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            clearFields();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!checkFields()) 
            {
                //should show message with error here instead of just clearing out all boxes
                clearFields();
            }
            else if (new DataService().createUser(CreateNameText.Text, CreatePassText.Text, CreatePhoneText.Text, CreateEmailText.Text))
            {
                Page.Response.Redirect("MyReservations.aspx");
            }
            else
            {
                clearFields();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("../default.aspx");
        }

        private bool checkFields()
        {
            //need to finish this... return true if everything is good, false if some of the fields in text box are bad
            return true;
        }

        private void clearFields()
        {
            CreateNameText.Text = string.Empty;
            CreateEmailText.Text = string.Empty;
            CreatePhoneText.Text = string.Empty;
            CreatePassText.Text = string.Empty;
            CreateRePassText.Text = string.Empty;
        }
    }
}