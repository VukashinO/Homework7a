
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Class07.a
{
    class Program
    {
        static void Main(string[] args)
        {

            var availableForHomeworks = new List<DayOfWeek>()
            { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday};
            var languages = new List<string>()
            { "JS", "C#", ".Net", "Angular", "NodeJS"};
            var assistent = new Assistant("Viktor", "Jakovlev", 26, Gender.Male, availableForHomeworks, languages);
            assistent.AssistYears = 2;

            Console.WriteLine(assistent.GetFullName());
        }
    }
}