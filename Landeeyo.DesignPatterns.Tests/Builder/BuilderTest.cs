using Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder;
using NUnit.Framework;

namespace Landeeyo.DesignPatterns.Tests.Builder
{
    [TestFixture]
    public class BuilderTest
    {
        [Test]
        public void CarBuilderTest()
        {
            //arrange
            Car expectedResult =
                new Car()
                {
                    FuelType = Fuel.Solar,
                    MaxSpeed = 201,
                    SeatCount = 2
                };
            Car result = null;

            //act
            
            var builder = new TeslaBuilder();
            builder.SetFuel();
            builder.SetMaxSpeed();
            builder.SetSeatCount();
            result = builder.GetCar;

            //assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
