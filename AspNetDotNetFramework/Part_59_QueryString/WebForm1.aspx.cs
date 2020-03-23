using System;

namespace Part_59_QueryString
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSendData_Click(object sender, EventArgs e)
        {
            // technique 1
            //Response.Redirect("~/WebForm2.aspx?UserName=" + txtName.Text + "&Email=" + txtEmail.Text);

            // technique 2 - i like this one.
            Response.Redirect("~/WebForm2.aspx?UserName=" + Server.UrlEncode(txtName.Text) + "&Email=" + Server.UrlEncode(txtEmail.Text));

            // technique 3
            //Response.Redirect("~/WebForm2.aspx?UserName=" + txtName.Text.Replace("&", "%26") + "&Email=" + txtEmail.Text.Replace("&", "%26"));

        }
    }
}