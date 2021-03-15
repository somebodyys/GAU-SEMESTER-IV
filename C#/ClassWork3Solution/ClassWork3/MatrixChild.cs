using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3
{
    class MatrixChild : Matrix
    {
        private int[,] matrix;

        public int positiveMin()
        {
            int[,] check = base.matrix;
            int result = check[0,0];
            for (int i = 0; i < check.GetLength(0); i++)
                for(int j = 1; j < check.GetLength(1); j++)
                {
                    if (check[i, j] > 0 && check[i, j] < result)
                        result = check[i, j];
                }
            return result;
        }


        public int positiveMax()
        {
            int result = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0 && matrix[i, j] > result)
                        result = matrix[i, j];
                }

            return result;
        }
    }
}
