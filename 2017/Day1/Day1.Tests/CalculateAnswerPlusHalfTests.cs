namespace Day1.Tests
{
    using Day1.Util;

    using Xunit;

    public class CalculateAnswerPlusHalfTests
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
            var actualAnswer = ReverseCaptcha.CalculateAnswerPlusHalf(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
