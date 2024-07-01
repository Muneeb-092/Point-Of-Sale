using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm5 : System.Web.UI.Page
    {

        protected void addProduct_Click(object sender, EventArgs e)
        {
            if(productName.Text == "" || categoryName.Text == "" || purchasePrice.Text == "" || salePrice.Text == "" || quantity.Text == "")
            {
                message.InnerText = "Please Fill in all Fields first.";
                return;
            }
            string prodName = productName.Text;
            string catName = categoryName.Text;
            decimal purPrice = Convert.ToDecimal(purchasePrice.Text);
            decimal salPrice = Convert.ToDecimal(salePrice.Text);
            int qty = Convert.ToInt32(quantity.Text);


            string connectionString = "Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("AddProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductName", prodName);
                    command.Parameters.AddWithValue("@CategoryName", catName);
                    command.Parameters.AddWithValue("@PurchasePrice", purPrice);
                    command.Parameters.AddWithValue("@SalePrice", salPrice);
                    command.Parameters.AddWithValue("@Quantity", qty);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            message.InnerText = "Product added successfully!";
        }

    }
}