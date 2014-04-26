using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory;

namespace Landeeyo.DesignPatterns.Tests.AbstractFactory
{
    [TestFixture]
    public class AbstractFactoryTest
    {
        [Test]
        public void DALAbstractFactoryTest()
        {
            //arrange
            IAbstractFactory factoryA = new ConcreteFactoryA();
            IAbstractFactory factoryB = new ConcreteFactoryB();
            var expectedResult1 = "fAmA";
            var expectedResult2 = "fAmB";
            var expectedResult3 = "fBmA";
            var expectedResult4 = "fBmB";

            //act
            var result1 = factoryA.CreateObjectA().MethodA();
            var result2 = factoryA.CreateObjectB().MethodB();
            var result3 = factoryB.CreateObjectA().MethodA();
            var result4 = factoryB.CreateObjectB().MethodB();

            //assert
            Assert.AreEqual(expectedResult1, result1);
            Assert.AreEqual(expectedResult2, result2);
            Assert.AreEqual(expectedResult3, result3);
            Assert.AreEqual(expectedResult4, result4);
        }
    }
}
