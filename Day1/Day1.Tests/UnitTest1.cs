namespace Day1.Tests
{
    using Day1.Util;

    using Xunit;

    public class UnitTest1
    {
        [Theory]
        [InlineData("1122", 3)]
        [InlineData("1111", 4)]
        [InlineData("1234", 0)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = ReverseCaptcha.CalculateAnswer(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
