namespace Day1.ConsoleApp
{
    using System;

    public class Program
    {
        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Invalid parameters");

                return 1;
            }

            var input = args[0];
            var answer = InverseCaptcha.CalculateAnswer(input);

            Console.WriteLine($"Answer is: {answer}");
            Console.ReadLine();

            return 0;
        }
    }
}
