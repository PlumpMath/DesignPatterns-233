using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Iterator
{
    public interface IIterator
    {
        void First();
        void Next();
        bool IsDone { get; }
        object CurrentItem { get; }
    }
}
