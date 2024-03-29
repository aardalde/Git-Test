﻿// Aaron Alden
// Dr. Ercison
// CSCI 352
// January 18, 2023
// Guessing_Game.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2
{
    class Guessing_Game
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            bool retry;

            do
            {
                Console.WriteLine("Pick the lower bound of the random number generator: ");
                int lowerBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick the upper bound of the random number generator: ");
                int upperBound = int.Parse(Console.ReadLine());
                int number = rand.Next(lowerBound, upperBound);
                Console.WriteLine("The random number for testing purposes: " + number);
                int numGuesses = 1;

                while (true)
                {
                    Console.WriteLine("Enter your guess: ");
                    int userGuess = int.Parse(Console.ReadLine());

                    if (userGuess < number)
                    {
                        Console.WriteLine("Your guess was too low. Try again.");
                        numGuesses++;
                        continue;
                    }

                    else if (userGuess > number)
                    {
                        Console.WriteLine("Your guess was too high. Try again.");
                        numGuesses++;
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Correct! It took you " + numGuesses + " guess(es) to find the random number.");
                        retry = false;
                        break;
                    }
                    
                }
            }

            while (retry);
            Console.ReadKey();
        }
    }
}