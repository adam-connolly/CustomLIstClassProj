using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {
        int count;
        public int Count { get { return count; } }
        int capacity;
        public int Capacity { get { return capacity; } set { capacity = value; } }
        private T[] items;
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }
        public void Add(T item)
        {
            if(Count < Capacity)
            {
                int i = count;
                items[i] = item;
                count++;
            }
            else
            {
                int i = count;
                SwapArray();
                items[i] = item;
                count++;
            }
        }
        private void SwapArray()
        {
            T[] newArray = new T[capacity *= 2];            
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            items = newArray;
        }
        public void Remove(T item)
        {

        }

    }
}
