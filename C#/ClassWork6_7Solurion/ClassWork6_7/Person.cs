using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6_7
{
    public class Person
    {
        protected string pn;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Pn { get => pn; set => pn = value; }

        
    }
}
