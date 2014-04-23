using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder;
using NUnit.Framework;

namespace Landeeyo.DesignPatterns.Tests.Builder
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void ConnectionBuilderTest()
        {
            //arrange
            Connection expectedResult =
                new Connection()
                {
                    Address = "google.com",
                    Port = 80,
                    Type = ConnectionType.TCP
                };
            Connection result = null;

            //act

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
