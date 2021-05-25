using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    class Program
    {

        /// <summary>
        /// სტრიქონში მოძებნის იმ სიტყვებს, რომლებიც "ძე" სიმბოლოებით მთავრდება და ამ
        ///სიტყვებს ჩაწერს სტრიქონების მასივში.
        /// </summary>
        /// <param name="word">შესამოწმებელი სიტყვა</param>
        /// <param name="compare">მთავრება</param>
        /// <returns></returns>
        public static string[] Task_12_3_35(string word, string compare)
        {
            string[] splited = word.Split();
            List<string> result = new List<string>();
            foreach (string item in splited)
            {
                if(item.Length - compare.Length >= 0 && item.Substring(item.Length - compare.Length).Trim().Equals(compare)) result.Add(item);  
            }
            return result.ToArray();
        }


        /// <summary>
        /// მოცემულია ორი სიტყვა. ისინი გააერთიანეთ ისე, რომ წინ მოთავსთდეს მოკლე სიტყვა,შემდეგ კი - გრძელი.
        /// </summary>
        /// <param name="one">პირველი სიტყვა</param>
        /// <param name="two">მეორე სიტყვა</param>
        /// <returns></returns>
        public static string Task_12_3_50(string one, string two)
            => one.Length > two.Length ? $"{two}{one}" : $"{one}{two}";


        /// <summary>
        /* შექმენით დინამიური სტრიქონი. კონსტრუქტორს გადაეცით თქვენი სახელი და გვარი,
        საწყისი ინდექსი, გადასაწერი სიმბოლოების რაოდენობა და ტევადობა.საწყისი ინდექსია 3,
        გადასაწერი სიმბოლოების რაოდენობაა 7, ტევადობაა 50. დინამიურ სტრიქონს მე-4 პოზიციიდან
        ჩაუმატეთ სიტყვა "კომპიუტერი".
        */
        /// </summary>
        /// <returns></returns>
        public static string Task_12_2_4()
        {
            StringBuilder mySting = new StringBuilder("Tornike Kikacheishvili", 3, 7, 50);
            mySting.Insert(4, "Computer");
            return mySting.ToString();
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("************** Task_12_3_35 **************");
            Console.Write("Enter Test String : ");
            string testString = Console.ReadLine();
            Console.Write("Ends With : ");
            string compare = Console.ReadLine();
            string[] myArray = Task_12_3_35(testString, compare);
            Console.Write($"These Words End with {compare} : {{ ");
            foreach (string item in myArray)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");

            Console.WriteLine("\n\n************** Task_12_2_4 **************");
            Console.WriteLine(Task_12_2_4());

            Console.WriteLine("\n\n************** Task_12_3_50 **************");
            Console.Write("One String : ");
            string one= Console.ReadLine();
            Console.Write("Two String : ");
            string two = Console.ReadLine();
            Console.WriteLine(Task_12_3_50(one, two));


            Console.ReadKey();
        }

        
    }
}
