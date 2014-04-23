using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder
{
    public class TeslaBuilder : ICarBuilder
    {
        private Car _car;

        public TeslaBuilder()
        {
            _car = new Car();
        }

        public Car GetCar
        {
            get { return _car; }
        }

        public void SetFuel()
        {
            _car.FuelType = Fuel.Solar;
        }

        public void SetMaxSpeed()
        {
            _car.MaxSpeed = 201;
        }

        public void SetSeatCount()
        {
            _car.SeatCount = 2;
        }
    }
}
