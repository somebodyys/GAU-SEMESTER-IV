using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6_7
{
    interface ITransport
    {
        int Wheels{ get; }
        ConsoleColor Color{ get; set; }
        string Info();
    
    }
}
