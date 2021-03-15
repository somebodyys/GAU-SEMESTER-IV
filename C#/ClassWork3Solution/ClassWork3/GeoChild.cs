using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3
{
    class GeoChild : GeometricFigure
    {

        private int a;
        private int b;
        private int c;
        private int d;
        public GeoChild(int sideOne, int sideTwo, int sideThree, int sideFour)
        {
            a = sideOne;
            b = sideTwo;
            c = sideThree;
            d = sideFour;
        }

        public override int Perimetri()
        {
            return a + b + c + d;
        }
    }
}
