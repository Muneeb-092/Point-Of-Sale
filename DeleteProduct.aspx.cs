using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void deleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productID.Text) || string.IsNullOrEmpty(quantity.Text))
            {
                message.InnerText = "Please fill in all fields.";
                return;
            }
            
            int productId = Convert.ToInt32( productID.Text);
            int qty = Convert.ToInt32(quantity.Text);
            int qtyAvailable = 0;
            string query = "SELECT Quantity FROM Items WHERE ID = @productID";
            string connectionString = "Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(query, connection);
                command1.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();
                SqlDataReader reader = command1.ExecuteReader();

                if (reader.HasRows)
                {
                    // Read the values from the reader
                    while (reader.Read())
                    {
                        // Example: 
                        qtyAvailable = reader.GetInt32(0);                  
                    }

                }
               
                if(qtyAvailable < qty)
                {
                    message.InnerText = "This Quantity is not present in Inventory...";
                    productID.Text = "";
                    quantity.Text = "";
                    return;
                }

                reader.Close();
                connection.Close();
                using (SqlCommand command = new SqlCommand("minus_product", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@Quantity", qty);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        message.InnerText = "Product deleted successfully!";
                    }
                    else
                    {
                        message.InnerText = "Product not found or quantity doesn't match.";
                    }
                }
            }

            // Clear textboxes after processing
            productID.Text = "";
            quantity.Text = "";
        }
    
    }
}