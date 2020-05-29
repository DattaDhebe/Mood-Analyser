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

        public string Mood()
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            return "HAPPY";
        }

        public string Mood(string msg)
        { 
            if (msg.Contains("Sad Mood"))
            {
                return "SAD";
            }
            return "HAPPY"; 
        }
    }
}
