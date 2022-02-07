using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    public class Cat
    {
        private string _name;
        private int _appetite;
        private bool _isFull;
        public Cat(string name, int appetite)
        {
            _isFull = false;
            _name = name;
            _appetite = appetite;
        }
        public void Eat(Plate p)
        {
            _isFull = p.DecreaseFood(_appetite);
        }
        public void Info()
        {
            Console.WriteLine($"The cat {_name} isFull = {_isFull}");
        }
    }
}
