using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FizzBuzzCSharp
{

    public class Fizzbuzz
    {
        static void Main(string[] args)
        {
            new Fizzbuzz().Game();
        }

        public bool DivisibleByThree(int number)
        {
            if (number % 3 == 0)
                return true;
            else
                return false;
        }

        public bool DivisibleByFive(int number)
        {
            if (number % 5 == 0)
                return true;
            else
                return false;
        }

        public bool DivisibleByThreeAndFive(int number)
        {
            if (number % 15 == 0)
                return true;
            else
                return false;
        }

        public void Plays(int number)
        {
            if (DivisibleByThreeAndFive(number))
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (DivisibleByThree(number))
            {
                Console.WriteLine("Fizz");
            }
            else if (DivisibleByFive(number))
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        public void Game()
        {
            var game = new Fizzbuzz();

            for (int i = 1; i < 101; i++)
            {
                game.Plays(i);
                Thread.Sleep(250);
            }
        }
    }
}   
