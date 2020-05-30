using NUnit.Framework;
using Mood_Analyser;

namespace Mood_Analyser_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenRightMessage_ShouldReturnHappy()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("Happy");
            Assert.AreEqual("HAPPY", mood);
        }

        [Test]
        public void GivenSadMoodMessage_ShouldReturnSAD()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("I am in Sad Mood");
            Assert.AreEqual("SAD", mood);
        }

        [Test]
        public void GivenAnyMooodMessage_ShouldReturnHAPPY()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("I am in Any Mood");
            Assert.AreEqual("HAPPY", mood);
        }

        [Test]
        public void GivenMessage_ShouldReturnHAPPY()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood");
            string mood = moodAnalyser.Mood("I am in Any Mood");
            Assert.AreEqual("HAPPY", mood);
        }

        [Test]
        public void GivenSadMessage_ShouldReturnSAD()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string mood = moodAnalyser.Mood("I am in Sad Mood");
            Assert.AreEqual("SAD", mood);
        }

        [Test]
        public void GivenNullMessage_ShouldReturnHAPPY()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                string mood = moodAnalyser.Mood(null);
              
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_NULL, e.eType);
            }
        }

        [Test]
        public void GivenEmptyMessage_ShouldReturnCustomException()
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                string mood = moodAnalyser.Mood("");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.EMPTY_STRING, e.eType);
            }
        }
    }
}