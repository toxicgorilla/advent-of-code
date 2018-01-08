namespace Day1.Util
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
            for (var i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                var nextCharIndex = i + 1;
                if (nextCharIndex == input.Length)
                {
                    nextCharIndex = 0;
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
