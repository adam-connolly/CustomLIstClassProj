using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;


namespace CustomListClass
{
    [TestClass]
    public class AddMethodTesting
    {
        [TestMethod]
        public void Add_CheckCount_AddIntegerToList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int number1 = 3;
            int expectedCount = 1;
            int actualCount;
            //act
            testList.Add(number1);
            actualCount = testList.Count;
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Add_CheckZeroIndex_AddIntegerToList()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int number1 = 3;
            int expectedCount = 3;
            int actualCount;
            //act
            testList.Add(number1);
            actualCount = testList[0];
            //assert
            Assert.AreEqual(expectedCount, actualCount);
        }
        [TestMethod]
        public void Add_CheckCapacity_CapacityIs4()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int expectedCapacity = 4;
            int actualCapacity;
            //act
            testList.Add(value1);
            actualCapacity = testList.Capacity;
            //assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }
        [TestMethod]
        public void Add_CheckCapacity_CapacityIs8()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int expectedCapacity = 8;
            int actualCapacity;
            //act
            testList.Add(value1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actualCapacity = testList.Capacity;
            //assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }
        [TestMethod]
        public void Add_CheckCapacity_CapacityIs16()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int value1 = 1;
            int expectedCapacity = 16;
            int actualCapacity;
            //act
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);
            testList.Add(value1);

            actualCapacity = testList.Capacity;
            //assert
            Assert.AreEqual(expectedCapacity, actualCapacity);
        }
        [TestMethod]
        public void Add_CheckListOrder_DisplayListInOrderCreated()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expected = "123456";
            string actual = "";

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);

            for(int i = 0; i < testList.Count; i++)
            {
                actual += testList[i];
            }

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
