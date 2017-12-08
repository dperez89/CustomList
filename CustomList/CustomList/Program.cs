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
            CustomList<string> listOne = new CustomList<string>() { "Hello", "World" };
            CustomList<string> listTwo = new CustomList<string>() { "Hello" };
            CustomList<string> listThree = new CustomList<string>();
            string expectedWord = "World";
            //Act
            listThree = listOne - listTwo;
        }
    }
}
