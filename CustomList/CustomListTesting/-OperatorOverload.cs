using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;
namespace CustomListTesting
{
    [TestClass]
    public class _OperatorOverload
    {
        [TestMethod]
        public void SubtractFromArray_OneStringList_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello", "World" };
            CustomList<string> listTwo = new CustomList<string>() { "Hello" };
            CustomList<string> listThree = new CustomList<string>();
            string expectedWord = "World";
            //Act
            listThree = listOne - listTwo;
            //Assert
            Assert.AreEqual(listThree[0], expectedWord);
            
        }
        [TestMethod]
        public void SubtractFromArray_OneStringListWithMultipleMatches_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello", "World","Again" };
            CustomList<string> listTwo = new CustomList<string>() { "Hello","World" };
            CustomList<string> listThree = new CustomList<string>();
            string expectedWord = "Again";
            //Act
            listThree = listOne - listTwo;
            //Assert
            Assert.AreEqual(listThree[0], expectedWord);

        }
        [TestMethod]
        public void SubtractFromArray_OneStringListWithMultipleMatchesReversedOrdered_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello", "World","Again","And","Again" };
            CustomList<string> listTwo = new CustomList<string>() { "Again","And","Again","World" };
            CustomList<string> listThree = new CustomList<string>();
            string wordToExpect = "Hello";
            //Act
            listThree = listOne - listTwo;
            //Assert
            Assert.AreEqual(listThree[0], wordToExpect);

        }
    }
}
