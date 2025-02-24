using DSA_Project_ECMS;


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
            new Product(9, "rsa", "Electroncs", 6500),


        };

        // Sorting by Price (Bubble Sort)
        Sorting.BubbleSort(products, products.Length);
        Sorting.PrintProducts("Sorted by Price (Bubble Sort)", products);

        // Sorting by Name (Merge Sort)
        MergeSort.MergeSortAlgo(products, 0, products.Length - 1);
        MergeSort.PrintProducts("Sorted by Name (Merge Sort)", products);

        // Sorting by Category (Quick Sort)
        QuickSort.QuickSortAlgo(products, 0, products.Length - 1);
        QuickSort.PrintProducts("Sorted by Category (Quick Sort)", products);
    }
}