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
            Person user = new Person();
            // Ask for user information 
            Console.Write("What is you First name :");
            user.FirstName = Console.ReadLine();
            Console.Write("What is you Last name :");
            user.LastName = Console.ReadLine();
            //Checks to be sure the first and last name are valid
            if (!string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("Yod did not give us a valid first name !");
                StandardMessage.EndApplication();
                return;
            }
            if (!string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("Yod did not give us a valid last name !");
                StandardMessage.EndApplication();
                return;
            }
            // create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            StandardMessage.EndApplication();
        }
    }
}
