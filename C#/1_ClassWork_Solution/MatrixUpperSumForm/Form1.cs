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

namespace MatrixUpperSumForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Control> cells = new List<Control>();
        private void generateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(rowCount.Value);
                int cols = Convert.ToInt32(colCount.Value);
                int x = 200;
                int y = 19;

                if(rows == cols && rows > 0 && cols > 0)
                {
                    foreach (var cell in cells)
                        Controls.Remove(cell);
                    cells.Clear();
                    calculateSum.Enabled = true;
                    for(int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            NumericUpDown cell = new NumericUpDown();
                            cell.Location = new Point(x, y);
                            cell.Width = 45;
                            cell.Height = 45;
                            cells.Add(cell);
                            Controls.Add(cell);
                            x += 50;
                        }
                        x = 200;
                        y += 25;
                    }
                }
                else
                    throw new Exception("Only Quadratic, Non-Zero Matrix Allowed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateSum_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = Convert.ToInt32(rowCount.Value);
                int cols = Convert.ToInt32(colCount.Value);
                int index = 0;
                int[,] matrixValues = new int[rows, cols];
                for(int i = 0; i < rows; i++)
                    for(int j = 0; j < cols; j++)
                    {
                        int tempVal = Convert.ToInt32(cells[index].Text);
                        matrixValues[i, j] = tempVal;
                        index++;
                    }
                resultBox.Text =Convert.ToString(Tasks.task_4_2_81(matrixValues));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var cell in cells)
                    Controls.Remove(cell);
                calculateSum.Enabled = false;
                resultBox.Text = "";
                cells.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
