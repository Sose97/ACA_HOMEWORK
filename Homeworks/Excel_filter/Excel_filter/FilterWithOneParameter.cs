using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_filter
{
    class FilterWithOneParameter : Filter
    {
        public string compare { get; set; }

        public FilterWithOneParameter(string obj)
        {
            this.compare = obj;
        }

        public override Func<Student,bool> GetValues()
        {
            return Comparer;
        }

        public bool Comparer(Student student)
        {
            if (student.Name.Equals(compare)||student.Name.Equals(compare)
                ||student.PhoneNumber.ToString().Equals(compare))
                return true;
            return false;
        }
    }
}
