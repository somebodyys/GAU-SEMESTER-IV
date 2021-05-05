using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyToys
{
    public class CuddlyToy : Toy
    {

        string animal;
        public string Animal { set { animal = value; } }
        public override string Description => $"CUDDLY {What}: Flopsy {What} ($ {Price})";

        public CuddlyToy(string name, decimal price)
            : base(name, price){ }
           
    }
}
