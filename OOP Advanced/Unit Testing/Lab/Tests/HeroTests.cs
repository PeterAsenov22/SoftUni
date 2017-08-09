namespace Tests
{
    using Moq;
    using NUnit.Framework;
    using Skeleton.Interfaces;

    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Pesho";

        [Test]
        public void HeroGetsExperienceAfterKillingTarget()
        {
            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(x => x.Health).Returns(0);
            fakeTarget.Setup(x=>x.IsDead()).Returns(true);
            fakeTarget.Setup(x => x.GiveExperience()).Returns(20);

            Hero hero = new Hero(HeroName,fakeWeapon.Object);
            hero.Attack(fakeTarget.Object);

            Assert.AreEqual(20,hero.Experience,"Hero doesnt get experience.");
        }
    }
}
