using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_63_CookielessSessions
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendData_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Email"] = txtEmail.Text;

            Response.Redirect("~/WebForm2.aspx");
            // always use Relative URLS (above) for cookieless sessions.
            // absolute URLS (below) will not work because the Cookieless feature...
            // ... in .NET will generate new session id when naving to page 2.
            //Response.Redirect("http://localhost:58252/WebForm2.aspx");
        }
    }
}