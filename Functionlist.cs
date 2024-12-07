using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project101
{
    internal class Products
    {
        public int product_id { get; set; }
        public String product_name { get; set; }
        public decimal price { get; set; }
        public String category { get; set; }

        public String Image_URL {  get; set; }

        // later make a List<Track> songs
    }

    internal class StoreInventory
    {
        public int inventory_id { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }
        public int supplier_id { get; set; }
        public DateTime last_updated { get; set; }

    }

    internal class Storesuppliers
    {
        public int supplier_id { get; set; }
        public string supplier_name { get; set; }
        public string contact_email { get; set; }
        public string phone_number { get; set; }

    }
}
