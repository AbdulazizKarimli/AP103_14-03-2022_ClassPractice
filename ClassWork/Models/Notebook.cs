using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    internal class Notebook : Product
    {
        public string brandName;
        public string model;
        public int ram;
        public int storage;

        public Notebook(string brandName, double price, int count) : base(price, count)
        {
            this.brandName = brandName;
        }

        public string GetInfo()
        {
            return $"Brand name: {brandName} - Model: {model} - RAM: {ram} - Storage: {storage}\nPrice: {price} - Count: {count}";
        }
    }
}
