using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class CustomArray<T>
    {
        private T[] items;
        private int count;

        public CustomArray(int size)
        {
            items = new T[size];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
                Resize();
            items[count++] = item;
        }

        private void Resize()
        {
            T[] newItems = new T[items.Length * 2];
            for (int i = 0; i < items.Length; i++)
                newItems[i] = items[i];
            items = newItems;
        }

        public int Count()
        {
            return count;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of range");
            return items[index];
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }
}
