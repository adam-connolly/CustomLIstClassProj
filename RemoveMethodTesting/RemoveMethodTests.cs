using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace RemoveMethodTesting
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void Remove_RemoveIntFromList_CountDecreasesBy1()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int expectedCount = 0;
            int actualCount;

            //act
            testList.Add(value1);
            testList.Remove(testList[0]);
            actualCount = testList.Count;

            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Remove_RemoveSpecifiedIntFromList_ListDoesNotContainInt2()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expectedResult = false;
            bool actualResult;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(2);
            actualResult = testList.Contains(2);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_RemoveIntAtIndex_IndexOutOfBounds()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;

            //act
            testList.Add(value1);
            testList.Remove(testList[1]);
        }
        //try to remove a number: doesnt exist, returns bool true/false. 
    }
}
