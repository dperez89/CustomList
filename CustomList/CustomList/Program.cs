using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "one", null, "three" };
            CustomList<string> listTwo = new CustomList<string>();

            //Act
            foreach (string element in listOne)
            {
                listTwo.Add(element);
            }
            bool areEqual = listOne.Equals(listTwo);
        }
    }
}
