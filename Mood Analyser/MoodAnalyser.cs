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

<<<<<<< HEAD
        public string Mood(string message) 
        {
            //hadle null exception
            try
            {
                if (message.Contains("Sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_STRING, "Enter Proper String");
=======
        public string Mood(string message)
        {
            try
            {
                if (message.Contains("Sad Mood"))
                {
                    return "SAD";
                }
                return "HAPPY";
            } catch (NullReferenceException)
            {
                return "HAPPY";
>>>>>>> UC2_AddCustomExceptionHandling
            } 
        }
    }
}
