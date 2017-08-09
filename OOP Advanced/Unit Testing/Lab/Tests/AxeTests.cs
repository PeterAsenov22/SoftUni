namespace Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 1;
        private const int AxeDurbaility = 1;
        private const int DummyHealth = 20;
        private const int DummyXp = 20;

        private Axe axe;
        private Dummy dummy;

        [SetUp]
        public void TestInit()
        {
            axe = new Axe(AxeAttack,AxeDurbaility);
            dummy = new Dummy(DummyHealth,DummyXp);
        }

        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            axe.Attack(dummy);

            Assert.AreEqual(0,axe.DurabilityPoints,"Axe Durability doesn't change after attack");
        }

        [Test]
        public void AttackingWithBrokenWeapon()
        {
            axe.Attack(dummy);
            
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Axe is broken.",exception.Message);
        }
    }
}
