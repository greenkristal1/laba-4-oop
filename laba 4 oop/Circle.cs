using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4_oop
{
    class Circle : Base
    {

        public override string Name { get; init; } = "Circle";
        public int Radius { get; private set; }
        public int LX { get; private set; }

        public int LY { get; private set; }

        public Circle()
        {
            Radius = 50;
            LX = 1;
            LY = 1;

        }
        public Circle(int rad, int x, int y)
        {
            Radius = rad;
            LX = x;
            LY = y;

        }
        public Circle(Circle c)
        {
            Console.WriteLine("Copy constructor");
            this.Radius = c.Radius;
        }
        public override void printName()
        {
            Console.WriteLine($"The name of this object is {Name}");
        }
    }
}