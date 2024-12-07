using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project101
{
    internal class ProductDAO
    {
        string connectionString = "datasource = localhost;port=3306;username=root;password=root;database=inventorydb;"; // need to check MAMP preference for port number 
        //Should run the whole database of inventorydb

        public List<Products> getALLproducts()
        {
            List<Products> returnitems = new List<Products>();

            MySqlConnection connection = new MySqlConnection
            (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM products", connection);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Products a = new Products
                    {
                        product_id = reader.GetInt32(0),
                        product_name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        category = reader.GetString(3),
                        Image_URL = reader.GetString(4)

                    };
                    returnitems.Add(a);
                }
                connection.Close();



                return returnitems;


            }
        }

        public List<Products> searchname(String searchTerm)
        {
            List<Products> returnitems = new List<Products>();

            MySqlConnection connection = new MySqlConnection
            (connectionString);
            connection.Open();

            String searchWILDPhrase = "%" + searchTerm + "%";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = "Select * From products where product_name LIKE @search";

            command.Parameters.AddWithValue("@search", searchWILDPhrase);
            command.Connection = connection;



            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Products a = new Products
                    {
                        product_id = reader.GetInt32(0),
                        product_name = reader.GetString(1),
                        price = reader.GetDecimal(2),
                        category = reader.GetString(3),
                        Image_URL = reader.GetString(4)

                    };
                    returnitems.Add(a);
                }
                connection.Close();



                return returnitems;


            }

        }

        internal int addOneProduct(Products product)
        {
            MySqlConnection connection = new MySqlConnection
            (connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `products`(`product_name`, `price`, `category`, `Image_URL`) VALUES (@productname,@productprice, @productcate, @productlink )", connection);

            command.Parameters.AddWithValue("@productname", product.product_name);

            command.Parameters.AddWithValue("@productprice", product.price);

            command.Parameters.AddWithValue("@productcate", product.category);

            command.Parameters.AddWithValue("@productlink", product.Image_URL);

            int newRows = command.ExecuteNonQuery();

            connection.Close();



                return newRows;
            }
    }

}
