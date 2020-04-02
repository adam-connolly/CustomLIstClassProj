using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClass;

namespace AddMethodTests
{
    [TestClass]
    public class MakeStringTesting
    {
        [TestMethod]
        public void MakeString_ConvertListContentsToString_ReturnsStringOfNumbers()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            string expectedString = "1234";
            string actualString;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            actualString = testList.MakeString();

            //assert
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void MakeString_ConvertListContentsToString_ReturnsStringOfStrings()
        {
            //arrange
            CustomList<string> testList = new CustomList<string>();
            string expectedString = "OtisIsGraduatingToday";
            string actualString;

            //act
            testList.Add("Otis");
            testList.Add("Is");
            testList.Add("Graduating");
            testList.Add("Today");
            actualString = testList.MakeString();

            //assert
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void MakeString_ConvertListContentsToString_EmptyList()
        {
            CustomList<int> testList = new CustomList<int>();
            string expectedResult = "";
            string actualResult = testList.MakeString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
