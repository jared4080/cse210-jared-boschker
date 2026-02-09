using System;
using System.Runtime.InteropServices;


namespace Leanring05
{
    public class Circle : Shape
    {
        double _radius = 5.0;


        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}