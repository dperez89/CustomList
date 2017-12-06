using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections.Generic;

namespace CustomListTesting
{
    [TestClass]
    public class AddTesting
    {
        [TestMethod]
        public void AddToArray_String_ReturnArray()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testInput = "test";
            //Act
            testList.Add(testInput);
            string actualResult = testList[0];
            //Assert
            Assert.AreEqual(testInput, actualResult);            
        }
        public void AddToArray_String_ReturnIncreasedCount()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testInput = "test";
            int expectedCount = 1;
            //Act
            testList.Add(testInput);
            int actualCount = testList.Length;
            //Assert
            Assert.AreEqual(testList.Length, expectedCount);
        }
        public void AddToArray_Integer_ReturnArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int> { };
            int testInput = 10;
            //Act
            testList.Add(testInput);
            int actualResult = testList[0];
            //Assert
            Assert.AreEqual(testInput, actualResult);
        }
        public void AddToArray_Char_ReturnArray()
        {
            //Arrange
            CustomList<char> testList = new CustomList<char> { };
            char testInput = 'a';
            //Act
            testList.Add(testInput);
            char actualResult = testList[0];
            //Assert
            Assert.AreEqual(testInput, actualResult);
        }
    }
}
