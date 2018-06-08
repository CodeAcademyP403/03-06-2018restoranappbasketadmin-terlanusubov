using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Task_Restoran
{
    public partial class MainForm : Form
    {
        ArrayList products = new ArrayList();
        Basket basket = new Basket();

        Form form = new Form();

        public MainForm(Form _form) : this()
        {
            form = _form;  
        }

        public MainForm() 
        {
            InitializeComponent();
            products.AddRange(new Product[]
         {
                new Product
                {
                    Name = "Kabab",
                    Price = 2,
                    Count = 100,
                    Category = Category.MainFoods
                },
                new Product
                {
                    Name = "Paytaxt Salati",
                    Price = 1,
                    Count = 100,
                    Category = Category.Salads
                },
                new Product
                {
                    Name = "Ezo Gelin",
                    Price = 4,
                    Count = 100,
                    Category = Category.Soups
                },
                new Product
                {
                    Name = "Paxlava",
                    Price = 3,
                    Count = 100,
                    Category = Category.Sweets
                },
                new Product
                {
                    Name = "Ayran",
                    Price = 1.5,
                    Count = 100,
                    Category = Category.Drinks
                },
         });

            cmbx_category.DataSource = Enum.GetValues(typeof(Category));
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void cmbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory = (sender as ComboBox).SelectedItem.ToString();
            Category SelectingCategory = (Category)Enum.Parse(typeof(Category), SelectedCategory);

            ArrayList foods = new ArrayList();
            foreach (Product item in products)
            {
                if(SelectingCategory == item.Category)
                {
                    foods.Add(item.Name);
                }
            }

            cmbx_name.DataSource = foods;
            txbx_count.Text = "";

        }

        private void cmbx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedFood = (sender as ComboBox).SelectedItem.ToString();

            foreach (Product item in products)
            {
                if(SelectedFood == item.Name)
                {
                    txbx_price.Text = item.Price.ToString();
                }
            }
            txbx_count.Text = "";
        }
        double total = 0;
        private void btn_order_Click(object sender, EventArgs e)
        {
            //Product product = new Product();
            //foreach (Product item in products)
            //{
            //    if (item.Name== cmbx_name.SelectedItem.ToString())
            //    {
            //        product = item;
            //    }
            //}
            //product.Count = Convert.ToByte(txbx_count.Text);
            //product.Price = product.Price * product.Count;
            //basket.OrderedProducts.Add(product);
            ProductItem orderedproduct = new ProductItem
            {
                Name = cmbx_name.SelectedItem.ToString(),
                Price = Convert.ToDouble(txbx_price.Text),
            };

            if (txbx_count.Text == "")
            {
                orderedproduct.Count = 1;
            }
            else
            {
                orderedproduct.Count = Convert.ToByte(txbx_count.Text);
            }

            basket.OrderedProducts.Add(orderedproduct);

            list_name.Items.Add(orderedproduct.Name);
            list_count.Items.Add(orderedproduct.Count);
            list_price.Items.Add(orderedproduct.Price + " " + "AZN");
            list_total.Items.Add(orderedproduct.Count * orderedproduct.Price + " " + "AZN");


            total = total + (orderedproduct.Count * orderedproduct.Price);
            total_price.Text = total.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list_name.Items.Clear();
            list_count.Items.Clear();
            list_price.Items.Clear();
            list_total.Items.Clear();
            txbx_count.Text = "";
            txbx_price.Text = "";
            total_price.Text = "0";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }

      
    }
}
