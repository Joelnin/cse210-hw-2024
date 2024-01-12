using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction(); // Testing 1/1 type of fraction.
        Fraction fraction2 = new Fraction(5); // Testing whole number.
        Fraction fraction3 = new Fraction(3, 4); // Testing normal fraction 01.
        Fraction fraction4 = new Fraction(1, 3); // Testing normal fraction 02.

        // Console.WriteLine(fraction1.GetTopNumber()); // Testing Getter for the top number 01.
        // Console.WriteLine(fraction2.GetBottomNumber()); // Testing Getter for the bottom number 01.
        // Console.WriteLine(fraction3.GetBottomNumber()); // Testing Getter for the bottom number 02.
        // Console.WriteLine(""); // Line for aesthetic.

        // fraction1.SetTopNumber(4); // Testing Setter for the top number.
        // fraction2.SetBottomNumber(8); // Testing Setter for the bottom number 01.
        // fraction3.SetBottomNumber(9); // Testing Setter for the bottom number 02.

        // Console.WriteLine(fraction1.GetTopNumber()); // Testing Getter for the top number 02.
        // Console.WriteLine(fraction2.GetBottomNumber()); // Testing Getter for the bottom number 03.
        // Console.WriteLine(fraction3.GetBottomNumber()); // Testing Getter for the bottom number 04.

        Console.WriteLine(fraction1.GetFractionString()); // Display fraction1 as X/Y.
        Console.WriteLine(fraction1.GetDecimalValue()); // Display fraction1 as a number.

        Console.WriteLine(fraction2.GetFractionString()); // Display fraction2 as X/Y.
        Console.WriteLine(fraction2.GetDecimalValue()); // Display fraction2 as a number.

        Console.WriteLine(fraction3.GetFractionString()); // Display fraction3 as X/Y.
        Console.WriteLine(fraction3.GetDecimalValue()); // Display fraction3 as a number.

        Console.WriteLine(fraction4.GetFractionString()); // Display fraction4 as X/Y.
        Console.WriteLine(fraction4.GetDecimalValue()); // Display fraction4 as a number.

    }
}