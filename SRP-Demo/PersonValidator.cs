using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //Checks to be sure the first and last name are valid
            if (!string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("Yod did not give us a valid first name !");
                StandardMessage.EndApplication();
                return false;
            }
            if (!string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("Yod did not give us a valid last name !");
                StandardMessage.EndApplication();
                return  false;
            }
            return true;
        }
    }
}
