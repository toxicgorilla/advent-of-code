using Xunit;

using Day2.ConsoleApp;

namespace Day2.Tests
{
    public class ChecksumGeneratorTests
    {
        private const string Example = @"5 1 9 5
7 5 3
2 4 6 8";

        [Theory]
        [InlineData(Example, 18)]
        // ReSharper disable once InconsistentNaming
        public void With_Input_X_Answer_Is_Y(string input, int expectedAnswer)
        {
            var actualAnswer = ChecksumGenerator.Generate(input);

            Assert.Equal(actualAnswer, expectedAnswer);
        }
    }
}
