using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Point_Of_Sale
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=POS;Integrated Security=True;");
        protected void button_click_delete_employee(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("remove_employee", con);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@employeeid", SqlDbType.Int).Value = txtID.Text;

            cmd.ExecuteNonQuery();
           message.InnerText = "Employee has been deleted successfully";
            con.Close();
        }
    }
}