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
using System.Collections.Specialized;

namespace Point_Of_Sale
{
    public partial class yearly_report : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        SqlConnection con1 = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Optional: Set default date to today
                txtReportYear.Text = DateTime.Today.ToString("yyyy");
            }
        }
        protected void button_click_display_yearly_report(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("Yearly_Report_Sum", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@current_year", SqlDbType.Int).Value = txtReportYear.Text;

            // Define output parameters to capture the returned values
            SqlParameter paramTotalSales = new SqlParameter("@ts", SqlDbType.VarChar, 50);
            paramTotalSales.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramTotalSales);

            SqlParameter paramTotalAmount = new SqlParameter("@ta", SqlDbType.VarChar, 50);
            paramTotalAmount.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramTotalAmount);

            SqlParameter paramTotalProfit = new SqlParameter("@tp", SqlDbType.VarChar, 50);
            paramTotalProfit.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(paramTotalProfit);

            // Set input parameter for current_date


            // Execute the stored procedure
            cmd.ExecuteNonQuery();

            // Retrieve the output parameter values
            string totalSales = cmd.Parameters["@ts"].Value.ToString();
            string totalAmount = cmd.Parameters["@ta"].Value.ToString();
            string totalProfit = cmd.Parameters["@tp"].Value.ToString();

            
            string message = $"Total Sales : {totalSales}";
            string message1 = $"Total Amount : Rs {totalAmount} /-";
            string message2 = $"Total Profit : Rs {totalProfit} /-";

            // Update the <div> content using JavaScript
            string script = $"document.getElementById('message').innerHTML = '{message}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage", script, true);

            string script1 = $"document.getElementById('message1').innerHTML = '{message1}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage1", script1, true);
            string script2 = $"document.getElementById('message2').innerHTML = '{message2}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage2", script2, true);

            btnyearly_report.Visible = false;
            txtReportYear.Visible = false;
            con.Close();
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Yearly_Report", con1);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@current_year", SqlDbType.Int).Value = txtReportYear.Text;

            DataTable dt = new DataTable();
            dt.Load(cmd1.ExecuteReader());

            if (dt.Rows.Count == 0)
            {
                msg.InnerText = "No Data to Show...";
                return;
            }

            GridViewyearly_report.DataSource = dt;
            GridViewyearly_report.DataBind();
            GridViewyearly_report.HorizontalAlign = HorizontalAlign.Center;
            GridViewyearly_report.BorderWidth = 2;
            GridViewyearly_report.BorderStyle = BorderStyle.Double;
            GridViewyearly_report.HeaderStyle.Font.Bold = true;
            GridViewyearly_report.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
            Color customColor = Color.FromArgb(236, 225, 255);
            GridViewyearly_report.BackColor = customColor;
            GridViewyearly_report.HeaderStyle.Font.Bold = true;
            GridViewyearly_report.HeaderStyle.ForeColor = Color.White; // Header text color
            Color customColor1 = Color.FromArgb(69, 15, 96);
            GridViewyearly_report.HeaderStyle.BackColor = customColor1; // Header background color
            GridViewyearly_report.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            GridViewyearly_report.HeaderStyle.Height = 40;
            GridViewyearly_report.HeaderRow.Width = 50;
            foreach (GridViewRow row in GridViewyearly_report.Rows)
            {
                foreach (TableCell cell in row.Cells)
                {
                    cell.Style["padding"] = "10px"; // Adjust padding as needed
                }
            }


            con1.Close();

        }
    }
}