using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class Order
    {
        public int OrderID;
        public string CustomerName;
        public CustomArray<Product> Products;
        public bool IsPreOrder;
        public DateTime OrderDate;

        public Order(int orderId, string customerName, bool isPreOrder, int productSize = 5)
        {
            OrderID = orderId;
            CustomerName = customerName;
            Products = new CustomArray<Product>(productSize);
            IsPreOrder = isPreOrder;
            OrderDate = DateTime.Now;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID}, Customer: {CustomerName}, Pre-Order: {IsPreOrder}, Date: {OrderDate}";
        }
    }
}
