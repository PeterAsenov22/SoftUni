using System;
using NUnit.Framework;
using Twitter.Interfaces;
using Twitter.Models;

namespace Twitter.Tests
{
    [TestFixture]
    public class TweetTests
    {
        private IMessage message;

        [Test]
        public void TestContestBeingSet()
        {
            message = new Tweet("hello");

            Assert.AreEqual("hello",message.Content,"Content is not being set.");
        }
    }
}
