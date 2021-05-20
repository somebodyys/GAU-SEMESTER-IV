using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    class Program
    {

        /// <summary>
        /*
         შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
        დინამიურ მასივში მოძებნეთ თქვენი სახელი. ეკრანზე გამოიტანეთ მოძებნილი ელემენტის
        ინდექსი, დინამიურ მასივში ელემენტების რაოდენობა და თვით დინამიური მასივი. 
        */
        /// </summary>
        public static void Task_14_1_4()
        {
            Console.WriteLine("*************** Task 14.1.4 ***************");
            string[] myStrings = new string[] { "Misha", "Bermuxa", "Tornike",  "Atatkaci" };
            ArrayList myArrayList = new ArrayList(myStrings);
            
            Console.WriteLine($"Index Of Tornike : {myArrayList.IndexOf("Tornike")}");
            Console.WriteLine($"Size Of Dynamic Array : {myArrayList.Count}");
            Console.Write("My Array List : { ");
            foreach (var item in myArrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
        }


        /// <summary>
        /// შექმენით 10-ელემენტიანი რიგი. წაიკითხეთ და ეკრანზე გამოიტანეთ რიგის I ელემენტის
        ///მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ რიგში არსებული ელემენტების
        ///რაოდენობა და რიგის ყველა ელემენტი.რიგიდან ყველა ელემენტი წაშალეთ.
        /// </summary>
        public static void Task_14_2_2()
        {
            Console.WriteLine("\n\n*************** Task 14.1.4 ***************");
            Queue myQueue = new Queue();

            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue($"user{i}");
            }

            Console.WriteLine($"First Element(not Removed) : {myQueue.Peek()}");
            Console.WriteLine($"User count In Queue : {myQueue.Count}");
            Console.Write("Elements : { ");
            foreach (string item in myQueue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");
            myQueue.Clear();
            Console.WriteLine($"User count In Queue(cleared) : {myQueue.Count}");

        }

        static void Main(string[] args)
        {
            Task_14_1_4();
            Task_14_2_2();
            Console.ReadKey();
        }
    }
}
