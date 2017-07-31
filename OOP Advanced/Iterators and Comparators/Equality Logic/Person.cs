namespace Equality_Logic
{
    using System;

    public class Person:IComparable<Person>
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            return this.Age.CompareTo(other.Age);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Person otherPerson = (Person)obj;
            return (this.Name == otherPerson.Name) && (this.Age == otherPerson.Age);
        }

        public override int GetHashCode()
        {
            var nameAscii = 0;
            foreach (var character in this.Name)
            {
                nameAscii += character;
            }

            return this.Name.Length*nameAscii ^ this.Age;
        }
    }
}
