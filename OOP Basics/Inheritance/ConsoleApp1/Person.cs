namespace ConsoleApp1
{
    using System;

    public class Person
    {
        private string name;
        protected int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }
        private int Age
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}
