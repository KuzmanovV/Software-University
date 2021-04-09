// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 

using System.Linq;
using FestivalManager.Entities;

namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
	public class StageTests
    {
        private Performer performer;
        private Stage stage;
        private Song song;
        [SetUp]
        public void Setup()
        {
            performer = new Performer("Vic", "Kuz", 48);
            song = new Song("Once",TimeSpan.FromSeconds(60));
            stage = new Stage();
            stage.AddPerformer(performer);
            stage.AddSong(song);
            stage.AddSongToPerformer("Once", "Vic Kuz");
        }
        
        [Test]
	    public void ThrowIfUnder18()
        {
            Performer performer17 = new Performer("Pesho", "Pe", 17);
            
            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));

            Assert.AreEqual(stage.Performers.Count,1);
        }
        
        [Test]
	    public void ThrowSongUnder1Min()
        {
            Song song30 = new Song("Once",TimeSpan.FromSeconds(30));

            Assert.Throws<ArgumentException>(() => stage.AddSong(song30));
        }
        
        [Test]
	    public void AddSongToPerfNull()
        {
            Song songNull = new Song(null,TimeSpan.FromSeconds(30));
            Performer performerNull = new Performer(null, "Kuz", 18);

            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(null,"Vic Kuz"));
            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer("Once",null));
        }

        [Test]
        public void PlayCount()
        {
            var playCount = stage.Play();
            var expectedPlayCount = "1 performers played 1 songs";

            Assert.AreEqual(playCount,expectedPlayCount);
        }

        [Test]
        public void GetPerformerAndGetSongExc()
        {
            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Once","wrongPerformerName"));
            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("wrongSongName","Vic Kuz"));
        }
    }
}