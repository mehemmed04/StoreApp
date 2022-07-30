using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class ProductDetailsUC : UserControl
    {
        public string Name { get => prnameLbl.Text; set { prnameLbl.Text = value; prnameLbl.Enabled = false; } }
        public string Price { get => prpriceLbl.Text; set { prpriceLbl.Text = value.ToString(); prpriceLbl.Enabled = false; } }
        public Image ProductImage
        {
            get
            {
                return primagePctrBx.Image;
            }
            set
            {
                primagePctrBx.Image = value;
            }
        }
        public ProductDetailsUC()
        {
            InitializeComponent();
        }

        private void prnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prnameLbl.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prpriceLbl.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prnameLbl.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            prpriceLbl.Enabled = false;

        }

        private void primagePctrBx_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                primagePctrBx.Image = new Bitmap(open.FileName);
                ProductImage = new Bitmap(open.FileName);

            }


        }
    }
}
