using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_57_OpenNewWindowUsingJavaScript
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string strJavascript = "<script>window.open('WebForm2.aspx?NameOfUser=" + txtName.Text + "&Email=" + txtEmail.Text + "'); </script>";
            Response.Write(strJavascript);
        }
    }
}