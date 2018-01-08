using Xunit;

using Day2.ConsoleApp;

namespace Day2.Tests
{
    public class Part1Tests
    {
        private const string Example = "5\t1\t9\t5\r\n7\t5\t3\r\n2\t4\t6\t8";

        [Theory]
        [InlineData(Example, 18)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = Part1.CalculateAnswer(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
