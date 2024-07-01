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
using System.Net.Configuration;

namespace Point_Of_Sale
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        protected void button_click_add_employee(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("add_employee", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empID", SqlDbType.Int).Value = txtID.Text;
            cmd.Parameters.AddWithValue("@empName", SqlDbType.VarChar).Value = txtName.Text;
            cmd.Parameters.AddWithValue("@designation", SqlDbType.VarChar).Value = txtDesignation.Text;
            cmd.Parameters.AddWithValue("@PhoneNo", SqlDbType.Int).Value = txtPhone.Text;
            cmd.Parameters.AddWithValue("@address", SqlDbType.VarChar).Value = txtAddress.Text;
            cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtEmail.Text;
            cmd.Parameters.AddWithValue("@cnic", SqlDbType.Int).Value = txtCNIC.Text;
            cmd.Parameters.AddWithValue("@bdate", SqlDbType.Date).Value = txtDOB.Text;
            cmd.Parameters.AddWithValue("@salary", SqlDbType.Int).Value = txtSalary.Text;
            cmd.Parameters.AddWithValue("@joindate", SqlDbType.Date).Value = txtJoiningDate.Text;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = txtusername.Text;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = txtpassword.Text;
            cmd.Parameters.AddWithValue("@AccessibilityStatus", SqlDbType.Int).Value = txtaccessibility.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            msg.InnerText = "Employee Hired Successfully...";

        }
    }
}
