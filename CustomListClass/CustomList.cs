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
        public int Count { get; set; }
        int capacity;
        public int Capacity { get; set; }
        private T[] items;

        public CustomList()
        {
            capacity = 4;
            items = new T[capacity];
        }
        public void Add(T item)
        {
            if(Count <= Capacity)
            {
                for(int i = Count; i < Capacity; i++)
                {
                    items[i] = item;
                    Count++;
                }
            }           
        }
    }
}
