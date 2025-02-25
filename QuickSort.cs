using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class QuickSort
    {
        public static void QuickSortAlgo(Product[] products, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(products, low, high);
                QuickSortAlgo(products, low, pi - 1);
                QuickSortAlgo(products, pi + 1, high);
            }
        }

        private static int Partition(Product[] products, int low, int high)
        {
            Product pivot = products[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (CompareString.Campare(products[j].Category, pivot.Category)/* only true when product.catagory < pivot.catagory */ )
                {
                    i++;
                    Product temp = products[i];
                    products[i] = products[j];
                    products[j] = temp;
                }
            }

            Product swapTemp = products[i + 1];
            products[i + 1] = products[high];
            products[high] = swapTemp;

            return i + 1;
        }

        public static void PrintProducts(string title, Product[] products)
        {
            Console.WriteLine($"\n{title}");
            foreach (var product in products)
                Console.WriteLine(product);
        }
    }
}
