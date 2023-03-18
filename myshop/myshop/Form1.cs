using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myshop
{
    public partial class Form1 : Form
    {
        Product product = new Product(1, "IPhone 14 Pro", 1200, 10);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = product.getName();
            lblPrice.Text = "CAD "+product.getPrice();
        }
    }
}
