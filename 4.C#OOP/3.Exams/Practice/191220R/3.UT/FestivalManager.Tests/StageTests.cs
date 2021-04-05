// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 

using FestivalManager.Entities;

namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
        [SetUp]
        public void Setup()
        {

        }
        
        [Test]
	    public void ThrowIfUnder18()
        {
            var performer = new Performer("Vic", "Kuz", 17);

            Assert.Throws<ArgumentException>(() => AddPerformer(performer));
        }

	}
}