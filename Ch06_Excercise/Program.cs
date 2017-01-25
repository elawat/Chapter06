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
        static void Main(string[] args)
        {
            int number;
            WriteLine("Input a cardinal number");
            number = int.Parse(ReadLine());

            string ordinal = CardinalToOrdinal(number);

            WriteLine(ordinal);

            WriteLine(FactorialLoop(number));
            WriteLine(FactorialRecursion(number));
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

        static int FactorialLoop(int number)
        {

            if (number <= 1)
                return 1;

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;

        }

        static int FactorialRecursion(int number)
        {
            if (number <= 1)
                return 1;

            return number * FactorialRecursion(number - 1);

        }


    }
}
