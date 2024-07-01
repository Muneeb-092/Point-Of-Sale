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
    public partial class highly_demand : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        protected void button_click_display_highly_demand(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("most_demand_product", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            if (dt.Rows.Count == 0)
            {
                message.InnerText = "No Data to Show...";
                return;
            }

            GridViewhighly_demand.DataSource = dt;
            GridViewhighly_demand.DataBind();
            GridViewhighly_demand.HorizontalAlign = HorizontalAlign.Center;
            GridViewhighly_demand.BorderWidth = 2;
            GridViewhighly_demand.BorderStyle = BorderStyle.Double;
            GridViewhighly_demand.HeaderStyle.Font.Bold = true;
            GridViewhighly_demand.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
            Color customColor = Color.FromArgb(236, 225, 255);
            GridViewhighly_demand.BackColor = customColor;
            GridViewhighly_demand.HeaderStyle.Font.Bold = true;
            GridViewhighly_demand.HeaderStyle.ForeColor = Color.White; // Header text color
            Color customColor1 = Color.FromArgb(69, 15, 96);
            GridViewhighly_demand.HeaderStyle.BackColor = customColor1; // Header background color
            GridViewhighly_demand.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            GridViewhighly_demand.HeaderStyle.Height = 40;
            GridViewhighly_demand.HeaderRow.Width = 50;
            foreach (GridViewRow row in GridViewhighly_demand.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Style["padding"] = "10px"; // Adjust padding as needed
                }
            }
            btnhighly_demand.Visible = false;

            con.Close();

        }
    }
}