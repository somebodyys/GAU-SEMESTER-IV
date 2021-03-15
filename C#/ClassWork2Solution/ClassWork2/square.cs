using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    class Square
    {
        private int side;
        public int Perimeter = 0;

        public Square(int side)
        {
            this.side = side;
        }


        public Square():this(0)
        {
            
        }

        public Square(Square square):this(square.side)
        {
            Perimeter = calcPerimeter(square.side);
        }

        int calcPerimeter(int side)
            => side * 4;

    }
}
