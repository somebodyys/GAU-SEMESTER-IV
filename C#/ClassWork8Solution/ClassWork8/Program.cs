using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassWork8
{
    
    class Program
    {
        static void Main(string[] args)
        {


            #region ClassicArray
            int[] myNums = new int[] { 34, 91, 55, 6 };

            Console.Write("\nmyNums - { ");
            for (int i = 0; i < myNums.Length; i++)
            {
                Console.Write($"{myNums[i]} ");
            }
            Console.Write("}");
            #endregion

            #region ListInit
            List<string> myList = new List<string>();
            myList.Add("Dato");
            myList.Add("Gia");
            myList.Add("Vaja");
            myList.AddRange(new List<string> { "Giorgi", "Ana", "Genadi" });

            Console.Write("myList - { ");
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
            #endregion

            #region ArrayListInit
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(5);
            myArrayList.Add("Tornike");
            myArrayList.AddRange(new ArrayList() { true, "Gia", 3.25f });

            Console.Write("\nmyArrayList(foreach) - { ");
            foreach (var item in myArrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");

            myArrayList.Remove(5);
            myArrayList.RemoveAt(0);
            //myArrayList.Clear();
            myArrayList.Capacity = 16;
            Console.WriteLine($"\nCapacity = {myArrayList.Capacity}");
            Console.Write("\nmyArrayList(for) - { ");
            for (int i = 0; i < myArrayList.Count; i++)
            {
                Console.Write($"{myArrayList[i]} ");
            }
            Console.Write("}");
            Console.WriteLine($"\n{myArrayList.Contains("Tornike")}");
            #endregion

            #region CloneArray
            ArrayList cloneArrayList = myArrayList.Clone() as ArrayList;
            Console.Write("\ncloneArrayList(foreach) - { ");
            foreach (var item in cloneArrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
            #endregion

            #region HashTable
            Hashtable myHashTable = new Hashtable();

            myHashTable.Add("name", "Tornike");
            myHashTable.Add("age", 23);
            myHashTable.Add("activeStudent", true);
            Console.WriteLine($"\nStarting Hash Table :");
            foreach (DictionaryEntry item in myHashTable)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            /*
            Console.WriteLine($"\nKeys - {myHashTable.Keys}");
            Console.WriteLine($"Student Name : {myHashTable["name"]}");
            Console.WriteLine($"If Containts key : {myHashTable.ContainsKey("gender")}");
            Console.WriteLine($"if Contains value : {myHashTable.ContainsValue("Tornike")}");
            */

            myHashTable.Remove("age");

            Console.WriteLine($"\nSecond Hash Taabe :");
            foreach (DictionaryEntry item in myHashTable)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            Console.Write("\nKeys {");
            foreach (var item in myHashTable.Keys)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");

            Console.Write("\nValues {");
            foreach (var item in myHashTable.Values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("}");

            Console.WriteLine($"Count(size) : {myHashTable.Count}");
            #endregion

            #region Queue
            Queue myQueue = new Queue();

            myQueue.Enqueue("Mon");
            myQueue.Enqueue("Tu");
            myQueue.Enqueue("We");
            myQueue.Enqueue("Th");
            myQueue.Enqueue("Fa");
            myQueue.Enqueue("Sa");
            myQueue.Enqueue("Su");

            Console.WriteLine($"\nSize : {myQueue.Count}");
            Console.WriteLine($"Dequeue : {myQueue.Dequeue()}");
            Console.WriteLine($"Size : {myQueue.Count}");
            Console.WriteLine($"Pick : {myQueue.Peek()}");
            Console.WriteLine($"Size : {myQueue.Count}");

            Console.Write("Days { ");
            foreach (var day in myQueue)
            {
                Console.Write($"{day} ");
            }
            Console.Write("}");

            object[] castedArray = myQueue.ToArray();
            Console.Write("\nConverted To array : { ");
            foreach (var item in castedArray)
            {
                Console.Write($"{item} ");
            }
            Console.Write("}");
            #endregion

            #region Stack
            Stack myStack = new Stack();
            myStack.Push("Gia");
            myStack.Push("Manana");
            myStack.Push("Temuri");
            myStack.Push("Gela");
            myStack.Push("Mariami");
            myStack.Push("Kako");
            myStack.Push("Vasili");

            Console.Write(myStack.Count);
            Console.WriteLine($"\n\nPoped : { myStack.Pop() }");
            Console.WriteLine($"Peeked : {myStack.Peek() }");
            #endregion

            #region Generics
            
            Stack<Student> myStudents = new Stack<Student>();

            myStudents.Push(new Student() { FullName = "Tornike", StudID = "12256478"});
            myStudents.Push(new Student() { FullName = "Gia", StudID = "78945" });
            myStudents.Push(new Student() { FullName = "Gela", StudID = "51686" });

            Console.WriteLine($"Poped : {myStudents.Pop()}");
            Console.WriteLine($"Peek : {myStudents.Peek()}");

            Dictionary<int, Student> studentDic = new Dictionary<int, Student>();
            studentDic.Add(1, new Student() { FullName = "Tornike", StudID = "12256478" });
            studentDic.Add(3, new Student() { FullName = "Gela", StudID = "51686" });

            Console.WriteLine($"\nStud :{studentDic[1].FullName} {studentDic[1].StudID}");

            Console.Write("Studs(foreach) : {");
            foreach (KeyValuePair<int, Student> stud in studentDic)
            {
                Console.Write($"({stud.Key} -> {stud.Value.FullName}) ");
            }
            Console.WriteLine("}");
            #endregion

            #region SortedList
            SortedList<int, string> mySortedList = new SortedList<int, string>();

            mySortedList.Add(9, "Abraam");
            mySortedList.Add(11, "Zezva");

            foreach (KeyValuePair<int, string> item in mySortedList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            #endregion

            #region LinkedList
            LinkedList<string> myLinkedList = new LinkedList<string>();
            
            #endregion


            Console.ReadKey();
        }
    }
}
