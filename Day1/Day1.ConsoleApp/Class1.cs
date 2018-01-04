namespace Day1.ConsoleApp
{
    using System;

    using Day1.Util;

    public class Class1
    {
        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid parameters");

                return 1;
            }

            var input = args[0];
            var answer = ReverseCaptcha.CalculateAnswer(input);

            Console.WriteLine($"Answer is: {answer}");
            Console.ReadLine();

            return 0;
        }
    }
}
