using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder
{
    public class Car
    {
        public Fuel FuelType { get; set; }
        public int MaxSpeed { get; set; }
        public int SeatCount { get; set; }

        public override string ToString()
        {
            return string.Format(
                    "{0} car with {1} max speed and {2} seats}",
                    FuelType.ToString(),
                    MaxSpeed.ToString(),
                    SeatCount.ToString());
        }

        public override bool Equals(System.Object obj)
        {
            Car car = obj as Car;
            if ((object)car == null)
            {
                return false;
            }

            //TODO Examine why base.equals returns false even if it should be true...
            return //base.Equals(obj) &&
                FuelType == car.FuelType &&
                SeatCount == car.SeatCount &&
                MaxSpeed == car.MaxSpeed;
        }
    }

    public enum Fuel
    {
        Gasoline, Diesel, Electric, Hydrogen, Solar
    }
}
