using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Point_Of_Sale
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void ReturnProduct_Click(object sender, EventArgs e)
        {

            if(SaleID.Text == "" || productID.Text == "" || quantity.Text == "")
            {
                message.InnerText = "Please fill in all fields first...";
                return;
            }
            // Your connection string
            string connectionString = "Data Source=.\\DB_SERVER;Initial Catalog=\"Point Of Sale\";Integrated Security=True";

            // SaleID and ProductID you want to query for
            int saleID = Convert.ToInt32(SaleID.Text);
            int productId = Convert.ToInt32(productID.Text); 
            int qty = Convert.ToInt32(quantity.Text);
            int Price = 0, Discount = 0, TotalAmount = 0;
            // First, get the values from the table
            string selectQuery = "SELECT Price, Discount, SoldPrice FROM SaleDetails WHERE SalesID = @SaleID AND ProductID = @ProductID";

            string query = "SELECT Quantity\r\nFROM SaleDetails\r\nWHERE SalesID = @salesID AND ProductID = @productID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command1 = new SqlCommand(selectQuery, connection);
                command1.Parameters.AddWithValue("@SaleID", saleID);
                command1.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();
                SqlDataReader reader = command1.ExecuteReader();

                if (reader.HasRows)
                {
                    // Read the values from the reader
                    while (reader.Read())
                    {
                        // Example: 
                        Price = reader.GetInt32(0);
                        Discount = reader.GetInt32(1);
                        TotalAmount = reader.GetInt32(2);

                        // Continue reading other columns as needed
                    }
                }
                else
                {
                    clearFields();
                    message.InnerText = "Error! Invalid Entries...";
                    return;
                }

                reader.Close();
                connection.Close();

                int quantityAvailable = 0;
                SqlCommand command2 = new SqlCommand(query, connection);
                command2.Parameters.AddWithValue("@SalesID", saleID);
                command2.Parameters.AddWithValue("@ProductID", productId);

                connection.Open();
                SqlDataReader reader1 = command2.ExecuteReader();

                // Read the values from the reader
                while (reader1.Read())
                {
                    quantityAvailable = reader1.GetInt32(0);    

                    // Continue reading other columns as needed
                }

                reader1.Close();
                connection.Close();

                if(quantityAvailable < qty)
                {
                    clearFields();
                    message.InnerText = "This quantity was not even purchased, Enter valid one.";
                    return;
                }
                using (SqlCommand command = new SqlCommand("RemoveQuantityAndUpdateSaleDetails", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@salesID", saleID);
                    command.Parameters.AddWithValue("@productID", productId);
                    command.Parameters.AddWithValue("@quantityToRemove", qty);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand("RemoveSaleTotals", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@salesID", saleID);
                    command.Parameters.AddWithValue("@totalAmount", (Price * qty));
                    command.Parameters.AddWithValue("@totalDiscount", (Discount / qty));
                    command.Parameters.AddWithValue("@grandTotal", ((Price * qty) - (Discount / qty)));

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                using (SqlCommand command = new SqlCommand("return_product", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ProductID", productId);
                    command.Parameters.AddWithValue("@Quantity", qty);
                   
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                TotalAmount = (Price * qty) - (Discount / qty);
                message.InnerText = "Product Returned Successfully. Pay Rs: " + TotalAmount.ToString() + " /- to Customer.";
                clearFields();
            }

        }
            protected void clearFields()
            {
                SaleID.Text = "";
                productID.Text = "";
                quantity.Text = "";
            }
    }
}