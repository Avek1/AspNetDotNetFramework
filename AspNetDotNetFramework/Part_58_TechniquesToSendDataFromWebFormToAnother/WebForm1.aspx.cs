using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Part_58_TechniquesToSendDataFromWebFormToAnother
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // technique 1
            Server.Transfer("WebForm2.aspx");
        }


        // technique 2
        public string Name
        {
            get
            {
                return txtName.Text;
            }
        }

        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }
    }
}