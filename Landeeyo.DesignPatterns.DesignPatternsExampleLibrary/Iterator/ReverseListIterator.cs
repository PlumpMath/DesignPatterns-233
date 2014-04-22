using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Landeeyo.DesignPatterns.DesignPatternsExampleLibrary.Iterator
{
    public class ReverseListIterator : IIterator
    {
        private IList _list;
        private int _currentIndex;

        public ReverseListIterator(IList list)
        {
            _list = list;
        }

        public void First()
        {
            _currentIndex = _list.Count - 1;
        }

        public void Next()
        {
            _currentIndex--;
        }

        public bool IsDone
        {
            get { return _currentIndex < 0; }
        }

        public object CurrentItem
        {
            get { return _list[_currentIndex]; }
        }
    }
}
