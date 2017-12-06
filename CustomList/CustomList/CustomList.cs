using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private int count;
        private int capacity = 6;
        private T[] list;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
        public CustomList()
        {
            list = new T[capacity];
        }
        public void Add(T input)
        {
            if (count >= (capacity / 2))
            {
                IncreaseCapacity();
            }
            list[count] = input;
            count++;
        }
        public void IncreaseCapacity()
        {
            capacity += 6;
            T[] newList = new T[capacity];
            for(int i = 0; i <= count; i++)
            {
                newList[i] = list[i];
            }
            list = newList;

        }
    }
}
