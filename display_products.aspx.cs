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

namespace Point_Of_Sale
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        protected void button_click_display_products(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("display_products", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            if (dt.Rows.Count == 0)
            {
                message.InnerText = "No Data to Show...";
                return;
            }
            GridViewProducts.DataSource = dt;
            GridViewProducts.DataBind();
            GridViewProducts.HorizontalAlign = HorizontalAlign.Center;
            GridViewProducts.BorderWidth = 2;
            GridViewProducts.BorderStyle = BorderStyle.Double;
            GridViewProducts.HeaderStyle.Font.Bold = true;
            GridViewProducts.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
            Color customColor = Color.FromArgb(236, 225, 255);
            GridViewProducts.BackColor = customColor;
            GridViewProducts.HeaderStyle.Font.Bold = true;
            GridViewProducts.HeaderStyle.ForeColor = Color.White; // Header text color
            Color customColor1 = Color.FromArgb(69, 15, 96);
            GridViewProducts.HeaderStyle.BackColor = customColor1; // Header background color
            GridViewProducts.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            GridViewProducts.HeaderStyle.Height = 40;
            GridViewProducts.HeaderRow.Width = 50;
            foreach (GridViewRow row in GridViewProducts.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Style["padding"] = "10px"; // Adjust padding as needed
                }
            }

            btnDisplayProducts.Visible = false;

            con.Close();

        }
    }
}