﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_60_Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
   
        }

        protected void btnSendData_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = txtName.Text;
            cookie["Email"] = txtEmail.Text;
            cookie.Expires = DateTime.Now.AddDays(30);     
            Response.Cookies.Add(cookie);

            Response.Redirect("WebForm2.aspx");
        }
    }
}