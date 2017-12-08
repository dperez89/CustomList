using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    public class CustomList<T> : IEnumerable
    {
        private int iterationCount;
        private int count;
        private int capacity = 6;
        private T[] list;

        public int IterationCount
        {
            get
            {
                return iterationCount;
            }
            set
            {
                iterationCount = value;
            }
        }
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
        public void Remove(T input)
        {
            for (int i = 0; i < Count; i++)
            {
                if (list[i].Equals(input))
                {
                    AdjustArray(input, i);
                    count--;
                    return;
                }
            }
        }
        public void AdjustArray(T input, int i)
        {
            for (int j = i; j <= Count; j++)
            {
                list[j] = list[j + 1];
            }
        }
        public void IncreaseCapacity()
        {
            capacity += 6;
            T[] newList = new T[capacity];
            for (int i = 0; i <= count; i++)
            {
                newList[i] = list[i];
            }
            list = newList;

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return list[i];
            }
        }
        public static CustomList<T> operator+ (CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();
            int listOneCount = listOne.Count;
            int listTwoCount = listTwo.Count;
            for (int i = 0; i < listOne.Count; i++)
            {
                newList[i] = listOne[i];
            }
            for (int i = listOne.Count; i < (listOne.Count + listTwo.Count); i++)
            {
                newList[i] = listTwo[i - listTwo.Count];
            }
            return newList;

        }
    }
}
