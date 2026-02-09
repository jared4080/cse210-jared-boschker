using System;


namespace Leanring05
{
    public abstract class Shape
    {
        string _color = "blue";


        public Shape(string color)
        {
            _color = color;
        }        

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        public abstract double GetArea();
    }
}