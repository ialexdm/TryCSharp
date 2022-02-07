using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Plate
    {
        private int _food;
        public Plate(int food)
        {
            _food = food;
        }
        public bool DecreaseFood(int n)
        {
            bool isDecreased = false;
            if (_food >= n)
            {
                _food -= n;
                isDecreased = true;
            }
            return isDecreased;
        }
        public void Fill(int food)
        {
            _food += food;
        }

        public void Info()
        {
            Console.WriteLine("plate: " + _food);
        }
    }
}
