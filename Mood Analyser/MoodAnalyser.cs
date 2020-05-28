using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyser
{
    public class MoodAnalyser
    {
        public string Mood(string message)
        {
            if (message.Contains("Happy"))
            {
                return "HAPPY";
            }
            return "SAD";
        }
    }
}
