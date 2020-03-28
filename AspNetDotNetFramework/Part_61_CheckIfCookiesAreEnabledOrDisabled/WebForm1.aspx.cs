using System;
using System.Web;

namespace Part_61_CheckIfCookiesAreEnabledOrDisabled
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Browser.Cookies)
                {
                    if (Request.QueryString["CheckCookie"] == null)
                    {
                        HttpCookie cookie = new HttpCookie("TestCookie", "1");
                        Response.Cookies.Add(cookie);
                        Response.Redirect("WebForm1.aspx?CheckCookie=1");
                    }
                    else
                    {
                        HttpCookie cookie = Response.Cookies["TestCookie"];
                        if (cookie == null)
                        {
                            lblMessage.Text = "We have detected that cookies are disabled.  Please enable cookies.";
                        }
                    }
                }
                else
                {
                    lblMessage.Text = "Browse doesn't support cookies.  Install browser that does.";
                }
            }
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