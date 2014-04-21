using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Strategy
{
    public interface IStrategy
    {
        double Execute(double a, double b);
    }
}
