using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLibrary;

namespace MusicTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicInstrument general = new MusicInstrument("General", "c30", new DateTime(1997, 1, 27));
            StringInstruments instrument1 = new StringInstruments("String", "V5", new DateTime(2007, 4, 12), 12, "Steel");
            Guitar guitar1 = new Guitar("Classical", "F56", new DateTime(2020, 4, 6), 6, "Neylon", 2.3f, false, 54.3f);
  
            guitar1.Weight = 5.5f;
            guitar1.Manufacturer = "Yamaha";

            guitar1.Tune();
            Console.ReadKey();
        }
    }
}
