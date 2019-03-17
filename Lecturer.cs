using System;
using System.Collections.Generic;

namespace Homework_Class07.a
{
    public class Lecturer : Person
    {
        public int YearsExperience { get; set; }
        public List<string> Expertises { get; set; }
        public List<DayOfWeek> Availability { get; set; }

        public override string GetFullName()
        {
            var parent = base.GetFullName();
            return $"{parent} is available for {Availability.Count} days";
        }

        public Lecturer(string firstName, string lastName, int age, Gender gender, List<DayOfWeek> availability)
            : base(firstName, lastName, age, gender)
        {
            Availability = availability;
        }
    }
}