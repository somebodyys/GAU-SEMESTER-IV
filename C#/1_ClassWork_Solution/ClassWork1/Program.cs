using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassWork1_Functions;

namespace ClassWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //2.1.31
                float a, b, c;
                Console.Write($"Enter a : ");
                a = Convert.ToInt64(Console.ReadLine());
                Console.Write($"Enter b : ");
                b = Convert.ToInt64(Console.ReadLine());
                Console.Write($"Enter c : ");
                c = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine($"Task 2.1.31 Result : {Tasks.task_2_1_31(a, b, c)}");



                //3.2.12
                List<int> numbers = new List<int> { 2, 5, 11, 15, 25, 4, 35, 36 };
                Console.Write("Task 3.2.12 Result : { ");
                foreach (int i in Tasks.task_3_2_12(numbers))
                {
                    Console.Write($"{i} ");
                }
                Console.Write("}");

                //3.4.10
                Console.Write($"\nTask 3.4.10 Result : ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{Tasks.task_3_4_10(i)} ");
                }


                //4.1.43
                Console.WriteLine($"\nTask 4.1.43 Result : ");
                int[] data = new int[20];
                Random rd = new Random();
                Console.Write("In : ");
                for (int i = 0; i < 20; i++)
                {
                    data[i] = rd.Next(-50, 50);
                    Console.Write($"{data[i]} ");

                }
                Console.Write("\nOut : ");
                foreach (int i in Tasks.task_4_1_43(data))
                {
                    Console.Write($"{i} ");
                }


                //4.2.20
                Console.WriteLine($"\nTask 4.2.20 Result : ");
                int[,] myData = new int[4, 7];
                Console.Write("In : \n");
                for (int i = 0; i < myData.GetLength(0); i++)
                {
                    for (int j = 0; j < myData.GetLength(1); j++)
                    {
                        myData[i, j] = rd.Next(-100, 100);
                        Console.Write($"{myData[i, j]}\t");
                    }
                    Console.WriteLine();
                }

                Console.Write("\nOut : ");
                foreach (int num in Tasks.task_4_2_20(myData))
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
                //4.2.81
                Console.WriteLine($"\nTask 4.2.81 Result : {Tasks.task_4_2_81(myData)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
