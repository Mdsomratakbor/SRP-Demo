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
            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                StandardMessage.EndApplication();
            }
       
            StandardMessage.EndApplication();
        }
    }
}
