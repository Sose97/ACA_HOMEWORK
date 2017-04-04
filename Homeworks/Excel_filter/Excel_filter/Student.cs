using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_filter
{
    class Student
    {
        public string Name { get; set; }        public string Surname { get; set; }        public int YearOfBirth { get; set; }        public int NumberOfKnownProgrammingLanguages { get; set; }        public int PhoneNumber { get; set; }

        public Student(string name, string surname, int birthday, int numberlang, int pone)        {            this.Name = name;            this.Surname = surname;            this.YearOfBirth = birthday;            this.NumberOfKnownProgrammingLanguages = numberlang;            this.PhoneNumber = pone;
        }
    }
}
