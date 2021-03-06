using NUnit.Framework;
using Mood_Analyser;
using System.Reflection;
using System;

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
        /// <summary>
        /// UseCase1.1 : Given Sad Message Should Return SAD
        /// </summary>
        [Test]
        public void GivenSadMoodMessage_ShouldReturnSAD()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("I am in Sad Mood");
            Assert.AreEqual("SAD", mood);
        }
        /// <summary>
        /// UseCase1.2 : Given Any Mood Message Should Return HAPPY
        /// </summary>
        [Test]
        public void GivenAnyMooodMessage_ShouldReturnHAPPY()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string mood = moodAnalyser.Mood("I am in Any Mood");
            Assert.AreEqual("HAPPY", mood);
        }
        /// <summary>
        /// UseCase1.1 'Refactored' : Given Sad Mood Message in Constructor Should Return SAD
        /// </summary>
        [Test]
        public void GivenSadMessage_ShouldReturnSAD()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            string mood = moodAnalyser.Mood("I am in Sad Mood");
            Assert.AreEqual("SAD", mood);
        }
        /// <summary>
        /// UseCase1.2 'Refactored' : Given Happy Mood Message in Constructor Should Return HAPPY
        /// </summary>
        [Test]
        public void GivenMessage_ShouldReturnHAPPY()
        {
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            string mood = moodAnalyser.Mood("I am in Happy Mood");
            Assert.AreEqual("HAPPY", mood);
        }
        /// <summary>
        /// UseCase3 : if wrong info should return custom Exception
        /// </summary>
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
                Assert.AreEqual(MoodAnalyserException.ExceptionType.Entered_Null, e.eType);
            }
        }
        /// <summary>
        /// UseCase3.2 : Given Empty Message should throw Custom Exception
        /// </summary>
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
                Assert.AreEqual(MoodAnalyserException.ExceptionType.Empty_String, e.eType);
            }
        }
        /// <summary>
        /// UseCase4.1 : Given Mood Analyser class Should return Mood Analyser Object
        /// </summary>
        [Test]
        public void GivenMoodAnalyserFactory_ShouldReturnMoodAnalyserObject()
        {
            Object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.MoodAnalyser", "Happy Mood");
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            bool actual = moodAnalyser.equals(moodAnalyserFactory);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UserCase4.2 : Given Class Name When Not Proper should Thro MoodAnalyserException
        /// </summary>
        [Test]
        public void GivenClassName_WhenNotProper_ShouldThrowCustomException()
        {
            try
            {
                Object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.Mood", "Happy Mood");
                MoodAnalyser moodAnalyser = new MoodAnalyser();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Class_Error, e.eType);
            }
        }
        /// <summary>
        /// UseCase4.3 : Given Class When Constructor Not Proper should Throw MoodAnalyserException
        /// </summary>
        [Test]
        public void GivenClass_WhenConstructorNotProper_ShouldThrowCustomException()
        {
            try
            {
                object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.MoodAnalyser", null);
                MoodAnalyser moodAnalyser = new MoodAnalyser();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Method_Error, e.eType);
            }
        }
        /// <summary>
        /// UseCase5.1 : Given Mood Analyser Factory with Parameter Return Mood Analyser Object
        /// </summary>
        [Test]
        public void GivenMoodAnalyserFactoryWithParameterConstructor_ShouldReturnMoodAnalyserObject()
        {
            Object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.MoodAnalyser", "Happy Mood");
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            bool actual = moodAnalyser.equals(moodAnalyserFactory);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// UserCase5.2 : Given Class Name When Not Proper should Throw MoodAnalyserException
        /// </summary>
        [Test]
        public void GivenClassNameWithParameter_WhenNotProper_ShouldThrowCustomException()
        {
            try
            {
                Object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.Mood", "Happy Mood");
                MoodAnalyser moodAnalyser = new MoodAnalyser();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Class_Error, e.eType);
            }
        }
        /// <summary>
        /// UserCase5.3 : Given Class Name When Constuctor is Not Proper should Throw MoodAnalyserException
        /// </summary>
        [Test]
        public void GivenClassNameWithParameter_WhenConstructorNotProper_ShouldThrowCustomException()
        {
            try
            {
                Object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("Mood_Analyser.MoodAnalyser", null);
                MoodAnalyser moodAnalyser = new MoodAnalyser();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Method_Error, e.eType);
            }
        }
        /// <summary>
        /// UseCase6.1 : Given Happy Message Should Using Reflection When Proper Should Return HAPPY Mood.
        /// </summary>
        [Test]
        public void GivenHappyMessageInMethod_WhenProper_ShouldReturnHAPPY()
        {
            string moodAnalyserFactory = MoodAnalyserFactory.MethodInvokeUsingReflaction("Mood", "Happy Mood");
            Assert.AreEqual("HAPPY", moodAnalyserFactory);
        }
        /// <summary>
        /// UseCase6.2 : Given Happy Message Should Using Reflection When Method Not Proper Should Return Exception.
        /// </summary>
        [Test]
        public void GivenHappyMessageInMethod_WhenMethodNotProper_ShouldReturnException()
        {
            try
            {
                string moodAnalyserFactory = MoodAnalyserFactory.MethodInvokeUsingReflaction("Mood123", "Happy Mood");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Method_Error, e.eType);
            }
        }
        /// <summary>
        /// UseCase 7.1 : given fieldName should return Happy
        /// </summary>
        [Test]
        public void GivenHappyMessageInMethod_WhenFieldNameProper_ShouldReturnHAPPY()
        {
            string moodAnalyserFactory = MoodAnalyserFactory.SetFieldUsingReflection("Mood", "myString", "Happy Mood");
            Assert.AreEqual("HAPPY", moodAnalyserFactory);
        }
        /// <summary>
        /// UseCase 7.2 : given Improper field should return exception.
        /// </summary>
        [Test]
        public void GivenHappyMessageInMethod_WhenFieldImproper_ShouldReturnException()
        {
            try
            {
                string moodAnalyserFactory = MoodAnalyserFactory.SetFieldUsingReflection("Mood", "improper", "Sad Mood");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Field_Error, e.eType);
            }
        }
        /// <summary>
        /// UseCase 7.3 : given null field should return exception.
        /// </summary>
        [Test]
        public void GivenHappyMessageInMethod_WhenNullField_ShouldReturnException()
        {
            try
            {
                string moodAnalyserFactory = MoodAnalyserFactory.SetFieldUsingReflection("Mood", null, "Mood");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Such_Field_Error, e.eType);
            }
        }


    }
}