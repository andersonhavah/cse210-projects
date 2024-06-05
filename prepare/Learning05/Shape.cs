using System;

namespace learning05
{
    public class Shape
    {
        // This is the attribute or member variable of the Shape class
        private string _color;

        // This is the constructor of the class
        public Shape (String color)
        {
            _color = color;
        }

        // Below are the getter and setter for the attribute of this class
        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // This is virtual method
        public virtual double GetArea()
        {
            return 0;
        }


    }
}