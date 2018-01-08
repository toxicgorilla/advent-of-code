using Xunit;

using Day2.ConsoleApp;

namespace Day2.Tests
{
    public class Part2Tests
    {
        private const string Example = "5\t9\t2\t8\r\n9\t4\t7\t3\r\n3\t8\t6\t5";

        [Theory]
        [InlineData(Example, 9)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = Part2.CalculateAnswer(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
