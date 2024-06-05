using System;

namespace learning05
{
    public class Rectangle : Shape
    {
        // Below are the member variables
        private double _length;
        private double _width;

        // This is the constructor with three parameters
        public Rectangle( string color, double length, double width) : base(color)
        {
            _length = length;
            _width = width;
            SetColor(color);
        }

        // This method helps get the area of the rectangle
        public override double GetArea()
        {
            return _length * _width;
        }
    }
}