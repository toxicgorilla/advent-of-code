using Day1Part2.ConsoleApp;
using Xunit;

namespace Day1Part2.Tests
{
    public class CalculateAnswerTests
    {
        [Theory]
        [InlineData("1212", 6)]
        [InlineData("1221", 0)]
        [InlineData("123425", 4)]
        [InlineData("123123", 12)]
        [InlineData("12131415", 4)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = InverseCaptcha.CalculateAnswer(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
