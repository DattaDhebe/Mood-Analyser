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

        public string Mood(string msg)
        {
            try
            {
                if (msg.Contains("Sad Mood"))
                {
                    return "SAD";
                }
                return "HAPPY";
            } catch (NullReferenceException e)
            {
                return "HAPPY";
            }
        }
    }
}
