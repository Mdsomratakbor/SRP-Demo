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
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessage.ValidateErrorMessage("first name");
                return false;
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessage.ValidateErrorMessage("last name");
                return  false;
            }
            return true;
        }
    }
}
