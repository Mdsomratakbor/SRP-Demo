using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    public  class PersonDataCapture
    {
        public static  Person Capture()
        {
            Person user = new Person();
            // Ask for user information 
            Console.Write("What is you First name :");
            user.FirstName = Console.ReadLine();
            Console.Write("What is you Last name :");
            user.LastName = Console.ReadLine();
            return user;
        }
    }
}
