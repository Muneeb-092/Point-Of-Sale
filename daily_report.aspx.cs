using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class daily_report : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");
        SqlConnection con1 = new SqlConnection("Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Optional: Set default date to today
                txtReportDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
            }
        }

        protected void button_click_display_daily_report(object sender, EventArgs e)
        {
            try
            {
                string current_date = txtReportDate.Text; // Get the current date from the text box

                // Call the stored procedure 'practice' to calculate and return values
                con.Open();

                // Create command object for 'practice' stored procedure
                SqlCommand cmd = new SqlCommand("Daily_Report_Sum", con);
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
                cmd.Parameters.AddWithValue("@current_date", current_date);

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

                btndaily_report.Visible = false;
                txtReportDate.Visible = false;
                con.Close();

                con1.Open();
                SqlCommand cmd1 = new SqlCommand("Daily_Report", con1);
                cmd1.CommandType = CommandType.StoredProcedure;

                cmd1.Parameters.AddWithValue("@current_date", current_date);

                DataTable dt = new DataTable();
                dt.Load(cmd1.ExecuteReader());

                if (dt.Rows.Count == 0)
                {
                    msg.InnerText = "No Data to Show...";
                    return;
                }
                GridViewdaily_report.DataSource = dt;
                GridViewdaily_report.DataBind();
                GridViewdaily_report.HorizontalAlign = HorizontalAlign.Center;
                GridViewdaily_report.BorderWidth = 2;
                GridViewdaily_report.BorderStyle = BorderStyle.Double;
                GridViewdaily_report.HeaderStyle.Font.Bold = true;
                GridViewdaily_report.HeaderStyle.ForeColor = System.Drawing.Color.Black; // Optional: Change header text color
                Color customColor = Color.FromArgb(236, 225, 255);
                GridViewdaily_report.BackColor = customColor;
                GridViewdaily_report.HeaderStyle.Font.Bold = true;
                GridViewdaily_report.HeaderStyle.ForeColor = Color.White; // Header text color
                Color customColor1 = Color.FromArgb(69, 15, 96);
                GridViewdaily_report.HeaderStyle.BackColor = customColor1; // Header background color
                GridViewdaily_report.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                GridViewdaily_report.HeaderStyle.Height = 40;

                foreach (GridViewRow row in GridViewdaily_report.Rows)
                {
                    foreach (TableCell cell in row.Cells)
                    {
                        cell.Style["padding"] = "10px"; // Adjust padding as needed
                    }
                }

                btndaily_report.Visible = false;
                txtReportDate.Visible = false;
                con1.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Response.Write("<script>alert('An error occurred: " + ex.Message + "');</script>");
            }
        }
    }
}
