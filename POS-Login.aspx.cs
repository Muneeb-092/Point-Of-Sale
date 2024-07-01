using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = "Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True";
        int employeeID = 0;
        int accessStatus = 0;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text != "")
            {
                message.InnerText = "Please Enter UserName...";
            }
            else if (txtUsername.Text != "" && txtPassword.Text == "")
            {
                message.InnerText = "Please Enter Password...";
            }
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                message.InnerText = "Please Enter UserName and Password...";
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Global.User = username;
                Global.loginTime = DateTime.Now;

                if (ValidateUser(username, password))
                {
                    FormsAuthentication.SetAuthCookie(username, false);
                    Response.Redirect("Home.aspx"); // Redirect to the default page after successful login
                }
                else
                {
                    message.InnerText = "Try Again! Wrong UserName or Password...";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("User_authentication", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlParameter employeeIDParam = new SqlParameter("@EmployeeID", SqlDbType.Int);
                    employeeIDParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(employeeIDParam);

                    SqlParameter accessStatusParam = new SqlParameter("@AccessStatus", SqlDbType.VarChar, 20);
                    accessStatusParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(accessStatusParam);

                    SqlParameter statusCodeParam = new SqlParameter("@StatusCode", SqlDbType.Int);
                    statusCodeParam.Direction = ParameterDirection.Output;
                    command.Parameters.Add(statusCodeParam);

                    // Execute the command
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    int statusCode = (int)command.Parameters["@StatusCode"].Value;

                    if (statusCode == 1)
                    {
                        // Successful authentication
                        if (command.Parameters["@EmployeeID"].Value == DBNull.Value)
                            employeeID = 0;
                        else
                            employeeID = Convert.ToInt32(command.Parameters["@EmployeeID"].Value);

                        if (command.Parameters["@AccessStatus"].Value == DBNull.Value)
                            accessStatus = -1;
                        else
                            accessStatus = Convert.ToInt32(command.Parameters["@AccessStatus"].Value);
                        Global.Access = accessStatus;
                        Global.Access = accessStatus;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
