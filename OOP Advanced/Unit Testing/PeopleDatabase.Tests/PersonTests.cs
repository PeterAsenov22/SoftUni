namespace PeopleDatabase.Tests
{
    using System;
    using Database_Storing_People;
    using NUnit.Framework;

    [TestFixture]
    public class PersonTests
    {
        private Person person;

        [SetUp]
        public void TestInit()
        {
            person = new Person("Pesho",3);
        }

        [Test]
        public void SetsUserNameCorrectly()
        {
            Assert.AreEqual("Pesho",this.person.UserName,"UserName is not set correctly.");
        }

        [Test]
        public void SetsIdCorrectly()
        {
            Assert.AreEqual(3,this.person.Id,"Id is not set correctly.");
        }

        [Test]
        public void CreatingPersonWithIdLessThanOne()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => new Person("Pesho", -2));

            Assert.AreEqual("Cannot create Person with Id less than 1.",exception.Message);
        }

        [Test]
        public void CreatingPersonWithLongId()
        {
            this.person = new Person("Pesho",122342739865);

            Assert.AreEqual(122342739865,this.person.Id,"Cannot create Person with Id of type long.");
        }
    }
}
