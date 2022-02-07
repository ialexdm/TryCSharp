using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Dog : Animal
    {
        private static int _count;
        public static new int Count
        {
            get
            { return _count; }
            set
            { _count = value; }
        }
        public Dog() : base()
        {
            Count++;
            _maxJumpHeight = 0.5d;
            _maxRunDistance = 500.0d;
            _maxSwimDistance = 10.0d;
        }
    }
}
