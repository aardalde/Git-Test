using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class CW2__Getting_into_Git
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user, I am thinking of a number between 0 and 100");
            CW2__Getting_into_Git g = new CW2__Getting_into_Git();
            g.TheGuessingGame();
            Console.ReadKey(); 
        }
        void TheGuessingGame()
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine(number);
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