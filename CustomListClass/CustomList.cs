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
                SwapArray(ref items);
                items[i] = item;
                count++;
            }
        }
        private T[] SwapArray(ref T[] oldArray)
        {
            //instantiate newArray at 2x capacity
            T[] newArray = new T[oldArray.Length * 2];
            Capacity = newArray.Length;
            //assign to temp value
            T[] tempArray = new T[oldArray.Length];
            
            //transfer values over to corresponding indices
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }
            //reassign newArray to oldArray
            tempArray = oldArray;
            oldArray = newArray;
            //delete oldArray
            return oldArray;
        }
    }
}
