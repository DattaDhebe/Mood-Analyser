using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Mood_Analyser
{
    public class MoodAnalyserFactory
    {
        public string FieldValue = "HAPPY";
        public MoodAnalyserFactory() { }
        /// <summary>
        /// Create Intance of Object to use in reflection
        /// </summary>
        /// <param name="ClassName"></param>
        /// <param name="constructor"></param>
        /// <returns></returns>
        public static object CreateObject(string ClassName, string Constructor)
        {
            try
            {
                Type T = Type.GetType(ClassName);

                // To find if ClassName is Right or Not if Wrong throw Exception
                if (T == null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Class_Error, "Enter Proper Class Name");
                }
                var objectInstance = Activator.CreateInstance(T, Constructor);

                // To find construct parameter is right or wrong if Wrong throw Missing Method Exception
                if (objectInstance == null)
                {
                    throw new MissingMethodException(MoodAnalyserException.ExceptionType.No_Such_Method_Error + "Enter Right Method");
                }
                return objectInstance;
            }
            catch (MoodAnalyserException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Class_Error, "Enter Proper Class Name");
            }
        }
        /// <summary>
        /// Invoke Method Using Reflection of Mood Analyser 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string MethodInvokeUsingReflaction(string methodName, string message)
        {
            try
            {
                MethodBase method = typeof(MoodAnalyser).GetMethod(methodName);
                object objInstance = Activator.CreateInstance(typeof(MoodAnalyser), message);
                string[] str = { message };
                string returnMessage = (string)method.Invoke(objInstance, str);
                return returnMessage;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Method_Error, "Enter Proper Method Name");
            }
        }
        public static string SetFieldUsingReflection(string methodName, string fieldName, string message)
        {
            try
            {
                MethodBase method = typeof(MoodAnalyser).GetMethod(methodName);
                object objInstance = Activator.CreateInstance(typeof(MoodAnalyser), message);
                string[] str = { message };
                string returnMessage = (string)method.Invoke(objInstance, str);

                MoodAnalyser myObject = new MoodAnalyser();
                FieldInfo myFieldInfo = typeof(MoodAnalyser).GetField(fieldName,
                    BindingFlags.NonPublic | BindingFlags.Instance);
                // Change the field value using the SetValue method.
                myFieldInfo.SetValue(myObject, "HAPPY");
                // Display the string after applying SetValue to the field.
                string msg = (string)myFieldInfo.GetValue(myObject);
                return msg;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Field_Error, "Enter Proper Method Name");
            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Such_Field_Error, "Enter Proper Method Name");
            }

        }
        public static void Main() { }
    }
}
