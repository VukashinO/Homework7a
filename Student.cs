
using System;
using System.Collections.Generic;

namespace Homework_Class07.a
{
    public class Student : Person
    {
        public List<bool> Attendance { get; set; }
        public List<bool> Homeworks { get; set; }
        public string StudentId { get; set; }
        public string Evaluation { get; set; }

        public override string GetFullName()
        {
            string parentValue = base.GetFullName();
            return $"#{StudentId}: {parentValue}";
        }

        public Student(string studentId, string firstName, string lastName, int age, Gender gender) 
            : base(firstName, lastName, age, gender)
        {
            Console.WriteLine("In Student constructor");
            StudentId = studentId;
        }

    }
}