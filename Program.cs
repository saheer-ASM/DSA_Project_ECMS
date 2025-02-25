using DSA_Project_ECMS;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(1, "Laptop", "Electronics", 1200),
            new Product(2, "Phone", "Electronics", 800),
            new Product(3, "Book", "Stationery", 30),
            new Product(4, "Mouse", "Accessories", 25),
            new Product(5, "Keyboard", "Accessories", 60),
            new Product(6, "Phone", "Electronics", 900),
            new Product(7, "Book", "Stationery", 30),
            new Product(8, "Laptop", "Electronics", 1300),
            new Product(9, "Laptop", "Electroncs", 6500),
            new Product(10, "Laptop", "Electroncs", 6300),
            new Product(11, "Laptop", "Electroncs", 6400),
            new Product(12, "Laptop", "Electroncs", 6500),
            new Product(13, "Laptop", "Electronics", 1300),
            new Product(14, "Laptop", "Electroncs", 64500),
            new Product(15, "Laptop", "Electroncs", 64000),

        };
        Console.WriteLine("Select a number to sort");
        Console.WriteLine("==============================");

        Console.WriteLine("1 => Sorting According to price");
        Console.WriteLine("2 => Sorting According to Item");
        Console.WriteLine("3 => Sorting According to Catagary");
        
        bool quit = false;
        while (quit == false)
        {
            int sortselect = Convert.ToInt32(Console.ReadLine());
            if (sortselect == 1)
            {
                // Sorting by Price (Bubble Sort)
                Sorting.BubbleSort(products, products.Length);
                Console.WriteLine("1 => low price to high price");
                Console.WriteLine("2 => high price to low price");
                Console.WriteLine("3 => less than a price");
                Console.WriteLine("4 => higher than a price");
                int selectsort1 = Convert.ToInt32(Console.ReadLine());
                if (selectsort1 == 1)
                {
                    Sorting.PrintProductsLtH("Sorted by Price (Bubble Sort)", products);
                }
                else if (selectsort1 == 2)
                {
                    Sorting.PrintProductsHtL("Sorted by Price (Bubble Sort)", products);
                }
                else if (selectsort1 == 3)
                {
                    Console.WriteLine("Input a Value");
                    int val = Convert.ToInt32(Console.ReadLine());
                    Sorting.PrintProductsL("Sorted by Price (Bubble Sort)", products, val);
                }
                else if (selectsort1 == 4)
                {
                    Console.WriteLine("Input a Value");
                    int val = Convert.ToInt32(Console.ReadLine());
                    Sorting.PrintProductsH("Sorted by Price (Bubble Sort)", products, val);
                }
                else
                    
                {
                    Console.WriteLine("Wrong input");
                    
                 }
                quit = true;




            }
        }
/*
        // Sorting by Price (Bubble Sort)
        Sorting.BubbleSort(products, products.Length);
        //Sorting.PrintProducts("Sorted by Price (Bubble Sort)", products);
        //Sorting.PrintProducts("Sorted by Price (Bubble Sort)", products, 1500);

        // Sorting by Name (Merge Sort)
        MergeSort.MergeSortAlgo(products, 0, products.Length - 1);
        MergeSort.PrintProducts("Sorted by Name (Merge Sort)", products);

        // Sorting by Category (Quick Sort)
        QuickSort.QuickSortAlgo(products, 0, products.Length - 1);
        QuickSort.PrintProducts("Sorted by Category (Quick Sort)", products);
*/
    }
}