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
            Person output = new Person();

            // Ask for user information 
            Console.Write("What is you First name :");
            output.FirstName = Console.ReadLine();

            Console.Write("What is you Last name :");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
