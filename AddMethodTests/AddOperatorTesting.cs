using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace AddMethodTests
{
    [TestClass]
    public class AddOperatorTesting
    {
        [TestMethod]
        public void AddOperator_CombineTwoLists_List2AppendedToList1()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> combinedList;
            string expectedResult = "123456456";
            string actualResult;

            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            combinedList = testList1 + testList2;
            actualResult = combinedList.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddOperator_CombineTwoLists_List1AppendedToList2()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> combinedList;
            string expectedResult = "456456123";
            string actualResult;

            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            combinedList = testList2 + testList1;
            actualResult = combinedList.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddOperator_CheckCapacityOfCombinedList_CapacityIs8()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> combinedList;
            int expectedResult = 8;
            int actualResult;

            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            combinedList = testList1 + testList2;
            actualResult = combinedList.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddOperator_CheckCountOfCombinedList_CountIs6()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> combinedList;
            int expectedResult = 6;
            int actualResult;

            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            combinedList = testList1 + testList2;
            actualResult = combinedList.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void AddOperator_AddCombinedListToAnOriginalList_List1AppendedToCombinedList()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> combinedList;
            CustomList<int> finalList;
            string expectedResult = "123456123";
            string actualResult;

            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList2.Add(4);
            testList2.Add(5);
            testList2.Add(6);

            combinedList = testList1 + testList2;
            finalList = combinedList + testList1;
            actualResult = finalList.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
