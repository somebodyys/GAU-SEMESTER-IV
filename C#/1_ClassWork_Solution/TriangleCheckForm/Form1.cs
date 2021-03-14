using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassWork1_Functions;

namespace TriangleCheckForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultBox.Text = Tasks.task_2_1_31(Convert.ToInt64(sideOne.Value), Convert.ToInt64(sideTwo.Value), Convert.ToInt64(sideThree.Value)) ? "Yes" : "No";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
