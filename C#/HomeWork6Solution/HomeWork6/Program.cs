using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            // buy a couple of normal toys

            Toy t1 = new Toy("Games console", 99.99M);

            t1.Buy();



            Toy t2 = new Toy("Lego set", 11.99M);

            t2.Buy();



            string s = "";

            foreach (Toy t in Toy.Toys)

            { s += t.Description + "\n"; }

            MessageBox.Show(s.Trim(), "Purchases");
        }
    }
}
