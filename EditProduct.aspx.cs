using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void editProduct_Click(object sender, EventArgs e)
        {
            if (productID.Text == ""|| productName.Text == "" || categoryName.Text == "" || purchasePrice.Text == "" || salePrice.Text == "" || quantity.Text == "")
            {
                message.InnerText = "Please Fill in all Fields first.";
                return;
            }
            int PID = Convert.ToInt16(productID.Text);
            string prodName = productName.Text;
            string catName = categoryName.Text;
            decimal purPrice = Convert.ToDecimal(purchasePrice.Text);
            decimal salPrice = Convert.ToDecimal(salePrice.Text);
            int qty = Convert.ToInt32(quantity.Text);


            string connectionString = "Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Items WHERE ID = @ProductID", connection))
                {
                    command.Parameters.AddWithValue("@ProductID", PID);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count == 0)
                    {
                        message.InnerText = "Product not found.";
                        productID.Text = "";
                        productName.Text = "";
                        categoryName.Text = "";
                        purchasePrice.Text = "";
                        salePrice.Text = "";
                        quantity.Text = "";
                        return;
                    }
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand("update_product", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", PID);
                    command.Parameters.AddWithValue("@ProductName", prodName);
                    command.Parameters.AddWithValue("@CategoryName", catName);
                    command.Parameters.AddWithValue("@PurchasePrice", purPrice);
                    command.Parameters.AddWithValue("@SalePrice", salPrice);
                    command.Parameters.AddWithValue("@Stock", qty);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            message.InnerText = "Product Edited successfully!";
            productID.Text = "";
            productName.Text = "";
            categoryName.Text = "";
            purchasePrice.Text = "";
            salePrice.Text = "";
            quantity.Text = "";
            
        }
    }
}