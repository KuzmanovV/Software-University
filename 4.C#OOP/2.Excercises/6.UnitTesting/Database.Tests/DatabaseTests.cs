using System;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }

        [Test]
        public void CtorAddsElementsToDatabase()
        {
            int[] arr = Enumerable.Range(1, 16).ToArray();
            
            database = new Database(arr);

            Assert.That(database.Count, Is.EqualTo(arr.Length));
            Assert.That(database.Fetch(), Is.EquivalentTo(arr));
        }

        [Test]
        public void CtorThrowsException_WhenCapacityExceeded()
        {
            Assert.Throws<InvalidOperationException>(() => database=new Database(Enumerable.Range(1,17).ToArray()));
        }

        [Test]
        public void AddThrowsExceptionWhenAddedMoreThan16Elements()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void AddIncreasesDatabaseCount_WhenAddIsValidOperation()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                database.Add(123);
            }

            Assert.That(database.Count,Is.EqualTo(n));
        }
        
        [Test]
        public void AddAddsElementToDatabase()
        {
            int element = 123;
            database.Add(element);

            int[] elements = database.Fetch();

            Assert.IsTrue(elements.Contains(element));
        }

        [Test]
        public void RemoveThrowsExceptionWhenDatabaseEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void RemoveDecreasesDatabaseCount()
        {
            database.Add(1);
            database.Add(2);
            database.Add(3);
            database.Remove();
            int expectedResult = 2;

            Assert.That(database.Count, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void RemoveRemovesLastElement()
        {
            int lastElement = 3;
            database.Add(1);
            database.Add(2);
            database.Add(lastElement);
            database.Remove();

            int[] elements = database.Fetch();

            Assert.IsFalse(elements.Contains(lastElement));
        }

        [Test]
        public void FetchReturnsDatabaseCopyInsteadOfReference()
        {
            database.Add(1);
            database.Add(2);

            int[] firstCopy = database.Fetch();
            database.Add(3);

            int[] secondCopy = database.Fetch();

            Assert.That(firstCopy, Is.Not.EqualTo(secondCopy));
        }

        [Test]
        public void CountReturnZero_WhenDatabaseIsEmpty()
        {
            Assert.That(database.Count, Is.EqualTo(0));
        }
    }
}