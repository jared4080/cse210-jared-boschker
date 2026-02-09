using System;
using System.Drawing;


namespace Leanring05
{
    public class Rectangle : Shape
    {
        double _length = 2.0;
        double _width = 3.5;


        public Rectangle(string color, double length, double width) : base(color)
        {
            _length = length;
            _width = width;
        }


        public override double GetArea()
        {
            return _length * _width;
        }
    }
}