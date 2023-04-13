using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11_210229030
{
    public abstract class Employee

    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        // return string representation of Employee object, using properties
        public override string ToString() => $"{FirstName} {LastName}\n" + $"social security number: {SocialSecurityNumber}";

        public abstract decimal Earnings();


    }
}
