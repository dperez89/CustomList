using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTesting
{
    [TestClass]
    class RemoveTesting
    {
        //--------------------------STRING DATATYPE----------------------------------------
        [TestMethod]
        public void RemoveFromArray_OneStringInput_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "green", "blue" };
            string removeThisWord = "green";
            string expectedWord = "blue";
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(expectedWord, list[1]);
        }
        [TestMethod]
        public void RemoveFromArray_OneStringInput_ReturnArrayCount()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "green", "blue" };
            string removeThisWord = "green";
            int expectedCount = 2;
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(expectedCount, list.Count);
        }
        [TestMethod]
        public void RemoveFromArray_OneStringInput_ReturnEmptyArrayIndex()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red" };
            string removeThisWord = "red";
            string expectedWord = "";
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(expectedWord, list[0]);
        }
        [TestMethod] //NEEDS AN EXTRA CHECK
        public void RemoveFromArray_OneStringInput_ReturnTrue()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "green", "blue" };
            string removeThisWord = "blue";
            bool expectedStatus = true;
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(expectedStatus, true);
        }
        [TestMethod] //NEEDS TO AN EXTRA CHECK
        public void RemoveFromArray_OneStringInput_ReturnFalse()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "green", "blue" };
            string removeThisWord = "cheese";
            bool expectedStatus = false;
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(expectedStatus, false);
        }
        [TestMethod]
        public void RemoveFromArray_OneEmptyStringInput_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "" ,"blue"};
            string removeThisWord = "";
            string expectedWord = "blue";
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(list[1], expectedWord);
        }

        //--------------------------INT DATATYPE----------------------------------------
        [TestMethod]
        public void RemoveFromArray_OneIntInput_ReturnArrayElement()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int removeThisNumber = 1;
            int expectedNumber = 2;
            //Act
            list.Remove(removeThisNumber);
            //Assert
            Assert.AreEqual(list[0], expectedNumber);
        }
        [TestMethod]
        public void RemoveFromArray_OneIntInput_ReturnArrayCount()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>() { 1, 2, 3 };
            int removeThisNumber = 1;
            int expectedCount = 2;
            //Act
            list.Remove(removeThisNumber);
            //Assert
            Assert.AreEqual(list.Count, expectedCount);
        }
        //--------------------------CHAR DATATYPE----------------------------------------
        [TestMethod]
        public void RemoveFromArray_OneCharInput_ReturnArrayElement()
        {
            CustomList<char> list = new CustomList<char>() { 'a', 'b', 'c' };
            char removeThisLetter = 'a';
            char expectedLetter = 'b';
            //Act
            list.Remove(removeThisLetter);
            //Assert
            Assert.AreEqual(list[0], expectedLetter);
        }
    }
}
