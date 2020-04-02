using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace AddMethodTests
{
    [TestClass]
    public class SubtractOperatorTesting
    {
        [TestMethod]
        public void Subtract_RemoveValue_ValueIsRemovedFromList()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "124";
            string actualResult;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list2.Add(3);

            result = list1 - list2;
            actualResult = result.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_RemoveValue_ValueIsNotRemovedFromList()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "1234";
            string actualResult;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list2.Add(5);

            result = list1 - list2;
            actualResult = result.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_RemoveValue_SecondListIsEmpty()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "1234";
            string actualResult;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);

            result = list1 - list2;
            actualResult = result.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_RemoveValue_FirstListIsEmpty()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "";
            string actualResult;

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);

            result = list1 - list2;
            actualResult = result.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Subtract_RemoveMultipleValues_MultipleValuesRemovedFromList()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> result;
            string expectedResult = "14";
            string actualResult;

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list2.Add(2);
            list2.Add(3);

            result = list1 - list2;
            actualResult = result.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
