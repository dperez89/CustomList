using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string stringOne = "first test";
            string stringTwo = "second test";
            string stringThree = "second test";
            string stringFour = "second test";
            string stringFive = "second test";
            string stringSix = "second test";
            string stringSeven = "second test";
            string stringEight = "second test";

            //Act
            testList.Add(stringOne);
            testList.Add(stringTwo);
            testList.Add(stringThree);
            testList.Add(stringFour);
            testList.Add(stringFive);
            testList.Add(stringSix);
            testList.Add(stringSeven);
            testList.Add(stringEight);
            string actualResult = testList[1];
            //Assert
        }
    }
}
