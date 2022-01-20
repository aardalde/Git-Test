// Name: Aaron Alden
// Date: 1/20/22
// File: Program.cs
/* Description: A number guessing game that prompts the user to correctly guess the number
//that was generated. Records the number of attempts and tells the user if they are too
high or too low. 
*/

using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class CW2__Getting_into_Git
    {
        static void Main(string[] args)
        {
            CW2__Getting_into_Git g = new CW2__Getting_into_Git();
            g.TheGuessingGame();
            Console.ReadKey(); 
        }
        void TheGuessingGame()
        {
            int x, y;
            Console.WriteLine("Enter a lower bound for your random number range: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an upper bound for your random number range: ");
            y = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int number = rand.Next(x, y);
            Console.WriteLine("Guess the number now:");
            int numGuess;
            int Attempts = 0;
            do
            {
                numGuess = Convert.ToInt32(Console.ReadLine());
                if (numGuess < number)
                {
                    Console.WriteLine(numGuess + " is too low!");
                    Attempts++;
                    Console.WriteLine("Guess again: ");
                }
                else if (numGuess > number)
                {
                    Console.WriteLine(numGuess + " is too high!");
                    Attempts++;
                    Console.WriteLine("Guess again: ");
                }
            } while (numGuess != number);
            Console.WriteLine("Correct! " + numGuess + " is the right guess. It took " + 
                "you " + Attempts + " to guess the right number.");
        }
    }
}