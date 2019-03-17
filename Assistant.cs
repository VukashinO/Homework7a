using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Class07.a
{
    public class Assistant : Person
    {
        public int AssistYears { get; set; }
        public List<DayOfWeek> AvailabilityForHomeworks { get; set; }
        public List<string> ProgramLanguages { get; set; }


        public Assistant(string firstName, string lastName, int age, Gender gender, List<DayOfWeek> availabilityForHomeworks, List<string> propgramLanguages)
            : base(firstName, lastName, age, gender)
        {
            AvailabilityForHomeworks = availabilityForHomeworks;
            ProgramLanguages = propgramLanguages;
        }

        public override string GetFullName()
        {
            var parent = base.GetFullName();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{parent}")
                .AppendLine($"is an {Age} years old")
                .AppendLine($"{Gender} assitant")
                .AppendLine($"with {AssistYears} years expiriance at Sedc")
                .AppendLine($"who is available for homeworks {AvailabilityForHomeworks.Count} days in the week.")
                .AppendLine($"you can ask him anything about:");
            foreach (var program in ProgramLanguages)
            {
                sb.AppendLine($"{program}");
            }

            return sb.ToString();
        }

    }
}