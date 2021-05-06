using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            MovableButtoncs myButton = new MovableButtoncs(randButton);
            myButton.Distance = (int)distanceInput.Value;
            Action<int> myAction = null;
            myAction += myButton.MoveDown;
            myAction += myButton.MoveRight;

            myButton.Move(myAction);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MovableButtoncs myButton = new MovableButtoncs(randButton);
            myButton.Reset();
        }
    }
}
