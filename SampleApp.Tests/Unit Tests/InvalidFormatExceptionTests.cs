namespace SampleApp.Tests.Unit_Tests
{
    public class InvalidFormatExceptionTests
    {
        [Fact]
        public void InvalidFormatException_ShouldHave_CorrectMessage()
        {
            var ex = new InvalidFormatException();
            ex.Should().BeOfType<InvalidFormatException>();
            ex.Message.Should().Be("String was in an invalid format");
        }
    }
}