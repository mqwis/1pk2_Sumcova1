using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_38_04
{
    [Serializable]
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Group { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public string DisplayInfo => $"{LastName} {FirstName} {MiddleName}, {Group}, {GetGenderRussian()}, {BirthDate:dd.MM.yyyy}";

        private string GetGenderRussian() => Gender == Gender.Male ? "Мужской" : "Женский";
    }

}
