using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Global.User == "")
                username.Text = "---";
            else
                username.Text = Global.User;
            loginTime.Text = Global.loginTime.ToString();
            if (Global.Access == 0)
                accessibility.Text = "Not Given";
            else
                accessibility.Text = "Given";
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {

            // Clear the session
            Session.Abandon();

            // Redirect to the login page (assuming login.aspx is the login page)
            Response.Redirect("POS-Login.aspx");
        }
    }
}