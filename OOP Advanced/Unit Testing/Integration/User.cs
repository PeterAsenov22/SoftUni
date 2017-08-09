namespace Integration
{
    using System.Collections.Generic;

    public class User
    {
        public User(string name)
        {
            this.Name = name;
            this.Categories = new List<Category>();
        }

        public string Name { get; private set; }

        public List<Category> Categories { get; private set; }
    }
}
