namespace Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private const int DummyHealth = 5;
        private const int DummyExperience = 7;
        private const int AttackPoints = 5;

        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            this.dummy = new Dummy(DummyHealth,DummyExperience);
        }

        [Test]
        public void DummyLosesHealthAfterBeingAttacked()
        {
            this.dummy.TakeAttack(AttackPoints);

            Assert.AreEqual(0, dummy.Health, "Dummy doesn't lose health after being attacked.");
        }

        [Test]
        public void DeadDummyThrowsExceptionAfterBeingAttacked()
        {
            this.dummy.TakeAttack(AttackPoints);

            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(10));
            Assert.AreEqual("Dummy is dead.", exception.Message);
        }

        [Test]
        public void DeadDummyGivesExperience()
        {  
            this.dummy.TakeAttack(AttackPoints);

            Assert.AreEqual(DummyExperience, this.dummy.GiveExperience(), "Dead dummy doesn't give experience.");
        }

        [Test]
        public void AliveDummyDoesntGiveExperience()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience());
            Assert.AreEqual("Target is not dead.", exception.Message);
        }
    }
}
