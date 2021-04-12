using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6_7
{
    public class SortByName : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }

    public class SortByStipendy : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
     
            if (x.Stipendy == y.Stipendy) return 0;
            if (x.Stipendy < y.Stipendy) return -1;
            return 1;
        }
    }
}
