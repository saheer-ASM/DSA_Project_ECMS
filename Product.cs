using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class Product
    {
        public int ProductID;
        public string Name;
        public string Category;
        public double Price;

        public Product(int id, string name, string category, double price)
        {
            ProductID = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID: {ProductID}, Name: {Name}, Category: {Category}, Price: ${Price}";
        }
    }
}
