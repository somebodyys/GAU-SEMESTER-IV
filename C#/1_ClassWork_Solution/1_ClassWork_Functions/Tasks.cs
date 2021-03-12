using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork1_Functions
{
    public static class Tasks
    {

        //Check if building right_angle triangle could be built.
        //Returns bool
        public static bool task_2_1_31(float a, float b, float c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Triangle sides must be positive!");
            return (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a);
        }

        //Returns List of Elements That are multiples of 5
        public static List<int> task_3_2_12(List<int> input)
            => input.Where(i => i % 5 == 0).ToList();
     

        public static int task_3_2_12A(int x, int y)
        {
            if (x == y)
                throw new Exception("These Numbers Are Equal!");
            bool x_reminder = (x % 5 == 0);
            bool y_reminder = (y % 5 == 0);
            if (x_reminder ^ y_reminder)
                throw new Exception("Both Are Dividable by 5");
            return (x_reminder ? x : y);
        }


        //Returns Fibonachi numbers by Index
        public static int task_3_4_10(int index)
        {
            if (index < 0)
                throw new Exception("Only positive index!");
            if (index == 0) return 0;
            if (index == 1) return 1;
            return task_3_4_10(index - 1) + task_3_4_10(index - 2);
        }


        //Replace negative Numbers by 0
        public static int[] task_4_1_43(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++) numbers[i] = numbers[i] < 0 ? 0 : numbers[i];
            return numbers;
        }


        //Returns List of even numbers from 2D array
        public static int[] task_4_2_20(int[,] input)
        {
            List<int> result = new List<int>();
            for (int row = 0; row < input.GetLength(0); row++)
                for (int col = 0; col < input.GetLength(1); col++)
                    if (input[row, col] % 2 == 0)
                        result.Add(input[row, col]);
            return result.ToArray();
        }


        //Returns the sum of items in top not main diagonal
        public static int task_4_2_81(int[,] input)
        {
            if (input.GetLength(0) != input.GetLength(1))
                throw new Exception("Only Quadratic Matrix accepted!");
            int result = 0;
            for (int row = 0; row < input.GetLength(0); row++)
                for (int col = 0; col < input.GetLength(1) - row; col++)
                    result += input[row, col];
            return result;
        }
    }
}
