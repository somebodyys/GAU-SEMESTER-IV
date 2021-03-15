using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    class Triangle
    {
        public static float calcTriangle(int height, int side)
            => height * side / 2;

        public static float calcTriangle(int sideOne, int sideTwo, int sideThree)
            => sideOne + sideTwo + sideThree;
    }
}
