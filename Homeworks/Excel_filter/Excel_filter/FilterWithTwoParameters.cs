﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_filter
{
    class FilterWithTwoParameters : Filter
    {
        public int from { get; set; }
        public int to { get; set; }
        {
        public override Func<Student, bool> GetValues()
        {
            return Comparer;
        }
        public bool Comparer(Student student)
        {
            if ((student.NumberOfKnownProgrammingLanguages >= this.from && student.NumberOfKnownProgrammingLanguages < this.to) || 
                return true;
            return false;
        }
    }
}