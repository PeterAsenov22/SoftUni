namespace Integration.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class User_Tests
    {
        private User user;

        [SetUp]
        public void TestInit()
        {
            user = new User("Pesho");
        }

        [Test]
        public void ConstructorSetsName()
        {
            Assert.AreEqual("Pesho",user.Name,"Constructor is not setting name correctly.");
        }

        [Test]
        public void ConstructorInitializesNewListOfCategories()
        {
            Assert.AreEqual(0,this.user.Categories.Count,"Constructor is not initializing new List<Category>.");
        }
    }
}
