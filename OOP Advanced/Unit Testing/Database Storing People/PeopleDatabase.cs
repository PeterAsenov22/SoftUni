namespace Database_Storing_People
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PeopleDatabase
    {
        private const int DefaultCapacity = 16;
        private List<Person> collection;

        public PeopleDatabase(params Person[] elements)
        {
            if (elements.Length > 16)
            {
                throw new InvalidOperationException("Cannot add more than 16 persons.");
            }

            this.collection = new List<Person>(DefaultCapacity);

            for (int i = 0; i < elements.Length; i++)
            {
                this.Add(elements[i]);
            }
        }

        public int Count => this.collection.Count;

        public int Capacity => this.collection.Capacity;

        public void Add(Person person)
        {
            if (this.collection.Count == 16)
            {
                throw new InvalidOperationException("Cannot add more people in the database.");
            }

            if (this.collection.Any(x => x.UserName == person.UserName) || this.collection.Any(x => x.Id == person.Id))
            {
                throw new InvalidOperationException("Person with the same UserName or Id has already been registered.");
            }

            this.collection.Add(person);
        }

        public void Remove()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove Person from empty database!");
            }

            this.collection.RemoveAt(this.collection.Count - 1);
        }

        public Person FindByUsername(string userName)
        {
            if (userName == null)
            {
                throw new ArgumentNullException();
            }

            if (this.collection.All(x => x.UserName != userName))
            {
                throw new InvalidOperationException("There is not existing Person with this UserName in the database.");
            }

            return this.collection.First(x => x.UserName == userName);
        }

        public Person FindById(long id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.collection.All(x => x.Id != id))
            {
                throw new InvalidOperationException("There is not existing Person with this Id in the database.");
            }

            return this.collection.First(x => x.Id == id);
        }
    }
}
