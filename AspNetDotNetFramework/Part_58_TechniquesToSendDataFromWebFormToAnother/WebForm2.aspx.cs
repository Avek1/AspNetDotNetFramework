using System;
using System.Web.UI;

namespace Part_58_TechniquesToSendDataFromWebFormToAnother
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // technique 1
            //if (!IsPostBack)
            //{
            //    Page lastPage = (Page)Context.Handler;
            //    lblName.Text = ((TextBox)lastPage.FindControl("txtName")).Text;
            //    lblEmail.Text = ((TextBox)lastPage.FindControl("txtEmail")).Text;
            //}

            // technique 2
            if (!IsPostBack)
            {
                Page lastPage = (Page)Context.Handler;
                if (lastPage is WebForm1)
                {
                    lblName.Text = ((WebForm1)lastPage).Name;
                    lblEmail.Text = ((WebForm1)lastPage).Email;

                }
            }
        }
    }
}