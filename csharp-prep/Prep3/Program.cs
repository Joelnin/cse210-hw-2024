using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? "); // Ask for a number to guess.
        // string userNumber = Console.ReadLine(); // Save the number in a variable: userNumber.
        // int magicNumber = int.Parse(userNumber); // Save the number as an integer: magicNumber.
        
        Random randomGenerador = new Random(); // Creating the magic number source.
        int magicNumber = randomGenerador.Next(1,101); // Generating random number between 1 and 100.
        // Console.WriteLine(magicNumber); // Verifying if the code works printing magic number.
                
        int guess;

        do // Do the asking at least one time.
        {
            Console.Write("What is your guess? "); // Ask for a guess.
            string userGuess = Console.ReadLine(); // Save the number in a variable: userGuess.
            guess = int.Parse(userGuess); // Save the number as an integer: guess.

            if (guess < magicNumber) // If the guess is lower than the magic number, print "Higher".
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magicNumber) // If the guess is higher than the magic number, print "Lower".
            {
                Console.WriteLine("Lower");
            }

            else // If the guess is right, print "You guessed it!".
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber); // Repeat everything until the user guesses. 

    }
}