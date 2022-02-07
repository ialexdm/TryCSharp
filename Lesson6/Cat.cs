using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Cat : Animal
    {
        private static int _count;
        public static new int Count 
        { get
            { return _count; }
            set 
            { _count = value; } 
        }
        public Cat() : base()
        { 
            
            Count++;
            _maxJumpHeight = 2.0d;
            _maxRunDistance = 200.0d;
            _maxSwimDistance = 0.0d;
        }
        public override void Swim(double distance)
        {
            bool isSuccess = false;
            Console.WriteLine($"swim: {isSuccess}");
        }


    }
}
