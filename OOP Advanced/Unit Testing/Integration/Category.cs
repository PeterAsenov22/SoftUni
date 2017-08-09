namespace Integration
{
    using System.Collections.Generic;

    public class Category
    {
        public Category(string name)
        {
            this.Name = name;
            this.Users = new HashSet<User>();
        }

        public string Name { get; private set; }

        public HashSet<User> Users { get; set; }

        public void AddUser(User user)
        {
            this.Users.Add(user);
        }
    }
}
