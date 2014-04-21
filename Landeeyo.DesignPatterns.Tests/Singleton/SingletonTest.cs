using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Singleton;
using NUnit.Framework;

namespace Landeeyo.DesignPatterns.Tests.Singleton
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void SimpleSingletonTest()
        {
            //arrange
            var properResult = "It's me, singleton!";

            //act
            string result = SimpleSingleton.Execute();

            //assert
            Assert.AreEqual(properResult, result);
        }
    }
}
