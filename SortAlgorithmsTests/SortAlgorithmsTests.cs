using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace SortExamples.Tests
{
    [TestClass()]
    public class SortAlgorithmsTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            var sortedList = SortAlgorithms.BubbleSort(new List<int>() { 100, 2, 4473, 1, 474, 5, 7, 3, 55, 4, 8, 12 });
            var list = sortedList as int[] ?? sortedList.ToArray();
            Assert.AreEqual(list.ElementAt(1),2);
            Assert.AreEqual(list.ElementAt(6), 8);
            Assert.AreEqual(list.Count(), 12);
        }
    }
}