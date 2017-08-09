namespace Integration.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private Category category;

        [SetUp]
        public void TestInit()
        {
            category = new Category("News");
        }

        [Test]
        public void CategoryConstructorSetsName()
        {
            Assert.AreEqual("News",category.Name,"Constructor is not setting name correctly.");
        }

        [Test]
        public void ConstructorInitializesNewHashSet()
        {
            Assert.AreEqual(0,category.Users.Count,"Constructor is not initializing new HashSet.");
        }

        [Test]
        public void AddingUser()
        {
            User user = new User("Pesho");
            category.AddUser(user);

            Assert.AreEqual(1,category.Users.Count);
        }
    }
}
