using System;

class Fraction
{
    private int _topNumber; // Every fraction need a numerator.
    private int _bottomNumber; // And a denominator.

    // Note: There are 3 types of fractions:
    // > "Empty" fractions. They are fractions of 1/1.
    // > Whole numbers. They are fractions as X/1.
    // > "Common" fractions. They are fraction as X/Y with X and Y being different items.

    public Fraction() // "Empty" fraction. 
    {
        _topNumber = 1;
        _bottomNumber = 1; // Both numbers are 1.
    }

    public Fraction(int wholeNumber) // Whole number fraction.
    {
        _topNumber = wholeNumber; // It accepts a number as the numerator.
        _bottomNumber = 1; // Saves 1 as a denominator.
    }

    public Fraction(int topNumber, int bottomNumber) // "Common" Fraction.
    {
        _topNumber = topNumber; // It accepts a number as the numerator.
        _bottomNumber = bottomNumber; // It accepts a number as the denominator.
    }

    // Note: Getters and Setter for attributes:
    // > Get: Extract the value of the attribute.
    // > Set: Change the value of attribute.

    // Numerator:
    // > Getter.
    // > Setter.

    public int GetTopNumber() // Getter.
    {
        return _topNumber;
    }

    public void SetTopNumber( int topNumber) // Setter.
    {
        _topNumber = topNumber;
    }

    // Denominator:
    // > Getter.
    // > Setter.

    public int GetBottomNumber() // Getter.
    {
        return _bottomNumber;
    }

    public void SetBottomNumber(int bottomNumber) // Setter.
    {
        _bottomNumber = bottomNumber;
    }

    // Note: Methods: Ways of handling and using the info contained in the class.
    // > Organize the fraction as X/Y for display.
    // > Make the math and return a result.

    public string GetFractionString() // Get a string in a specific format.
    {
        string fraction = $"{_topNumber}/{_bottomNumber}"; // Formatting the sting.

        return fraction; // Returning the string.
    }

    public double GetDecimalValue() // Make the math between the numerator and denominator.
    {
        double fraction = (double)_topNumber / (double)_bottomNumber; // Both numbers are int, they need to have a lot of decimal, so they get converted into doubles.

        return fraction; // Returning a result of the math. This is also a double.
    }

}