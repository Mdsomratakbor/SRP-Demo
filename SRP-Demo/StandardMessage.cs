using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    public class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to application");
        }
        public static void EndApplication()
        {
            Console.ReadLine();
        }
        public static void ValidateErrorMessage(string fildeName)
        {
            Console.WriteLine($"Yod did not give us a valid { fildeName }");
        }
    }
}
