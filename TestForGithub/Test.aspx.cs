﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForGithub
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hi");
        }
        private void getval()
        {
            Response.Write("Hi this is github");
        }
        private void getvalnew()
        {
            Response.Write("Hi this is github sync");
        }
    }
}
