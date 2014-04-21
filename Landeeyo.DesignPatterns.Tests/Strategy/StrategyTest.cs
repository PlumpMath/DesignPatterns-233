using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Strategy;

namespace Landeeyo.DesignPatterns.Tests.Strategy
{
    [TestFixture]
    public class StrategyTest
    {
        [Test]
        public void ConcreteStrategyAddTest()
        {
            //arrange
            var a = 2;
            var b = 2;
            var properResult = 4;
            IStrategy strategy = new Add();
            StrategyContext context = new StrategyContext(strategy);

            //act
            var result = context.Execute(a, b);

            //assert
            Assert.AreEqual(properResult, result);
        }

        [Test]
        public void ConcreteStrategySubtractTest()
        {
            //arrange
            var a = 128;
            var b = 64;
            var properResult = 64;
            IStrategy strategy = new Subtract();
            StrategyContext context = new StrategyContext(strategy);

            //act
            var result = context.Execute(a, b);

            //assert
            Assert.AreEqual(properResult, result);
        }

        [Test]
        public void ConcreteStrategyMultiplyTest()
        {
            //arrange
            var a = 8;
            var b = 3;
            var properResult = 24;
            IStrategy strategy = new Multiply();
            StrategyContext context = new StrategyContext(strategy);

            //act
            var result = context.Execute(a, b);

            //assert
            Assert.AreEqual(properResult, result);
        }

    }
}
