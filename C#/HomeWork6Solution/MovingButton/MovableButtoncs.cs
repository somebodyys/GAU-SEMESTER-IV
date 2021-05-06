using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingButton
{
    class MovableButtoncs
    {
        #region Vars&Props
        int distance = 0;
        Button myButton = null;
        public int Distance { get => distance; set { distance = value; } }
        #endregion

        public MovableButtoncs(Button button)
        {
            myButton = button;
        }


        #region Methods
        public void Reset()
        {
            myButton.Top = 0;
            myButton.Left = 0;
        }

        public void MoveDown(int distanceDown)
        {
            if(myButton.Top + distanceDown <= 250)
            {
                myButton.Top = myButton.Top + distanceDown;
            }
            
        }

        public void MoveRight(int distanceRight)
        {
            if(myButton.Left + distanceRight <= 195)
            {
                myButton.Left = myButton.Left + distanceRight;
            }  
        }

        public void Move(Action<int> myMovingButton)
        {
            myMovingButton(distance);
        }

        #endregion
    }
}
