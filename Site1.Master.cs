﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDFC_Loans
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btmLogout_Click(object sender, EventArgs e)
        {
            // Sign out the user
            FormsAuthentication.SignOut();

            // Redirect to the login page (you can replace "Login.aspx" with your actual login page)
            Response.Redirect("~/Login.aspx");
        }
    }
}