using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser() { }

        public MoodAnalyser(String message)
        {
            this.message = message;
        }

        public string Mood(string message) 
        {
            //hadle null exception
            try
            {
                if (message.Length == 0)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_STRING, "Enter Proper String");
                if (message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "Enter Proper String");
            }

        }
    }
}
