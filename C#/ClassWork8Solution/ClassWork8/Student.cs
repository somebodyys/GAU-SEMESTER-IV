using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork8
{
    public class Student
    {
        public string FullName { get; set; }
        public string StudID { get; set; }


        public override string ToString()
            => $"Name {FullName}, StudID {StudID}";
    }
}
