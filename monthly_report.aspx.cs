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
    public partial class monthly_report : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        SqlConnection con1 = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Optional: Set default date to today
                txtReportMonth.Text = DateTime.Today.ToString("yyyy-MM");
            }
        }
        protected void button_click_display_monthly_report(object sender, EventArgs e)
        {

            con.Open();
            string reportMonthYear = txtReportMonth.Text;
            DateTime selectedDate = DateTime.Parse(reportMonthYear);

            int month = selectedDate.Month; // Extract the month
            int year = selectedDate.Year; // Extract the year

            // Create command object for 'practice' stored procedure
            SqlCommand cmd = new SqlCommand("Monthly_Report_Sum", con);
            cmd.CommandType = CommandType.StoredProcedure;

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
            cmd.Parameters.AddWithValue("@current_month", month);
            cmd.Parameters.AddWithValue("@current_year", year);

            // Execute the stored procedure
            cmd.ExecuteNonQuery();

            // Retrieve the output parameter values
            string totalSales = cmd.Parameters["@ts"].Value.ToString();
            string totalAmount = cmd.Parameters["@ta"].Value.ToString();
            string totalProfit = cmd.Parameters["@tp"].Value.ToString();

            string message = $"Total Sales : Rs {totalSales} /-";
            string message1 = $"Total Amount : Rs {totalAmount} /-";
            string message2 = $"Total Profit : Rs {totalProfit} /-";

            // Update the <div> content using JavaScript
            string script = $"document.getElementById('message').innerHTML = '{message}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage", script, true);

            string script1 = $"document.getElementById('message1').innerHTML = '{message1}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage1", script1, true);
            string script2 = $"document.getElementById('message2').innerHTML = '{message2}';";
            ClientScript.RegisterStartupScript(this.GetType(), "updateMessage2", script2, true);

            // Parse the selected month and year
            btnmonthly_report.Visible = false;
            txtReportMonth.Visible = false;
            con1.Close();

            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Monthly_Report", con1);
            cmd1.CommandType = CommandType.StoredProcedure;

            cmd1.Parameters.AddWithValue("@current_month", month);
            cmd1.Parameters.AddWithValue("@current_year", year);

            DataTable dt = new DataTable();
            dt.Load(cmd1.ExecuteReader());

            if (dt.Rows.Count == 0)
            {
                msg.InnerText = "No Data to Show...";
                return;
            }

            GridViewmonthly_report.DataSource = dt;
            GridViewmonthly_report.DataBind();
            GridViewmonthly_report.HorizontalAlign = HorizontalAlign.Center;
            GridViewmonthly_report.BorderWidth = 2;
            GridViewmonthly_report.BorderStyle = BorderStyle.Double;
            GridViewmonthly_report.HeaderStyle.Font.Bold = true;
            GridViewmonthly_report.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
            Color customColor = Color.FromArgb(236, 225, 255);
            GridViewmonthly_report.BackColor = customColor;
            GridViewmonthly_report.HeaderStyle.Font.Bold = true;
            GridViewmonthly_report.HeaderStyle.ForeColor = Color.White; // Header text color
            Color customColor1 = Color.FromArgb(69, 15, 96);
            GridViewmonthly_report.HeaderStyle.BackColor = customColor1; // Header background color
            GridViewmonthly_report.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            GridViewmonthly_report.HeaderStyle.Height = 40;
            GridViewmonthly_report.HeaderRow.Width = 50;
            foreach (GridViewRow row in GridViewmonthly_report.Rows)
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