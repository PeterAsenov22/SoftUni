namespace Twitter.Tests
{
    using NUnit.Framework;
    using Interfaces;
    using Models;

    [TestFixture]
    public class ConsoleWriterTests
    {
        private IWriter writer;

        [SetUp]
        public void TestInit()
        {
            writer = new ConsoleWriter();
        }

        [Test]
        public void TestWrite()
        {
            writer.Write("hello");
        }

        [Test]
        public void TestWriteLine()
        {
            writer.WriteLine("hello");
        }
    }
}
