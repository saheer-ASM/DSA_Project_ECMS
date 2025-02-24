using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class MergeSort
    {
        public static void MergeSortAlgo(Product[] products, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortAlgo(products, left, mid);
                MergeSortAlgo(products, mid + 1, right);
                Merge(products, left, mid, right);
            }
        }

        private static void Merge(Product[] products, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;
            Product[] leftArray = new Product[leftSize];
            Product[] rightArray = new Product[rightSize];

            for (int i = 0; i < leftSize; i++)
                leftArray[i] = products[left + i];

            for (int i = 0; i < rightSize; i++)
                rightArray[i] = products[mid + 1 + i];

            int iLeft = 0, iRight = 0, iMerge = left;

            while (iLeft < leftSize && iRight < rightSize)
            {
                if (string.Compare(leftArray[iLeft].Name, rightArray[iRight].Name) <= 0)
                    products[iMerge++] = leftArray[iLeft++];
                else
                    products[iMerge++] = rightArray[iRight++];
            }

            while (iLeft < leftSize)
                products[iMerge++] = leftArray[iLeft++];
            while (iRight < rightSize)
                products[iMerge++] = rightArray[iRight++];
        }

        public static void PrintProducts(string title, Product[] products)
        {
            Console.WriteLine($"\n{title}");
            foreach (var product in products)
                Console.WriteLine(product);
        }
    }
}
