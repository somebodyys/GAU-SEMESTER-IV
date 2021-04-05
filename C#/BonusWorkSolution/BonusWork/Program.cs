using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class MyTasks
    {
        public static void Task1()
        {
            List<string> names = new List<string>();
            Console.WriteLine("What is your Name?");
            while (true)
            {
                string input = Console.ReadLine();
                if (String.Equals(input, "done")) break;
                names.Add(input);
            }
            foreach (string name in names)
            {
                Console.WriteLine($"Hello, {name}, nice to meet you!");
            }
        }


        public static void Task2()
        {
            while (true)
            {
            Read:
                Console.WriteLine("What is the input string?");
                string input = Console.ReadLine();
                if (String.Equals(input, "done")) break;
                if (String.Equals(input, "")) goto Read;
                Console.WriteLine($"{input} has {input.Length} characters.\n");
            }
        }
    }

}

namespace BonusWork
{   
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
