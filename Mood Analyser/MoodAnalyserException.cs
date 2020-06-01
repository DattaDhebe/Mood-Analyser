using System;
using System.Runtime.Serialization;


namespace Mood_Analyser
{

    [Serializable]
    public class MoodAnalyserException : Exception
    {
        public MoodAnalyserException()
        {
        }

        public enum ExceptionType
        {
            Empty_String, Entered_Null, No_Such_Class_Error, No_Such_Method_Error
        }
        public ExceptionType eType { get; set; }

        public MoodAnalyserException(ExceptionType eType, string message) : base(message)
        {
            this.eType = eType;
        }

        public MoodAnalyserException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}