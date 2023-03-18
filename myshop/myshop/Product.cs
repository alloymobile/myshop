using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myshop
{
    internal class Product
    {
        private int id;
        private string name;
        private double price;
        private int quantity;

        public Product()
        {
            this.id = 0;
            this.name = "";
            this.price = 0;
            this.quantity = 0;
        }

        public Product(int id,string name,double price,int quantity )
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }


        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;   
        }

        public string getName()
        {
            return this.name;   
        }

        public void setName(string name)
        {
            this.name = name;
        }


        public double getPrice()
        {
            return this.price;      
        }

        public void setPrice(double price)
        {
            this.price = price;
        }

        public int getQuantity()
        {
            return this.quantity;   
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
