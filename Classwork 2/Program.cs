using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_2
{
    class Program
    {
        /* private int steve;
        public void setSteve(int s)
        {
            steve = s;
        }
        public int getSteve()
        {
            return steve;
        } */
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello, world!" + 5);
            Console.ReadKey();
            Console.WriteLine("Setting Steve to 4");
            Program p = new Program();
            p.setSteve(4);
            Console.WriteLine("Steve is: " + p.getSteve());
            Console.ReadKey(); */

            Console.WriteLine("I am thinking of a number between 0 and 100...");
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine(number);
            Console.WriteLine("Enter your guess: ");
            int userGuess = Convert.ToInt32(Console.ReadLine());
            while(userGuess != number)
            {
                int numGuesses = 0;
                if(userGuess < number)
                {
                    Console.WriteLine("Your guess was too low");
                    numGuesses++;
                }
                if (userGuess > number)
                {
                    Console.WriteLine("Your guess was too high");
                    numGuesses++;
                }
                Console.WriteLine("Enter your guess: ");
                else
                {
                    //
                }
            }
       

            Console.ReadKey();
        }
    }
}
