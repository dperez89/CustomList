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
        public void AddToArray_OneString_ReturnArrayElement()
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
        [TestMethod]
        public void AddToArray_TwoString_ReturnArrayElement()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string stringOne = "first test";
            string stringTwo = "second test";
            //Act
            testList.Add(stringOne);
            testList.Add(stringTwo);
            string actualResult = testList[1];
            //Assert
            Assert.AreEqual(stringTwo, actualResult);
        }
        [TestMethod]
        public void AddToArray_OneString_ReturnIncreasedCount()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string testInput = "test";
            int expectedCount = 1;
            //Act
            testList.Add(testInput);
            int actualCount = testList.Count;
            //Assert
            Assert.AreEqual(testList.Count, expectedCount);
        }
        [TestMethod]
        public void AddToArray_SixString_ReturnIncreasedCount()
        {
            //Arrange
            CustomList<string> testList = new CustomList<string>();
            string stringOne = "test one";
            string stringTwo = "test two";
            string stringThree = "test two";
            string stringFour = "test two";
            string stringFive = "test two";
            string stringSix = "test two";
            int expectedCount = 6;
            //Act
            testList.Add(stringOne);
            testList.Add(stringTwo);
            testList.Add(stringThree);
            testList.Add(stringFour);
            testList.Add(stringFive);
            testList.Add(stringSix);
            //Assert
            Assert.AreEqual(testList.Count, expectedCount);
        }                
        [TestMethod]
        public void AddToArray_OneInteger_ReturnArray()
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
        [TestMethod]
        public void AddToArray_EightInteger_ReturnArray()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int> { };
            int intOne = 1;
            int intTwo = 2;
            int intThree = 3;
            int intFour = 4;
            int intFive = 5;
            int intSix = 6;
            int intSeven = 7;
            int intEight = 8;
            //Act
            testList.Add(intOne);
            testList.Add(intTwo);
            testList.Add(intThree);
            testList.Add(intFour);
            testList.Add(intFive);
            testList.Add(intSix);
            testList.Add(intSeven);
            testList.Add(intEight);
            int actualResult = testList[7];
            //Assert
            Assert.AreEqual(intEight, actualResult);
        }
        [TestMethod]
        public void AddToArray_OneChar_ReturnArray()
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
