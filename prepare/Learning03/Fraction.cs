public class Fraction
{
    // Declare the Fraction class member variables
    private int _top;
    private int _bottom;

    // Create the constructors of the Fraction class 
    public Fraction() // Constructor with no parameters
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Create getters and setters for each member variable
    // This method gets the value of the member variable _top
    public int GetTop()
    {
        return _top;
    }

    // This method sets the value of the member variable _top
    public void SetTop(int top) // To set top
    {
        _top = top;
    }

    // This method gets the value of the member variable _bottom
    public int GetBottom()
    {
        return _bottom;
    }

    // This method sets the value of the member variable _bottom
    public void setBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Create a method that returns the fraction in the form of a/b
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    // Create a method that returns a double 
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }




}