using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>(); // List of numbers.
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string answer; // String answer for the recording of numbers. 
        int newNumber; // Integer for converting the answer into a useful number.
        float sum = 0; // Variable for total.
        float average; // Variable for average, must include decimals.
        int maxNumber = 0; // Variable for maximum.

        do // Record every number different from 0. 
        {
            Console.Write("Enter number: ");
            answer = Console.ReadLine();
            newNumber = int.Parse(answer);
            
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            } 
        
        } while (newNumber != 0); // Stop if the number is 0.

        // Summation.
        foreach (int number in numbers) // Go through the list, each and every element of it.
        {    
            sum += number; // Sum the actual number to the total until last one.

        }

        // Average.
        average = sum / numbers.Count;

        // Maximum number.
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        // Print information.
        Console.WriteLine($"The sum is: {sum}"); // Total.
        Console.WriteLine($"The average is: {average:N2}"); // Average.
        Console.WriteLine($"The largest number is: {maxNumber}"); // Maximum.
        
    }
}