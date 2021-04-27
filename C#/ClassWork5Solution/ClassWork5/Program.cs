using System;
using System.Collections;

namespace ClassWork5
{
    class Program
    {

        /// <summary>
        /// შექმენით 10-ელემენტიანი დინამიური მასივი სტრიქონების მასივის საფუძველზე.
        ///დინამიური მასივიდან წაშალეთ სამი სტრიქონი.ეკრანზე გამოიტანეთ დინამიურ მასივში
        ///ელემენტების რაოდენობა და თვით დინამიური მასივი.
        /// </summary>
        public static void task_14_1_2()
        {
            Console.WriteLine("\n*** Task 14.1.2 ***");
            string[] myStrings = new string[10]
            {
                "grade",
                "adamant",
                "plausible",
                "lumpy",
                "beginner",
                "unsuitable",
                "careless",
                "haircut",
                "gabby",
                "bored",
            };
            ArrayList myArrayList = new ArrayList(myStrings);
            myArrayList.RemoveRange(2, 3);
            Console.Write($"ArrayList[{myArrayList.Count}] = {{ ");
            foreach (var item in myArrayList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");
        }


        /// <summary>
        /// შექმენით 10-ელემენტიანი ჰეშ-ცხრილი. ჰეშ-ცხრილიდან წაშალეთ ორი ელემენტი.
        ///ეკრანზე გამოიტანეთ ჰეშ-ცხრილში ელემენტების რაოდენობა და ყველა გასაღები და ყველა სიდიდე.
        /// </summary>
        public static void task_14_1_6()
        {
            Console.WriteLine("\n*** Task 14.1.6 ***");
            Hashtable myHashTable = new Hashtable() {
                { "fName", "Tornike" },
                { "lName", "Kikacheishvili"},
                { "Hobbie", "Guitar" },
                { "Age", 23},
                { "Nation", "Georgia"},
                { "Status", "Student"},
                { "CanCook", true},
                { "TellsJokes", false},
                { "University", "GAU" }
            };

            myHashTable.Remove("TellsJokes");
            myHashTable.Remove("lName");

            Console.WriteLine($"Elements : {myHashTable.Count}");
            Console.WriteLine("Keys | Values");
            foreach (DictionaryEntry pair in myHashTable)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }

        /// <summary>
        /// შეკუმშავს M10 მასივს მისი ნულოვანი ელემენტების წაშლის გზით.
        /// </summary>
        public static void task_14_1_10()
        {
            Console.WriteLine("\n*** Task 14.1.10 ***");
            int[] myNums = new int[] { 0, 1, 9, 27, -6, 0, 0, 33, 4 };
            ArrayList myArray = new ArrayList(myNums);
            //Removing
            for (int i = 0; i < myArray.Count; i++)
            {
                if ((int)myArray[i] == 0) {
                    myArray.RemoveAt(i);
                    i--;
                } 
            }

            //Printing
            Console.Write($"AllNums[{myNums.Length}] = {{ ");
            foreach (var item in myNums){ Console.Write($"{item} "); }
            Console.WriteLine("}");
            Console.Write($"Removed[{myArray.Count}] = {{ ");
            foreach (var item in myArray) { Console.Write($"{item} "); }
            Console.WriteLine("}");
        }

        
        /// <summary>
        ///შექმენით 10-ელემენტიანი რიგი. წაიკითხეთ და ეკრანზე გამოიტანეთ რიგის I ელემენტის
        ///მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ რიგში არსებული ელემენტების
        ///რაოდენობა და რიგის ყველა ელემენტი.რიგიდან ყველა ელემენტი წაშალეთ. */
        /// </summary>
        public static void task_14_2_1()
        {
            Console.WriteLine("\n*** Task 14.2.1 ***");
            Queue myQueue = new Queue();
            for (int i = 0; i < 10; i++)
            {
                myQueue.Enqueue($"Number{i}");
            }
            Console.WriteLine($"Peek[{myQueue.Count}] : {myQueue.Peek()}");
            Console.Write($"Queue[{myQueue.Count}] = {{ ");
            foreach (var item in myQueue)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");
            myQueue.Clear();
            Console.WriteLine($"Size(After cleared) = {myQueue.Count}");

        }

        
        /// <summary>
        /// შექმენით 10-ელემენტიანი სტეკი. წაიკითხეთ და ეკრანზე გამოიტანეთ სტეკის
        ///უკანასკნელი ელემენტის მნიშვნელობა მისი წაშლის გარეშე.ეკრანზე გამოიტანეთ სტეკში
        ///არსებული ელემენტების რაოდენობა და სტეკის ყველა ელემენტი.სტეკიდან ყველა ელემენტი წაშალეთ.
        /// </summary>
        public static void task_14_2_4()
        {
            Console.WriteLine("\n*** Task 14.2.4 ***");
            Stack myStack = new Stack();
            for (int i = 0; i < 10; i++)
            {
                myStack.Push($"Num{i}");
            }
            Console.WriteLine($"Last = {myStack.Peek()}");
            Console.Write($"Stack[{myStack.Count}] = {{ ");
            foreach (var item in myStack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");
            myStack.Clear();
            Console.WriteLine($"Size(Cleared) = {myStack.Count}");

        }
        
        
        static void Main(string[] args)
        {
            task_14_1_2();
            task_14_1_6();
            task_14_1_10();
            task_14_2_1();
            task_14_2_4();

            Console.ReadKey();
        }
    }
}
