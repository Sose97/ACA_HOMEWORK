using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excel_filter
{
    abstract class Filter
    {
        abstract public Func<Student,bool> GetValues();
    }
}
