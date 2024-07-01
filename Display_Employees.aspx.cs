using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Web.Services.Description;
using System.Security.Cryptography;


namespace Point_Of_Sale
{
    public partial class Display_Employees : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        protected void button_click_display_employees(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("display_employees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            GridViewEmployees.DataSource = dt;
            GridViewEmployees.DataBind();
            GridViewEmployees.HorizontalAlign = HorizontalAlign.Center;
            GridViewEmployees.BorderWidth = 2;
            GridViewEmployees.BorderStyle = BorderStyle.Double;
            GridViewEmployees.HeaderStyle.Font.Bold = true;
            GridViewEmployees.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
            Color customColor = Color.FromArgb(236, 225, 255);
            GridViewEmployees.BackColor = customColor;

            GridViewEmployees.HeaderStyle.Font.Bold = true;
            GridViewEmployees.HeaderStyle.ForeColor = Color.White; // Header text color
            Color customColor1 = Color.FromArgb(69, 15, 96);
            GridViewEmployees.HeaderStyle.BackColor = customColor1; // Header background color
            GridViewEmployees.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            GridViewEmployees.HeaderStyle.Height = 40;
            GridViewEmployees.HeaderRow.Width = 50;
            foreach (GridViewRow row in GridViewEmployees.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Style["padding"] = "10px"; // Adjust padding as needed
                }
            }

            btnDisplayEmployees.Visible = false;
            con.Close();

        }
    }
}