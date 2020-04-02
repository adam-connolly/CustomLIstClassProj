using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace AddMethodTests
{
    [TestClass]
    public class ZipMethodTesting
    {
        [TestMethod]
        public void Zip_TwoListsOfInts_ReturnsOneListOfInts()
        {
            CustomList<int> testList1 = new CustomList<int>();            
            CustomList<int> testList2 = new CustomList<int>();
            string expectedResult = "123456";
            string actualResult;

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_TwoListsOfStrings_ReturnOneListOfStrings()
        {
            CustomList<string> testList1 = new CustomList<string>();
            CustomList<string> testList2 = new CustomList<string>();
            string expectedResult = "GoodMorningHelloWorld";
            string actualResult;

            testList1.Add("Good");
            testList1.Add("Hello");
            testList2.Add("Morning");
            testList2.Add("World");

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_OriginalListLongerThanPassedList_ReturnOneListOfStringsFirstPartZippedSecondPartPrintInOrderTheRemainingValues()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expectedResult = "1234567890";
            string actualResult;

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList1.Add(7);
            testList1.Add(8);
            testList1.Add(9);
            testList1.Add(0);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_PassedlListLongerThanOriginalList_ReturnOneListOfStringsFirstPartZippedSecondPartPrintInOrderTheRemainingValues()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expectedResult = "1234567890";
            string actualResult;

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);            
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            testList2.Add(7);
            testList2.Add(8);
            testList2.Add(9);
            testList2.Add(0);

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_CapacityCheckOfZippedList_CapacityShouldBe16()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int expectedResult = 16;
            int actualResult;

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);
            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);
            testList2.Add(7);
            testList2.Add(8);
            testList2.Add(9);
            testList2.Add(0);

            testList1.Zip(testList2);
            actualResult = testList1.Capacity;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_PassedListIsEmpty_ReturnsOriginalListAsIs()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expectedResult = "135";
            string actualResult;

            testList1.Add(1);
            testList1.Add(3);
            testList1.Add(5);

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Zip_OriginalListIsEmpty_ReturnsPassedListAsIs()
        {
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            string expectedResult = "246";
            string actualResult;

            testList2.Add(2);
            testList2.Add(4);
            testList2.Add(6);

            testList1.Zip(testList2);
            actualResult = testList1.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
