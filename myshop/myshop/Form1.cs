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
        List<string> name = new List<string>();
        public Form1()
        {
            InitializeComponent();
            name.Add("Hello");
            name.Add("Good");
            int x1 = 200;
            name.ForEach(x =>
            {
                Button b1 = new Button();
                b1.Text = x;
                b1.Location = new Point(x1,120);
                this.Controls.Add(b1);
                x1 = x1 + 100;
            });

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = product.getName();
            lblPrice.Text = "CAD "+product.getPrice();
        }
    }
}
