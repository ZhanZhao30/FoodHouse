﻿using FoodHouse.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodHouse.Customer
{
    public partial class Customer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["c"] != null)
            {
                var data =(List<cart>) Session["c"];
                lblcart.Text = data.Count().ToString() ;
                lblcart.Visible = true;
            }
            if (Session["CID"] == null)
            {
                Response.Redirect("../SignIn.aspx");
            }
            else
            {
                btnSignin.Text = "Sign Out";
            }
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            if (btnSignin.Text == "Sign Out")
            {
                Session["CID"] = null;

                Response.Redirect("../Default.aspx");
            }
        }
    }
}