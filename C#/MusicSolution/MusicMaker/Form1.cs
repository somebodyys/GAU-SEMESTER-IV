using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicMaker
{
    public partial class Form1 : Form
    {
        List<Control> items = new List<Control>();
        public Form1()
        {
            InitializeComponent();
        }

        private void drawMusic()
        {
            TextBox typeBox = new TextBox();
            typeBox.Location = new Point(200, 200);
            Controls.Add(typeBox);
            items.Add(typeBox);
        }


        private void generateButton_Click(object sender, EventArgs e)
        {
            string input = choice.Text;
            switch (input)
            {
                case "Music":
                    drawMusic();
                    break;
                case "String":
                    break;
                case "Guitar":
                    break;
            }
        }
    }
}
