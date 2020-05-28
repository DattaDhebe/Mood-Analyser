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
        public void GivenWrongMessage_ShouldReturnSAD()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("sad");
            Assert.AreEqual("SAD", mood);
        }
    }
}