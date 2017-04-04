using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_filter
{
    class FilterWithTwoParameters : Filter
    {
        public int from { get; set; }
        public int to { get; set; }        public FilterWithTwoParameters(int from, int to)
        {            this.from = from;            this.to = to;        }
        public override Func<Student, bool> GetValues()
        {
            return Comparer;
        }
        public bool Comparer(Student student)
        {
            if ((student.NumberOfKnownProgrammingLanguages >= this.from && student.NumberOfKnownProgrammingLanguages < this.to) ||                 (student.YearOfBirth >= this.from && student.YearOfBirth <= this.to))
                return true;
            return false;
        }
    }
}
