namespace Comparing_Objects
{
    using System;

    public class Person:IComparable<Person>
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Town { get; private set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public int CompareTo(Person other)
        {
            var nameCompare = this.Name.CompareTo(other.Name);
            if (nameCompare != 0)
            {
                return nameCompare;
            }

            var ageCompare = this.Age.CompareTo(other.Age);
            if (ageCompare != 0)
            {
                return ageCompare;
            }

            return this.Town.CompareTo(other.Town);
        }
    }
}
