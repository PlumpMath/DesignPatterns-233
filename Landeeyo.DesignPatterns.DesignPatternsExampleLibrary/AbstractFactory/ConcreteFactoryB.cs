using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.AbstractFactory
{
    public class ConcreteFactoryB : IAbstractFactory
    {
        public IClassA CreateObjectA()
        {
            return new ClassBA();
        }

        public IClassB CreateObjectB()
        {
            return new ClassBB();
        }
    }
}
