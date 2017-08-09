namespace Integration.Tests
{
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class ManagerTests
    {
        private Manager manager;
        private User user;
        private Category category;

        [SetUp]
        public void TestInit()
        {
            user = new User("Pesho");
            category = new Category("News");
            manager = new Manager();
            manager.CreateUser(user);
            manager.CreateCategory(category);
        }

        [Test]
        public void CreateCategoryAddsNewCategoryToTheData()
        {
            Assert.AreEqual(1,manager.Categories.Count,"CreateCategory is not adding new category to the data.");
        }

        [Test]
        public void CreateUserAddsNewUserToTheData()
        {
            Assert.AreEqual(1, manager.Users.Count, "CreateUser is not adding new user to the data.");
        }

        [Test]
        public void RemoveCategoryRemovesCategoryFromTheData()
        {
            manager.RemoveCategory("News");

            Assert.AreEqual(0,manager.Categories.Count,"RemoveCategory is not removing category from the data.");
        }

        [Test]
        public void AddUserToCategoryIsAddingCategoryToUser()
        {
            manager.AddUserToCategory("Pesho","News");

            Assert.IsTrue(this.user.Categories.Contains(category),"AddUserToCategory is not adding the category to the user's categories.");
        }

        [Test]
        public void RemovesCategoryFromUserCategories()
        {
            manager.AddUserToCategory("Pesho","News");
            manager.RemoveCategory("News");

            Assert.IsFalse(manager.Users.Any(x=>x.Categories.Contains(category)),"RemoveCategory is not removing category from user's categories.");
        }
    }
}
