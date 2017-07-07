namespace ConsoleApp1
{
    using System;

    public class Child : Person
    {
        private const int MaxAge = 15;

        public Child(string name, int age)
            :base(name,age)
        {
            this.Age = age;
        }

        private int Age
        {
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }

                base.age = value;
            }
        }
    }
}
