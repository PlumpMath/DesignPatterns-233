using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Builder
{
    public interface ICarBuilder
    {
        Car GetCar { get; }
        void SetFuel();
        void SetMaxSpeed();
        void SetSeatCount();
    }
}
