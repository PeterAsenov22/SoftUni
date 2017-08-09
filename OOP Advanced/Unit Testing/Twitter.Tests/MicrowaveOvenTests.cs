namespace Twitter.Tests
{
    using NUnit.Framework;
    using Twitter.Models;

    [TestFixture]
    public class MicrowaveOvenTests
    {
        [Test]
        public void TestRetrieveMessage()
        {
            var writer = new ConsoleWriter();
            var message = new Tweet("hi");
            var microwave = new MicrowaveOven(writer);

            microwave.RetrieveMessage(message);
        }
    }
}
