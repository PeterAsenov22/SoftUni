namespace CustomLinkedList.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private DynamicList<string> dynList;

        [SetUp]
        public void TestInit()
        {
            dynList = new DynamicList<string>();
        }

        [Test]
        public void TestConstructorSetsCountAtZero()
        {
            Assert.AreEqual(0,this.dynList.Count,"Count is not zero after initializing new DynamicList.");
        }

        [Test]
        public void TestAddMethodShouldIncreaseCount()
        {
            dynList.Add("hello");

            Assert.AreEqual(1,this.dynList.Count,"Add method is not increasing count.");
        }

        [Test]
        public void TestIndexReturnsCorrectElement()
        {
            dynList.Add("Ivan");

            Assert.AreEqual("Ivan",dynList[0],"Index is not returning correct element.");
        }

        [Test]
        [TestCase(2)]
        [TestCase(-2)]
        public void TestIndexShouldThrowException(int index)
        {
            dynList.Add("Petar");

            ArgumentException exception =
                Assert.Throws<ArgumentException>(() => dynList[index].Equals("Petar"));

            Assert.AreEqual($"Invalid index: {index}",exception.Message);
        }

        [Test]
        public void TestIndexSetsElement()
        {
            dynList.Add("Stavri");
            dynList.Add("Krasimir");

            dynList[0] = "Petar";
            dynList[1] = "Ivan";

            Assert.AreEqual("Petar",dynList[0],"Index doesn't set element.");
            Assert.AreEqual("Ivan", dynList[1], "Index doesn't set element.");
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        public void TestIndexSetsElementShouldThrowException(int index)
        {
            ArgumentException exception =
            Assert.Throws<ArgumentException>(() => dynList[index] = "Gosho");

            Assert.AreEqual($"Invalid index: {index}",exception.Message);
        }

        [Test]
        public void TestAddMethodAddsElementAtTheEndOfTheCollection()
        {
            var list = new List<string>(){"Ivan","Georgi"};
            dynList.Add("Ivan");
            dynList.Add("Georgi");

            Assert.AreEqual("Georgi",dynList[1],"Add method is not adding element at the end of the collection.");
        }

        [Test]
        public void TestRemoveAtRemovesAndReturnsCorrectElement()
        {
            this.dynList.Add("Petar");
            this.dynList.Add("Ivan");

            string removed = this.dynList.RemoveAt(1);

            Assert.AreEqual(1,this.dynList.Count,"RemoveAt doesn't decrease count.");
            Assert.AreEqual("Ivan",removed,"RemoveAt doesn't return correct element.");
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-2)]
        public void TestRemoveAtShouldThrowException(int index)
        {
            ArgumentException exception =
                Assert.Throws<ArgumentException>(() => this.dynList.RemoveAt(index));

            Assert.AreEqual($"Invalid index: {index}",exception.Message);
        }

        [Test]
        public void TestRemoveReturnsCorrectIndex()
        {
            this.dynList.Add("Petar");
            this.dynList.Add("Georgi");

            int removedIndex = this.dynList.Remove("Georgi");

            Assert.AreEqual(1,removedIndex,"Remove doesn't return correct index.");
        }

        [Test]
        public void TestRemoveDecreasesCount()
        {
            this.dynList.Add("Petar");
            this.dynList.Add("Georgi");

            this.dynList.Remove("Georgi");

            Assert.AreEqual(1, this.dynList.Count, "Remove doesn't decrease count.");
        }

        [Test]
        [TestCase("Georgi")]
        [TestCase("Stamen")]
        [TestCase(null)]
        public void TestRemoveShouldReturnMinusOne(string name)
        {
            this.dynList.Add("Petar");

            int returned = this.dynList.Remove(name);

            Assert.AreEqual(-1,returned,"Remove doesn't return -1 when collection doesn't contain element.");
        }

        [Test]
        public void TestIndexOfReturnsCorrectIndex()
        {
            this.dynList.Add("Petar");
            this.dynList.Add("Georgi");
            this.dynList.Add("Ivan");

            Assert.AreEqual(2,this.dynList.IndexOf("Ivan"),"IndexOf doesn't return correct index.");
        }

        [Test]
        [TestCase("Georgi")]
        [TestCase(null)]
        public void TestIndexOfShouldReturnMinusOne(string name)
        {
            this.dynList.Add("Pesho");

            Assert.AreEqual(-1,this.dynList.IndexOf(name),"IndexOf doesn't return -1 when collection doesn't contain element.");
        }

        [Test]
        public void TestContainsShouldReturnTrue()
        {
            this.dynList.Add("Petar");

            Assert.IsTrue(this.dynList.Contains("Petar"));
        }

        [Test]
        public void TestContainsShouldReturnFalse()
        {
            this.dynList.Add("Petar");

            Assert.IsFalse(this.dynList.Contains("Ivan"));
        }
    }
}
