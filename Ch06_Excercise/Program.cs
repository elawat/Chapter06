using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06_Excercise02
{
    class Program
    {
        static int number;

        static void Main(string[] args)
        {
            WriteLine("Input a cardinal number");
            number = int.Parse(ReadLine());

            string ordinal = CardinalToOrdinal(number);

            WriteLine(ordinal);

            WriteLine(FactorialLoop(number));
            WriteLine(FactorialRecursion(number));
            WriteLine(PrimeFactors(number));
        }

        static string CardinalToOrdinal(int cardinal)
        {

            string result;
            string input = cardinal.ToString();


            if (input.EndsWith("1"))
            {
                result = input + "st";
            }
            else if (input.EndsWith("2"))
            {
                result = input + "nd";
            }
            else if (input.EndsWith("3"))
            {
                result = input + "rd";
            }
            else
            {
                result = input + "th";
            }

            return result;
        }

        static long FactorialLoop(int number)
        {

            if (number <= 1)
                return 1;

            long result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;

        }

        static long FactorialRecursion(int number)
        {
            if (number <= 1)
                return 1;

            return number * FactorialRecursion(number - 1);

        }


        static string PrimeFactors(int n)
        {

            if (n == 1) return ""; //The number 1 is called a unit. It has no prime factors and is neither prime nor composite.
            if (isPrime(n)) return $"{n}";
            bool isEqual = n % 2 == 0;

            int m;
            int i;
            string factors;

           
                i = 2;
                m = n / i;
                factors ="";
                if (isEqual) factors = ""+i;
                while (isPrime(m)==false)
                {
                    for (int j =2; m%i != 0; j++) //look for devider
                    {
                        i = j;
                    }
                    m = m / i;
                    factors = factors + i + "x";
                }
                factors = factors + "x" + m;
                return factors;
         
      
        }

        static bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            if (number % 2 == 0) return false; //Even number     

            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;

        }


    }
}
