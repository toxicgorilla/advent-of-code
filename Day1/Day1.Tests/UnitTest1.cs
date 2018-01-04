namespace Day1.Tests
{
    using Day1.Util;

    using Xunit;

    using XunitShould;

    public class UnitTest1
    {
        [Fact]
        public void With_Input_1122_Answer_Is_3()
        {
            var input = "1122";
            var expected = 3;
            var actual = ReverseCaptcha.CalculateAnswer(input);

            actual.ShouldEqual(expected);
        }

        [Fact]
        public void With_Input_1111_Answer_Is_4()
        {
            var input = "1111";
            var expected = 4;
            var actual = ReverseCaptcha.CalculateAnswer(input);

            actual.ShouldEqual(expected);
        }

        [Fact]
        public void With_Input_1234_Answer_Is_0()
        {
            var input = "1234";
            var expected = 0;
            var actual = ReverseCaptcha.CalculateAnswer(input);

            actual.ShouldEqual(expected);
        }
    }
}
