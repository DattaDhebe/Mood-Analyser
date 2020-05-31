using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Mood_Analyser
{
    public class MoodAnalyserFactory
    {
        public MoodAnalyserFactory()
        {
        }
        /// <summary>
        /// Create Intance of Object to use in reflection
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public static object CreateObject(string ClassName)
        {
            Type T = Type.GetType(ClassName);
            var objectInstance = Activator.CreateInstance(T);
            return objectInstance;
        }

        public static void Main(string[] args)
        {
           
        }
    }
}
