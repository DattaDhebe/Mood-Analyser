﻿using System;
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
        /// <param name="constructor"></param>
        /// <returns></returns>
        public static object CreateObject(string ClassName, params object[] constructor)
        {    
            try
            {
                Type T = Type.GetType(ClassName);
                
                // To find if ClassName is Right or Not if Wrong throw Exception
                if (T == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Class_Error, "Enter Proper Class Name");
                }
                var objectInstance = Activator.CreateInstance(T, constructor);
                
                // To find construct parameter is right or wrong if Wrong throw Missing Method Exception
                if (objectInstance == null)
                {
                    throw new MissingMethodException(MoodAnalyserException.ExceptionType.No_Such_Method_Error+ "Enter Right Method");
                }
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
