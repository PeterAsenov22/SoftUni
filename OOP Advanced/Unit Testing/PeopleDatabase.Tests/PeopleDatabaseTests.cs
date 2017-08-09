namespace PeopleDatabase.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using Database_Storing_People;

    [TestFixture]
    public class PeopleDatabaseTests
    {
        private const int TestNumber = 14;
        private const int Capacity = 16;

        private PeopleDatabase database;

        [SetUp]
        public void TestInit()
        {
            List<Person> initalPeople = new List<Person>()
            {
                new Person("Misho",100),
                new Person("Gosho",200)
            };

            this.database = new PeopleDatabase(initalPeople.ToArray());
        }

        [Test]
        public void InitializingDatabaseWithParameters()
        {
            Assert.AreEqual(2, this.database.Count, "Initializing new database with parameters is not working properly.");
        }

        [Test]
        public void TestDatabaseCapacity()
        {
            Assert.AreEqual(16, this.database.Capacity, "Database doesnt have 16 elements.");
        }

        [Test]
        public void AddsSingleElementToTheDatabase()
        {
            this.database.Add(new Person("Pesho",4));

            Assert.AreEqual(3, this.database.Count, "Add command is not adding Person to the database.");
        }

        [Test]
        public void AddSeveralElementToTheDatabase()
        {
            this.database.Add(new Person("Ivan",5));
            this.database.Add(new Person("Pesho", 4));
            this.database.Add(new Person("Stavri",18));

            Assert.AreEqual(5, this.database.Count, "Adding several elements to the database is not working properly.");
        }

        [Test]
        public void TryingToAddMoreThan16Elements()
        {
            for (int i = 0; i < TestNumber; i++)
            {
                this.database.Add(new Person($"Pesho{i}",i+1));
            }

            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person("Peshooo",340)));

            Assert.AreEqual("Cannot add more people in the database.", exception.Message);
        }

        [Test]
        public void RemovesSingleElementFromTheDatabase()
        {
            this.database.Remove();

            Assert.AreEqual(1, this.database.Count, "Removing Person from the Database is not working properly.");
        }

        [Test]
        public void RemoveSeveralElementsFromTheDatabase()
        {
            this.database.Remove();
            this.database.Remove();

            Assert.AreEqual(0, this.database.Count, "Removing several elements from the database is not working properly.");
        }

        [Test]
        public void TryToRemoveElementFromAnEmptyCollection()
        {
            this.database.Remove();
            this.database.Remove();

            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Remove());

            Assert.AreEqual("Cannot remove Person from empty database!", exception.Message);
        }

        [Test]
        public void InitializeDatabaseWithMoreThan16Persons()
        {
            var list = new List<Person>();
            for (int i = 0; i < Capacity + 1; i++)
            {
                list.Add(new Person($"Pesho{i}",i+1));
            }

            InvalidOperationException exception = 
                Assert.Throws<InvalidOperationException>(() => new PeopleDatabase(list.ToArray()));

            Assert.AreEqual("Cannot add more than 16 persons.",exception.Message);
        }

        [Test]
        public void AddPersonWithTheSameUsername()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person("Misho", 10)));

            Assert.AreEqual("Person with the same UserName or Id has already been registered.",exception.Message);
        }

        [Test]
        public void AddPersonWithTheSameId()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person("Pesho", 100)));

            Assert.AreEqual("Person with the same UserName or Id has already been registered.", exception.Message);
        }

        [Test]
        public void AddingTheSamePersonTwice()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Add(new Person("Misho", 100)));

            Assert.AreEqual("Person with the same UserName or Id has already been registered.", exception.Message);
        }

        [Test]
        public void TryToFindUsernameWithNullParameter()
        {
            Assert.Throws<ArgumentNullException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void TryToFindUsernameWithNonExistingUsername()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("Pesho"));

            Assert.AreEqual("There is not existing Person with this UserName in the database.",exception.Message);
        }

        [Test]
        public void FindingUsername()
        {
            Person person = new Person("Pesho",2);
            this.database.Add(person);

            Person foundedPerson = this.database.FindByUsername("Pesho");

            Assert.AreEqual(person,foundedPerson,"Not returning person.");
        }

        [Test]
        public void TryToFindPersonWithIdLessThanOne()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-2));
        }

        [Test]
        public void TryToFindPersonWithNonExistingId()
        {
            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.FindById(1));

            Assert.AreEqual("There is not existing Person with this Id in the database.", exception.Message);
        }

        [Test]
        public void FindingId()
        {
            Person person = new Person("Pesho", 2);
            this.database.Add(person);

            Person foundedPerson = this.database.FindById(2);

            Assert.AreEqual(person, foundedPerson, "Not returning person.");
        }
    }
}
