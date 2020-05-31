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
            try
            {
                if(T == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Class_Error, "Enter Proper Class Name");
                }
                var objectInstance = Activator.CreateInstance(T);
                return objectInstance;
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Class_Error, "Enter Proper Class Name");
            }
        }

        public static void Main(string[] args)
        {
           
        }
    }
}
