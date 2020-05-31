using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        private string message { get; set; }

        public MoodAnalyser() { }

        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public string Mood(string message) 
        {
            
            try
            {
                /// To Find out wether the String is Emty of Not
                if (message.Length == 0)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_STRING, "Enter Proper String");
                }
    
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "Enter Proper String");
            }

        }

        /// <summary>
        /// To compare Two Object and if Equals Return True
        /// </summary>
        /// <param name="moodAnalyserFactory"></param>
        /// <returns></returns>
        public bool Equals(Object moodAnalyserFactory)
        {
            Object Mood = new MoodAnalyser();
            var moodAnalyser = Mood.GetType();
            var moodFactory = moodAnalyserFactory.GetType();

            if (moodFactory.Equals(moodAnalyser))
            {
                return true;
            }
            return false;
        }

    }
}
