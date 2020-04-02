using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T> : IEnumerable
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
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }                
                return items[i];
            }
            set
            {
                if (i >= count || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
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
            if(count < capacity)
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
        public bool Remove(T item)
        {
            bool doesContain = false;
            T[] temp = new T[capacity];
            for(int i = 0, j = 0; i < count; i++, j++)
            {                   
                if (items[i].Equals(item))
                {
                    j--;                    
                    doesContain = true;
                }
                else
                {
                    temp[j] = items[i];
                }
            }
            if (doesContain)
            {
                count--;
            }
            return doesContain;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public string MakeString()
        {
            string newString = "";
            if(count <= 0)
            {
                Console.WriteLine("Empty List. Cannot create list.");
                return newString;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    newString += items[i];
                }
                return newString;
            }            
        }
        public CustomList<T> Zip(CustomList<T> list)
        {
            T[] temp = new T[capacity *= 2];
        }
    }
}
