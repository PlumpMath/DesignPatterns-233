using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Iterator;

namespace Landeeyo.DesignPatterns.Tests.Iterator
{
    [TestFixture]
    public class IteratorTest
    {
        [Test]
        public void ReverseIteratorTest()
        {
            //arrange
            IIterator iterator = new ReverseListIterator();
            List<int> originalList = new List<int>(5) { 1, 2, 3, 4, 5 };
            List<int> iteratedList = new List<int>(5);
            List<int> expectedList = new List<int>(5) { 5, 4, 2, 2, 1 };

            //act
            for (iterator.First(); !iterator.IsDone; iterator.Next())
            {
                iteratedList.Add((int)iterator.CurrentItem);
            }

            //assert
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], iteratedList[i]);
            }            
        }
    }
}
