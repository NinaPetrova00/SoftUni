// Use this file for your unit tests.
// When you are ready to submit, REMOVE all using statements to Festival Manager (entities/controllers/etc)
// Test ONLY the Stage class. 
namespace FestivalManager.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class StageTests
    {
        private Stage stage = null;

        [SetUp]
        public void InitTest()
        {
            stage = new Stage();
        }

        [Test]
        public void AddPerformer_ThrowExceptionIfPerformerIsNull()
        {
           // Assert.Throws<ArgumentNullException>(() => stage.AddPerformer(null));
            Assert.Throws(Is.TypeOf<ArgumentNullException>().And.Message.EqualTo("Can not be null! (Parameter 'performer')"),() => stage.AddPerformer(null));
        }

        [Test]
        public void AddPerformer_ThrowExceptionIfPerformerIsUnder18()
        {
            var performer = new Performer("Ivan", "Petrov", 10);

            Assert.Throws<ArgumentException>(() => stage.AddPerformer(performer));
        }

        [Test]
        public void AddPerformer_AddValidPerformer()
        {
            var performer = new Performer("Ivan", "Petrov", 23);

            stage.AddPerformer(performer);

            Assert.That(stage.Performers.Count == 1);
            Assert.That(stage.Performers.FirstOrDefault().Equals(performer));
        }

        [Test]
        public void AddSong_ThrowExceptionIfSongIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => stage.AddSong(null));
        }

        [Test]
        public void AddSong_ThrowExceptionIfSongIsUnder1Minute()
        {
            var song = new Song("Liberta", new TimeSpan(0, 0, 34));

            Assert.Throws<ArgumentException>(() => stage.AddSong(song));
        }


        [Test]
        public void AddSongToPerformer_ThrowExceptionIfPerformerandSongIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer(null, "Ivan"));
            Assert.Throws<ArgumentNullException>(() => stage.AddSongToPerformer("Liberta", null));
        }

        [Test]
        public void AddSongToPerformer_AddValidSong()
        {
            var performer = new Performer("Ivan", "Petrov", 23);
            var song = new Song("Liberta", new TimeSpan(0, 1, 34));
            stage.AddPerformer(performer);
            stage.AddSong(song);

            stage.AddSongToPerformer("Liberta", "Ivan Petrov");

            Assert.That(performer.SongList.Count == 1);
            Assert.That(performer.SongList.FirstOrDefault().Equals(song));
        }

        [Test]
        public void Play_AddValidParams()
        {
            var performer = new Performer("Ivan", "Petrov", 23);
            var song = new Song("Liberta", new TimeSpan(0, 1, 34));
            stage.AddPerformer(performer);
            stage.AddSong(song);

            stage.AddSongToPerformer("Liberta", "Ivan Petrov");

            string result = stage.Play();

            Assert.That(result == "1 performers played 1 songs");
        }

        [Test]
        public void GetSong_ThrowsExceptionIfSongDoesNotExisist()
        {
            var performer = new Performer("Ivan", "Petrov", 23);
            stage.AddPerformer(performer);

            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Liberta", "Ivan Petrov"));
        }

        [Test]
        public void GetPerformer_ThrowsExceptionIfPerformerDoesNotExisist()
        {
            var song = new Song("Liberta", new TimeSpan(0, 1, 34));
            stage.AddSong(song);

            Assert.Throws<ArgumentException>(() => stage.AddSongToPerformer("Liberta", "Ivan Petrov"));
        }
    }
}