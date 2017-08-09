namespace Database.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private const int TestNumber = 6;
        
        private Database database;
        private List<int> testList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7};

        [SetUp]
        public void TestInit()
        {
            this.database = new Database(testList.ToArray());
        }

        [Test]
        public void InitializingDatabaseWithParameters()
        {
            Assert.AreEqual(15, this.database.Count, "Initializing new database with parameters is not working properly.");
        }

        [Test]
        public void TestDatabaseCapacity()
        {
            this.database = new Database();

            Assert.AreEqual(16,this.database.Capacity,"Database doesnt have 16 elements.");
        }

        [Test]
        public void AddsSingleElementToTheDatabase()
        {
            this.database.Add(TestNumber);

            Assert.AreEqual(16,this.database.Count,"Add command is not adding an element to the database.");
        }

        [Test]
        public void AddSeveralElementToTheDatabase()
        {
            this.database = new Database();

            for (int i = 0; i < TestNumber; i++)
            {
                this.database.Add(i);
            }

            Assert.AreEqual(6,this.database.Count,"Adding several elements to the database is not working properly.");
        }

        [Test]
        public void TryingToAddMoreThan16Elements()
        {
            this.database.Add(TestNumber);

            InvalidOperationException exception = 
            Assert.Throws<InvalidOperationException>(() => this.database.Add(TestNumber));

            Assert.AreEqual("Cannot add more elements in the collection.",exception.Message);
        }

        [Test]
        public void RemovesSingleElementFromTheDatabase()
        {
            this.database.Remove();

            Assert.AreEqual(14,this.database.Count,"Removing element from the Database is not working properly.");
        }

        [Test]
        public void RemoveSeveralElementsFromTheDatabase()
        {
            for (int i = 0; i < TestNumber; i++)
            {
                this.database.Remove();
            }

            Assert.AreEqual(9,this.database.Count, "Removing several elements from the database is not working properly.");
        }

        [Test]
        public void TryToRemoveElementFromAnEmptyCollection()
        {
            this.database = new Database();

            InvalidOperationException exception =
                Assert.Throws<InvalidOperationException>(() => this.database.Remove());

            Assert.AreEqual("Cannot remove element from empty database!",exception.Message);
        }

        [Test]
        public void FetchWorkingProperly()
        {
            var databasse = this.database.Fetch();

            Assert.AreEqual(databasse,this.testList.ToArray(),"Fetch is not returning an array.");
        }

        [Test]
        public void SetElementsWhenAdding()
        {
            this.database = new Database(1,2,3,4,5);

            for (int i = 0; i < TestNumber; i++)
            {
                this.database.Add(i);
            }

            Assert.AreEqual(new int[]{1,2,3,4,5,0,1,2,3,4,5},this.database.Fetch(),"Set elements to the data base is not working properly.");
        }

        [Test]
        public void RemoveElementsFromTheEndToTheStart()
        {
            for (int i = 0; i < TestNumber; i++)
            {
                this.database.Remove();
            }

            Assert.AreEqual(new int[]{1,2,3,4,5,6,7,8,1},this.database.Fetch(),"Database is not removing elements properly.");
        }
    }
}
