using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
    [TestClass]
    public class IterationTesting
    {
        [TestMethod]
        public void RunForEachLoop_CustomStringList_ReturnCounter()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "one", "two", "three", "four" };
            int expectedCounter = 4;
            //Act
            list.GetEnumerator();
            //Assert
            Assert.AreEqual(expectedCounter, list.IterationCount);
        }
        [TestMethod]
        public void RunForEachLoop_TwoStringLists_ReturnStringListIdenticalToOriginal()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> listTwo = new CustomList<string>();

            //Act
            foreach(string element in listOne)
            {
                listTwo.Add(element);
            }
            //Assert
            Assert.Equals(listOne, listTwo);

        }
    }
}
