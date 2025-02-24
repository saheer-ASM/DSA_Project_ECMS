using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class Sorting
    {
        public static void BubbleSort(Product[] products, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }
        }

        public static void PrintProducts(string title, Product[] products)
        {
            Console.WriteLine($"\n{title}");
            foreach (var product in products)
                Console.WriteLine(product);
        }
    }

}
