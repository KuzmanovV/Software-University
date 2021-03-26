using System;
//using ExtendedDatabase;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase extendedDatabase;
        [SetUp]
        public void Setup()
        {
            extendedDatabase = new ExtendedDatabase();
        }

        [Test]
        public void AddThrowsException_WhenCapacityAcceeded()
        {
            for (int i = 0; i < 16; i++)
            {
                extendedDatabase.Add(new Person(i, $"Username{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => 
                extendedDatabase.Add(new Person(16, "InvalidUserName")));
        }
        
        [Test]
        public void AddThrowsException_WhenUsernameAlreadyUsed()
        {
            string userName = "Victor";    
            extendedDatabase.Add(new Person(1, userName));

            Assert.Throws<InvalidOperationException>(() => 
                extendedDatabase.Add(new Person(2, userName)));
        }
        
        [Test]
        public void AddThrowsException_WhenIdAlreadyUsed()
        {
            long id = 5;    
            extendedDatabase.Add(new Person(id, "RandomUser"));

            Assert.Throws<InvalidOperationException>(() => 
                extendedDatabase.Add(new Person(id, "RandomUser1")));
        }

        [Test]
        public void AddIncreasesCounter_WhenUserValid()
        {
            extendedDatabase.Add(new Person(1, "Victor"));
            extendedDatabase.Add(new Person(2, "Pesho"));
            int expectedCount = 2;

            Assert.That(extendedDatabase.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void RemoveThrowsException_WhenDBEmpty()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.Remove());
        }

        [Test]
        public void RemoveRemovesElementFromDB()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                extendedDatabase.Add(new Person(i, $"UserName{i}"));
            }

            extendedDatabase.Remove();
            Assert.That(extendedDatabase.Count, Is.EqualTo(n-1));
            Assert.Throws<InvalidOperationException>(()=>extendedDatabase.FindById(n-1));
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void FindByUserNameThrowsException_WhenArgumentIsNullOrEmpty(string userName)
        {
            Assert.Throws<ArgumentNullException>(() => extendedDatabase.FindByUsername(userName));
        }

        [Test]
        public void FindByUserNameThrowsException_WhenUnserNameDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindByUsername("UserName"));
        }

        [Test]
        public void FindByUserName_ReturnsExpectedUser_WhenUserExists()
        {
            Person person = new Person(1, "Victor");

            extendedDatabase.Add(person);

            Person dbPerson = extendedDatabase.FindByUsername(person.UserName);

            Assert.That(person,Is.EqualTo(dbPerson));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-16)]
        public void FindByIdThrowsException_WhenIdIsNegative(long id)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => extendedDatabase.FindById(id));
        }

        [Test]
        public void FindByIdThrowsException_WhenIdDoesNotExist()
        {
            Assert.Throws<InvalidOperationException>(() => extendedDatabase.FindById(100));
        }

        [Test]
        public void FindByIdReturnsExpectedUser_WhenUserExists()
        {
            Person person = new Person(42, "Victor");
            extendedDatabase.Add(person);
            Person dbPerson = extendedDatabase.FindById(person.Id);
            Assert.That(dbPerson, Is.EqualTo(person));
        }

        [Test]
        public void CtorThrowsException_WhenCapacityExceeded()
        {
            Person[] arguments = new Person[17];
            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"UserName{i}");
            }

            Assert.Throws<ArgumentException>(() => extendedDatabase = new ExtendedDatabase(arguments));
        }

        [Test]
        public void CtorAddsInitialPeopleToDB()
        {
            Person[] arguments = new Person[5];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = new Person(i, $"UserName{i}");
            }

            extendedDatabase = new ExtendedDatabase(arguments);
            
            Assert.That(extendedDatabase.Count, Is.EqualTo(arguments.Length));

            foreach (var person in arguments)
            {
                Person dbPerson = extendedDatabase.FindById(person.Id);
                Assert.That(person,Is.EqualTo(dbPerson));
            }
        }
    }
}