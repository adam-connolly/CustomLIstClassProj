using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace AddMethodTests
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
        public void Remove_RemoveSpecifiedIntFromList_SuccessfullyRemoveInt()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expectedResult = true;
            bool actualResult;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(2);
            for(int i = 0; i < testList.Count; i++)
            {
                if(testList[i] != 2)
                {
                    actualResult = true;
                }
            }

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
        [TestMethod]
        public void Remove_RemoveIntInList_ListDoesNotContainInt()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expectedReturn = false;
            bool actualReturn;

            //act
            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(4);
        }
        [TestMethod]
        public void Remove_RemoveAtSpecificIndex_SuccessfullyRemoved()
        {
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            bool expectedResult = true;
            bool actualResult;

            testList.Add(value1);
            testList.Add(value2);
            testList.Add(value3);
            testList.Remove(testList[2]);
        }
    }
}
