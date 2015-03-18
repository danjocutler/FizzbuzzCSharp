using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzCSharp
{

    public class Fizzbuzz
    {
        [STAThread]
        static void Main()
        { 
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
    }
}
