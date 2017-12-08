using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomList;

namespace CustomListTesting
{
    /// <summary>
    /// Summary description for _OperatorOverloadTesting
    /// </summary>
    [TestClass]
    public class _OperatorOverloadTesting
    {
        [TestMethod]
        public void OverLoadAdditionOperator_TwoStringLists_ReturnElementFromFirstStringList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello" };
            CustomList<string> listTwo = new CustomList<string>() { "World" };
            CustomList<string> listThree = new CustomList<string>();

            //Act
            listThree = listOne + listTwo;
            //Assert
            Assert.AreEqual(listThree[0], listOne[0]);
        }
        [TestMethod]
        public void OverLoadAdditionOperator_TwoStringLists_ReturnElementFromSecondStringList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello" };
            CustomList<string> listTwo = new CustomList<string>() { "World" };
            CustomList<string> listThree = new CustomList<string>();

            //Act
            listThree = listOne + listTwo;
            //Assert
            Assert.AreEqual(listThree[1], listTwo[0]);
        }
        [TestMethod]
        public void OverLoadAdditionOperator_ThreeStringLists_ReturnElementFromThirdStringList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello" };
            CustomList<string> listTwo = new CustomList<string>() { "World" };
            CustomList<string> listThree = new CustomList<string>() { "Again" };
            CustomList<string> listFour = new CustomList<string>();
            //Act
            listFour = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(listFour[2], listThree[0]);

        }
        [TestMethod]
        public void OverLoadAdditionOperator_ThreeStringListsWithDifferentAmountsOfElements_ReturnElementFromThirdStringList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello","World" };
            CustomList<string> listTwo = new CustomList<string>() { "Again" };
            CustomList<string> listThree = new CustomList<string>() { "And","Again" };
            CustomList<string> listFour = new CustomList<string>();
            //Act
            listFour = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(listFour[4], listThree[1]);

        }
        [TestMethod]
        public void OverLoadAdditionOperator_TwoIntLists_ReturnElementFromFirstIntList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1 };
            CustomList<int> listTwo = new CustomList<int>() { 2 };
            CustomList<int> listThree = new CustomList<int>();

            //Act
            listThree = listOne + listTwo;
            //Assert
            Assert.AreEqual(listThree[0], listOne[0]);
        }
        [TestMethod]
        public void OverLoadAdditionOperator_TwoIntLists_ReturnElementFromSecondIntList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1 };
            CustomList<int> listTwo = new CustomList<int>() { 2 };
            CustomList<int> listThree = new CustomList<int>();

            //Act
            listThree = listOne + listTwo;
            //Assert
            Assert.AreEqual(listThree[1], listTwo[0]);
        }
        [TestMethod]
        public void OverLoadAdditionOperator_ThreeIntLists_ReturnElementFromThirdIntList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>() { 1 };
            CustomList<int> listTwo = new CustomList<int>() { 2 };
            CustomList<int> listThree = new CustomList<int>() { 3 };
            CustomList<int> listFour = new CustomList<int>();
            //Act
            listFour = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(listFour[2], listThree[0]);

        }
        [TestMethod]
        public void OverLoadAdditionOperator_ThreeIntListsWithDifferentAmountsOfElements_ReturnElementFromThirdIntList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>() { "Hello" };
            CustomList<string> listTwo = new CustomList<string>() { "World" };
            CustomList<string> listThree = new CustomList<string>() { "Again" };
            CustomList<string> listFour = new CustomList<string>();
            //Act
            listFour = listOne + listTwo + listThree;
            //Assert
            Assert.AreEqual(listFour[2], listThree[0]);

        }
    }
}
