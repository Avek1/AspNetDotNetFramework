using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// actually part 56
namespace Part_55_CrossPagePosting 
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1 previousPage = this.PreviousPage;
            if (previousPage != null && previousPage.IsCrossPagePostBack)
            {
                // Access the Name and Email public properties
                lblName.Text = previousPage.Name;
                lblEmail.Text = previousPage.Email;
            } else
            {
                lblStatus.Text = "You landed on this page using a technique other than cross page post back.";
            }
        }
    }
}