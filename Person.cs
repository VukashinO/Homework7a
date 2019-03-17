using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class07.a
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Person(string firstName, string lastName, int age, Gender gender)
        {
            

            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }

    }
}