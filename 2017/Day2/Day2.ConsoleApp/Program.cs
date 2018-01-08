using System;

namespace Day2.ConsoleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid parameters");

                return 1;
            }

            var input = args[0];
            var answer = Part2.CalculateAnswer(input);

            Console.WriteLine($"Answer is: {answer}");
            Console.ReadLine();

            return 0;
        }
    }
}
