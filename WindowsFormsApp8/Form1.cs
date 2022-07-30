using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {

        List<Product> products = new List<Product>();
        HomeUC homeUC = new HomeUC();
        public Form1()
        {
            InitializeComponent();

            products.Add(new Product
            {
                Name = "Asus Rog Stris",
                Price = 2345.6,
                image = Properties.Resources.asusrog
            });
            products.Add(new Product
            {
                Name = "Iphone 13 Pro Max",
                Price = 3522,
                image = Properties.Resources.iphone13promax
            });
            products.Add(new Product
            {
                Name = "Iphone 13 Pro Max",
                Price = 3522,
                image = Properties.Resources.iphone13promax
            });
            products.Add(new Product
            {
                Name = "Iphone 13 Pro Max",
                Price = 3522,
                image = Properties.Resources.iphone13promax
            });
            products.Add(new Product
            {
                Name = "Asus Zenbook Slim",
                Price = 2876,
                image = Properties.Resources.asuszenbook
            });
            products.Add(new Product
            {
                Name = "Asus Zenbook Slim",
                Price = 2876,
                image = Properties.Resources.asuszenbook
            });

            int x = 30, y = 30;
            foreach (var item in products)
            {
                var productUc = new ProductUC();
                productUc.Location = new Point(x, y);
                y += 100;
                productUc.Name = item.Name;
                productUc.Price = item.Price.ToString();
                productUc.ProductImage = item.image;
                productUc.DoubleClick += ProductUc_DoubleClick;
                ProductContainer.Controls.Add(productUc);
            }

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homePnl_Click(object sender, EventArgs e)
        {
            ProductContainer.Controls.Clear();
            ProductContainer.Controls.Add(homeUC);
        }
        private void ProductUc_DoubleClick(object sender, EventArgs e)
        {
            if (sender is ProductUC productUC)
            {
                ProductDetailsUC productDetailsUC = new ProductDetailsUC();
                productDetailsUC.Name = productUC.Name;
                productDetailsUC.Price = productUC.Price;
                productDetailsUC.ProductImage = productUC.ProductImage;
                ProductContainer.Controls.Clear();
                ProductContainer.Controls.Add(productDetailsUC);
            }
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            ProductContainer.Controls.Clear();
            int x = 30, y = 30;
            foreach (var item in products)
            {
                var productUc = new ProductUC();
                productUc.Location = new Point(x, y);
                y += 100;
                productUc.Name = item.Name;
                productUc.Price = item.Price.ToString();
                productUc.ProductImage = item.image;
                productUc.DoubleClick += ProductUc_DoubleClick;
                ProductContainer.Controls.Add(productUc);
            }
        }

        private void guna2GradientPanel2_Click(object sender, EventArgs e)
        {
            ProductContainer.Controls.Clear();
            int x = 30, y = 30;
            foreach (var item in products)
            {
                var productUc = new ProductUC();
                productUc.Location = new Point(x, y);
                y += 100;
                productUc.Name = item.Name;
                productUc.Price = item.Price.ToString();
                productUc.ProductImage = item.image;
                productUc.DoubleClick += ProductUc_DoubleClick;
                ProductContainer.Controls.Add(productUc);
            }
        }
    }
}
