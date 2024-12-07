using Project101;

namespace project101
{
    public partial class Form1 : Form
    {

        BindingSource ItemBindingsouce = new BindingSource();
        BindingSource InventoryBindingsource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();

            // connect the list to the grid view control

            ItemBindingsouce.DataSource = productDAO.searchname(textBox1.Text);

            dataGridView1.DataSource = ItemBindingsouce;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();

            // connect the list to the grid view control

            ItemBindingsouce.DataSource = productDAO.getALLproducts();

            dataGridView1.DataSource = ItemBindingsouce;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Macbook_Air.jpg/220px-Macbook_Air.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventoryDAO inventoryDAO = new inventoryDAO();

            // connect the list to the grid view control

            InventoryBindingsource.DataSource = inventoryDAO.getALLinventory();

            dataGridView1.DataSource = InventoryBindingsource;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventoryDAO inventoryDAO = new inventoryDAO();

            // connect the list to the grid view control

            InventoryBindingsource.DataSource = inventoryDAO.getsuppliers();

            dataGridView1.DataSource = InventoryBindingsource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridview = (DataGridView)sender;

            // get the row number clicked

            int rowCLicked = dataGridview.CurrentRow.Index;

            String image_Url = dataGridView1.Rows[rowCLicked].Cells[4].Value.ToString();

            pictureBox1.Load(image_Url);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Products product = new Products
            {

                product_name = txt_name.Text,
                price = decimal.Parse(txt_product_price.Text),
                category = txt_product_cate.Text,
                Image_URL = txt_product_URL.Text

            };

            ProductDAO productDAO = new ProductDAO();
            int result = productDAO.addOneProduct(product);

            MessageBox.Show(result + " new row(s) inserted");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
