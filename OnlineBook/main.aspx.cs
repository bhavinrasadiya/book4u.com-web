﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBook
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["Username"] == null) {
                Response.Redirect("login.aspx",false);
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("sds");
            Session.RemoveAll();
            Response.Redirect("login.aspx", false);
        }
    }
}