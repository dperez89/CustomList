using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTesting
{
    [TestClass]
    class RemoveTesting
    {
        [TestMethod]
        public void RemoveFromArray_OneStringInput_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>() { "red", "green", "blue" };
            string removeThisWord = "blue";
            string expectedWord = "green";
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
            string removeThisWord = "blue";
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
        [TestMethod]
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
        [TestMethod]
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
            CustomList<string> list = new CustomList<string>() { "red", "" };
            string removeThisWord = "";
            string expectedWord = "red";
            //Act
            list.Remove(removeThisWord);
            //Assert
            Assert.AreEqual(list[0], expectedWord);
        }
    }
}
