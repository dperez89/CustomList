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
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
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
            int j = 0;
            CustomList<T> newList = new CustomList<T>();
            if (newList.Capacity < (listOne.Count + listTwo.Count))
            {
                newList.IncreaseCapacity();
            }
            int listOneCount = listOne.Count;
            int listTwoCount = listTwo.Count;
            for (int i = 0; i < listOne.Count; i++)
            {
                newList[i] = listOne[i];
                newList.Count++;
            }
            for (int i = listOne.Count; i < (listOne.Count + listTwo.Count); i++)
            {
                newList[i] = listTwo[j];
                newList.Count++;
                j++;
            }
            return newList;

        }
        public static CustomList<T> operator- (CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listTwo.Count; i++)
            {
                for (int j = 0; j < listOne.Count; j++)
                {
                    if(listTwo[i].Equals(listOne[j]))
                    {
                        listOne.Remove(listOne[j]);
                    }
                }
            }
            return listOne;
        }
    }
}
