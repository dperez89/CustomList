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
            for(int i = 0; i < listOne.Count; i++)
            {
                Assert.AreEqual(listOne[i], listTwo[i]);
            }
        }
        [TestMethod]
        public void RunForEachLoop_TwoIntLists_ReturnStringListIdenticalToOriginal()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>();

            //Act
            foreach (int element in listOne)
            {
                listTwo.Add(element);
            }
            //Assert
            for (int i = 0; i < listOne.Count; i++)
            {
                Assert.AreEqual(listOne[i], listTwo[i]);
            }
        }
        [TestMethod]
        public void RunForEachLoop_TwoCharLists_ReturnStringListIdenticalToOriginal()
        {
            //Arrange
            CustomList<char> listOne = new CustomList<char>() { 'a','b','c' };
            CustomList<char> listTwo = new CustomList<char>();

            //Act
            foreach (char element in listOne)
            {
                listTwo.Add(element);
            }
            //Assert
            for (int i = 0; i < listOne.Count; i++)
            {
                Assert.AreEqual(listOne[i], listTwo[i]);
            }
        }
    }
}
