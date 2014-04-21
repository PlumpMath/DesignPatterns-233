using System;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Strategy
{
    public class Multiply : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a * b;
        }
    }
}
