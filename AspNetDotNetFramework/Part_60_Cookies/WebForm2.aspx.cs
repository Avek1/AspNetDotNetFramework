using System;
using System.Web;

namespace Part_60_Cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["UserInfo"];
            if (cookie != null)
            {
                lblName.Text = cookie["Name"];
                lblEmail.Text = cookie["Email"];
            }
        }
    }
}