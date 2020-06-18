using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();


            Person user = PersonDataCapture.Capture();
            
            // create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            StandardMessage.EndApplication();
        }
    }
}
