using System;
using System.Drawing;
using System.Threading.Channels;

namespace learning05
{
    public class Square : Shape
    {
        // This is the member variable of the Square class
        private double _side;

        // This is the constructor of the class
        public Square(string color, double side) : base(color)
        {
            _side = side;
            SetColor(color);
        }

        // This method helps get the are of the square
        public override double GetArea()
        {
            return Math.Pow(_side, 2);
        }
    }
}