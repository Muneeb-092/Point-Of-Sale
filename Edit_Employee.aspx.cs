using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Xml.Linq;

namespace Point_Of_Sale
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");

        protected void button_click_update_employee(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update_employee", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@employeeid", SqlDbType.Int).Value = txtID.Text;
            cmd.Parameters.AddWithValue("@designation", SqlDbType.VarChar).Value = txtDesignation.Text;
            cmd.Parameters.AddWithValue("@phNo", SqlDbType.Int).Value = txtPhone.Text;
            cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.AddWithValue("@salary", SqlDbType.Int).Value = txtSalary.Text;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.Int).Value = txtusername.Text;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.Int).Value = txtpassword.Text;
            cmd.Parameters.AddWithValue("@AccessibilityStatus", SqlDbType.Int).Value = txtaccessibility.Text;

            cmd.ExecuteNonQuery();
            message.InnerText = "Employee has been updated successfully";
            con.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}