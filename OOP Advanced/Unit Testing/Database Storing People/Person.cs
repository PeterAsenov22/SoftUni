namespace Database_Storing_People
{
    using System;

    public class Person
    {
        private long id;

        public Person(string userName, long id)
        {
            this.UserName = userName;
            this.Id = id;
        }

        public string UserName { get; private set; }

        public long Id
        {
            get { return this.id; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidOperationException("Cannot create Person with Id less than 1.");
                }

                this.id = value;
            }
        }
    }
}
