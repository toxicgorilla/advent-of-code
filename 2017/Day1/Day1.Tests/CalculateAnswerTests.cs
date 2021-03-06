using Day1.ConsoleApp;

namespace Day1.Tests
{
    using Xunit;

    public class CalculateAnswerTests
    {
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = InverseCaptcha.CalculateAnswer(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
