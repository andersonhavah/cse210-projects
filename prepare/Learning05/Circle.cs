using System;

namespace learning05
{
    public class Circle : Shape
    {
        // This is the member variable of the class
        private double _radius;

        // This the constructor of the class
        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
            SetColor(color);
        }

        // This method helps get the area of the circle
        public override double GetArea()
        {
            return Math.Pow(_radius, 2) * Math.PI;
        }
    }
}