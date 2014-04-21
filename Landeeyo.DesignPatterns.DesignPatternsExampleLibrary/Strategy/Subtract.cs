using System;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Strategy
{
    public class Subtract : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }
    }
}
