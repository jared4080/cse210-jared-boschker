using System;


namespace Leanring05
{
    public class Square : Shape
    {
        double _side = 5.0;


        public Square(string color, double side) : base(color)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return _side * _side;
        }
    }
}