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
        public void OverloadSubtractionOperator_TwoStringLists_ReturnArrayElement()
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
        public void OverloadSubtractionOperator_TwoStringListsWithMultipleMatches_ReturnArrayElement()
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
        public void OverloadSubtractionOperator_TwoStringListWithMultipleMatchesReversedOrdered_ReturnArrayElement()
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
        [TestMethod]
        public void OverloadSubtractionOperator_TwoIntLists_ReturnArrayElement()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2 };
            CustomList<int> listTwo = new CustomList<int>() { 1 };
            CustomList<int> listThree = new CustomList<int>();
            int expectedNumber = 2;
            //Act
            listThree = listOne - listTwo;
            //Assert
            Assert.AreEqual(listThree[0], expectedNumber);

        }
        [TestMethod]
        public void OverloadSubtractionOperator_TwoIntListsWithMultipleMatches_ReturnArrayElement()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> listTwo = new CustomList<int>() { 1, 2 };
            CustomList<int> listThree = new CustomList<int>();
            int expectedNumber = 3;
            //Act
            listThree = listOne - listTwo;
            //Assert
            Assert.AreEqual(listThree[0], expectedNumber);
        }
    }
}
