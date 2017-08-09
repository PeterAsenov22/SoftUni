namespace ListyIterator.Tests
{
    using System;
    using Iterator_Tests;
    using NUnit.Framework;

    [TestFixture]
    public class TestClass
    {
        private string[] collection;
        private ListyIterator<string> iterator;
        [SetUp]
        public void TestInit()
        {
           collection = new string[] { "pesho", "gosho", "ivan","petkan","stavri"};
           iterator = new ListyIterator<string>(collection);
        }

        [Test]
        public void CountIsWorkingWhenCreatingIterator()
        {
            Assert.AreEqual(5,iterator.Count,"Count method is not working properly.");
        }

        [Test]
        public void ConstructorSetsElementsWhenCreatingNewIterator()
        {
            CollectionAssert.AreEqual(collection,iterator,"Elements are not being set when creating new iterartor.");
        }

        [Test]
        public void CreatingIteratorWithoutParametersShouldReturnCountEqualToZero()
        {
            iterator = new ListyIterator<string>();
            Assert.AreEqual(0,iterator.Count,"Creating iterator without parameters is not returning zero count.");
        }

        [Test]
        public void CurrentIndexShouldBeZeroWhenCreatingNewIterator()
        {
            Assert.AreEqual(0,iterator.CurrentIndex,"Current index is not zero at the beginning.");
        }

        [Test]
        public void HasNextShouldReturnTrue()
        {
            Assert.IsTrue(iterator.HasNext(),"HasNext is not working properly.");
        }

        [Test]
        public void HasNextShouldReturnFalseWhenThereIsNotNextElement()
        {
            iterator = new ListyIterator<string>();

            Assert.IsFalse(iterator.HasNext(), "HasNext is not working properly.");
        }

        [Test]
        public void MoveCommandShouldReturnTrue()
        {
            Assert.IsTrue(iterator.Move(), "Move command is not working properly.");
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void MoveCommandShouldIncreaseCurrentIndex(int count)
        {
            for (int i = 0; i < count; i++)
            {
                iterator.Move();
            }
            
            Assert.AreEqual(count,iterator.CurrentIndex, "Move command is not increasing current index.");
        }

        [Test]
        [TestCase(4)]
        public void MoveCommandShouldReturnFalse(int count)
        {
            for (int i = 0; i < count; i++)
            {
                iterator.Move();
            }

            Assert.IsFalse(iterator.Move(), "Move command is not working properly.");
        }

        [Test]
        public void PrintCommandShouldThrowException()
        {
            iterator = new ListyIterator<string>();

            ArgumentException exception =
                Assert.Throws<ArgumentException>(() => iterator.Print());

            Assert.AreEqual("Invalid Operation!", exception.Message);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void PrintCommandShouldPrintElement(int count)
        {
            for (int i = 0; i < count; i++)
            {
                iterator.Move();
            }

            Assert.AreEqual(collection[count],iterator.Print(),"Print command is not printing correctly.");
        }

        [Test]
        public void PrintAllShouldPrintAllElementsDividedBySingleSpace()
        {
            Assert.AreEqual(string.Join(" ",collection),iterator.PrintAll(),"Print All is not printing all elements correctly.");
        }
    }
}
