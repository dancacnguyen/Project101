namespace project101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button5 = new Button();
            txt_product_URL = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_product_cate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_product_price = new TextBox();
            txt_name = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(404, 12);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 0;
            button1.Text = "Load Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(806, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 25);
            button2.TabIndex = 1;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(518, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 25);
            textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 212);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button3
            // 
            button3.Location = new Point(150, 371);
            button3.Name = "button3";
            button3.Size = new Size(94, 43);
            button3.TabIndex = 4;
            button3.Text = "Load Inventory";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(50, 370);
            button4.Name = "button4";
            button4.Size = new Size(94, 44);
            button4.TabIndex = 5;
            button4.Text = "Load Suppliers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1036, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(255, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(txt_product_URL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_product_cate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_product_price);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Location = new Point(24, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 212);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Product";
            // 
            // button5
            // 
            button5.Location = new Point(22, 179);
            button5.Name = "button5";
            button5.Size = new Size(67, 27);
            button5.TabIndex = 8;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txt_product_URL
            // 
            txt_product_URL.Location = new Point(118, 149);
            txt_product_URL.Name = "txt_product_URL";
            txt_product_URL.Size = new Size(218, 25);
            txt_product_URL.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 143);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 107);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 2;
            label3.Text = "Category";
            // 
            // txt_product_cate
            // 
            txt_product_cate.Location = new Point(118, 110);
            txt_product_cate.Name = "txt_product_cate";
            txt_product_cate.Size = new Size(218, 25);
            txt_product_cate.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 1;
            label2.Text = "Price";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Product name";
            // 
            // txt_product_price
            // 
            txt_product_price.Location = new Point(118, 71);
            txt_product_price.Name = "txt_product_price";
            txt_product_price.Size = new Size(218, 25);
            txt_product_price.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(118, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(218, 25);
            txt_name.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 493);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txt_product_URL;
        private TextBox txt_product_cate;
        private TextBox txt_product_price;
        private TextBox txt_name;
        private Button button5;
    }
}
