namespace Day1.Util
{
    public class ReverseCaptcha
    {
        public static int CalculateAnswer(string input)
        {
            // Sanity check
            if (string.IsNullOrWhiteSpace(input) || input.Length < 2)
            {
                return 0;
            }

            var total = 0;
            for (var i = 0; i < input.Length; i++)
            {
                char currentChar;
                char nextChar;

                if (i < input.Length - 1)
                {
                    currentChar = input[i];
                    nextChar = input[i + 1];
                }
                else
                {     // final char
                    currentChar = input[input.Length - 1];

                    // first char
                    nextChar = input[0];
                }

                if (currentChar == nextChar)
                {
                    total += int.Parse(currentChar.ToString());
                }
            }

            return total;
        }

        public static int CalculateAnswerPlusHalf(string input)
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
