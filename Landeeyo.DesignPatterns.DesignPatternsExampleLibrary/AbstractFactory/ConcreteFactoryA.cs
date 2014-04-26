using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory
{
    public class ConcreteFactoryA : IAbstractFactory
    {
        public IClassA CreateObjectA()
        {
            return new ClassAA();
        }

        public IClassB CreateObjectB()
        {
            return new ClassAB();
        }
    }
}
