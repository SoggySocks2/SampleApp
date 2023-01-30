using FluentAssertions;
using SampleApp.Library;

namespace SampleApp.Tests.Unit_Tests
{
    public class MessagesTests
    {
        [Fact]
        public void HelloMessage_ShouldReturn_Hello()
        {
            var msg = new Messages().Hello;
            msg.Should().Be("Hello There");
        }
    }
}
