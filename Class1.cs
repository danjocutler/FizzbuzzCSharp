using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NUnit.Framework;

namespace FizzBuzzCSharp
{

    public class Fizzbuzz
    {
        [STAThread]
        static void Main()
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
            for (int i = 1; i < 101; i++)
            {
                this.Plays(i);
            }
        }
    }
}   
