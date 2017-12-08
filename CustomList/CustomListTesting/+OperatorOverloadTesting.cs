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
            Assert.AreEqual(listThree[1], listOne[0]);
        }
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
        public void OverLoadAdditionOperator_ThreeStringLists_ReturnElementFromSecondStringList()
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
