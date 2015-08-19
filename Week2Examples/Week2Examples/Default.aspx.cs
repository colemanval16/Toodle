﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week2Examples
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("SecondPage.aspx");
        }

        protected void btnDBS_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.dbs.ie");
        }


        protected void btnServer_Click(object sender, EventArgs e)
        {
            Server.Transfer("SecondPage.aspx");
        }

    }
}