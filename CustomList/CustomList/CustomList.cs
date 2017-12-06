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
        private int capacity = 0;
        private T[] list;

        public int Length
        {
            get
            {
                return list.Length;
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
        public void Add(T testInput)
        {

        }
    }
}
