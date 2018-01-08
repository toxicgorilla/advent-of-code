namespace Day1Part2.ConsoleApp
{
    public class InverseCaptcha
    {
        public static int CalculateAnswer(string input)
        {
            // Sanity check
            if (string.IsNullOrWhiteSpace(input) || input.Length < 2)
            {
                return 0;
            }

            var total = 0;
            var advance = input.Length / 2;
            for (var i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];

                var nextCharIndex = i + advance;
                if (nextCharIndex >= input.Length)
                {
                    nextCharIndex -= input.Length;
                }

                var nextChar = input[nextCharIndex];

                if (currentChar == nextChar)
                {
                    total += int.Parse(currentChar.ToString());
                }
            }

            return total;
        }
    }
}
