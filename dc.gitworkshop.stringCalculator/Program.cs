using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dc.gitworkshop.stringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StringCalculator tests:");
            // for empty input just return 0
            Test(expected: "0", actual: StringCalculator.Compute(""));

            // sum numbers 1 and 2
            Test(expected: "3", actual: StringCalculator.Compute("1,2"));

            // sum numbers 1 and 2 and 3
            Test(expected: "6", actual: StringCalculator.Compute("1,2,3"));

            // allow \n to be a number delimeter
            Test(expected: "3", actual: StringCalculator.Compute("1\n2"));

            // negative numbers are not allowed
            Test(expected: "negatives not allowed", actual: StringCalculator.Compute("-1"));
            Test(expected: "negatives not allowed", actual: StringCalculator.Compute("1,-1"));
            
            // ignore numbers greater than 1000 when summing
            Test(expected: "3", actual: StringCalculator.Compute("1000,1,2"));
            Test(expected: "1003", actual: StringCalculator.Compute("500,1,2,500"));

            // return error on numbers greter than 1500
            Test(expected: "numbers greater than 1500 not allowed", actual: StringCalculator.Compute("2000,1,2"));

            Console.WriteLine();
            Console.WriteLine("Generator tests:");
            Test(expected: 0, actual: Generator.Random(0, ",").Split(new []{','}).Length);
            Test(expected: 1, actual: Generator.Random(1, ",").Split(new []{','}).Length);
            Test(expected: 2, actual: Generator.Random(2, ",").Split(new []{','}).Length);
            Test(expected: 10, actual: Generator.Random(10, ",").Split(new []{','}).Length);
            Test(expected: 10, actual: Generator.Random(10, "\n").Split(new []{'\n'}).Length);
            Test(expected: 10, actual: Generator.Random(10, ",", allowNegatives: true).Split(new []{','}).Length);


            Console.WriteLine();
            Console.WriteLine("Running with generator:");

            Console.WriteLine(StringCalculator.Compute(Generator.Random(10, ",")));
            Console.WriteLine(StringCalculator.Compute(Generator.Random(20, ",")));
            Console.WriteLine(StringCalculator.Compute(Generator.Random(100, ",")));
            Console.WriteLine(StringCalculator.Compute(Generator.Random(200, ",", true)));

            Console.WriteLine("Press [enter] to exit");
            Console.ReadLine();
        }

        private static void Test(string expected, string actual)
        {
            if (expected == actual)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Test did not pass. Expected:{expected} Actual:{actual}");
                Console.ResetColor();
            }
        }

        private static void Test(int expected, int actual)
        {
            Test(expected.ToString(), actual.ToString());
        }
    }
}
