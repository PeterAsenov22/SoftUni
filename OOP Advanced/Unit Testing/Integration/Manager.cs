namespace Integration
{
    using System.Collections.Generic;
    using System.Linq;

    public class Manager
    {
        private List<Category> categories;

        private List<User> users;

        public Manager()
        {
            this.categories = new List<Category>();
            this.users = new List<User>();
        }

        public List<Category> Categories => this.categories;

        public List<User> Users => this.users;

        public void CreateCategory(Category category)
        {
            this.categories.Add(category);
        }

        public void CreateUser(User user)
        {
            this.users.Add(user);
        }

        public void RemoveCategory(string name)
        {
            Category category = categories.First(x => x.Name == name);
            categories.Remove(category);

            foreach (var user in users)
            {
                if (user.Categories.Contains(category))
                {
                    user.Categories.Remove(category);
                }
            }
        }

        public void AddUserToCategory(string userName, string categoryName)
        {
            Category category = this.categories.First(x => x.Name == categoryName);
            User user = this.users.First(x => x.Name == userName);
            category.AddUser(user);
            user.Categories.Add(category);
        }
    }
}
