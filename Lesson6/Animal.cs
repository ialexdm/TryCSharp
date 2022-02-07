using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public class Animal
    {
        protected double _maxSwimDistance;
        protected double _maxRunDistance;
        protected double _maxJumpHeight;
        private static int _count;
        public static int Count
        {
            get
            { return _count; }
            set
            { _count = value; }
        }

        protected Animal()
        {
            Count++;
        }

        public virtual void Swim(double distance)
        {
            bool isSuccess = _maxSwimDistance > distance;
            Console.WriteLine($"swim: {isSuccess}");
        }
        public virtual void Run(double distance)
        {
            bool isSuccess = _maxRunDistance > distance;
            Console.WriteLine($"run: {isSuccess}");
        }
        public virtual void Jump(double height)
        {
            bool isSuccess = _maxJumpHeight > height;
            Console.WriteLine($"jump: {isSuccess}");
        }

    }
}
