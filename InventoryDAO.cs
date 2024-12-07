using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project101
{
    internal class inventoryDAO
    {

        string connectionString = "datasource = localhost;port=3306;username=root;password=root;database=inventorydb;";

        public List<StoreInventory> getALLinventory()
        {
            List<StoreInventory> returninventory = new List<StoreInventory>();

            MySqlConnection connection2 = new MySqlConnection
            (connectionString);
            connection2.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM inventory", connection2);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    StoreInventory b = new StoreInventory
                    {
                        inventory_id = reader.GetInt32(0),
                        product_id = reader.GetInt32(1),
                        quantity = reader.GetInt32(2),
                        supplier_id = reader.GetInt32(3),
                        last_updated = reader.GetDateTime(4)
                    };
                    returninventory.Add(b);
                }
                connection2.Close();



                return returninventory;


            }
        }


        public List<Storesuppliers> getsuppliers()
        {
            List<Storesuppliers> returninventory = new List<Storesuppliers>();

            MySqlConnection connection2 = new MySqlConnection
            (connectionString);
            connection2.Open();

            MySqlCommand command = new MySqlCommand("SELECT * FROM suppliers", connection2);

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Storesuppliers b = new Storesuppliers
                    {
                        supplier_id = reader.GetInt32(0),
                        supplier_name = reader.GetString(1),
                        contact_email = reader.GetString(2),
                        phone_number = reader.GetString(3)
                    };
                    returninventory.Add(b);
                }
                connection2.Close();



                return returninventory;


            }
        }


    }

}
