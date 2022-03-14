using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    internal class Product
    {
        public double price;
        public int count;

        public Product(double price, int count)
        {
            this.price = price;
            this.count = count;
        }
    }
}
