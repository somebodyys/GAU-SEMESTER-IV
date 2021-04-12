using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassWork6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport car1 = new Car("Tesla", ConsoleColor.White, "Tesla Corp", 2021);
            ITransport bike1 = new Bike("Desna", "CCRK", 1992, 5, false, ConsoleColor.Blue);
            Student student1 = new Student("01022054489","Tornike", "Kikacheishvili", 95, 99, "GAU", new DateTime(1997, 10, 27), 4.3m);
            Student student2 = new Student("01055036658","Dato", "Datashvili", 98, 86, "GAU", new DateTime(1995, 12, 2), 3.2m);
            Student student3 = new Student("02055498748","Tamta", "Giorgobashvili", 98, 86, "GAU", new DateTime(1995, 12, 2), 1.9m);
            //Console.WriteLine(car1.Info());
            //Console.WriteLine();
            //Console.WriteLine(bike1.Info());
            //Console.WriteLine();
            //Console.WriteLine($"{student1}\nMath: {((IMath)student1).Points}\nEnlish: {((IEnglish)student1).Points}");

            Student resul1 = student1 + student2;
            Student result2 = student1 - student2;
            List<Student> myStudents = new List<Student>() { student1, student2, student3};
            foreach (var item in myStudents)
            {
                Console.Write($"{item.Stipendy} ");
            }

            myStudents.Sort(new SortByStipendy());
            Console.WriteLine();
            foreach (var item in myStudents)
            {
                Console.Write($"{item.Stipendy} ");
            }
            Console.WriteLine();
            Console.WriteLine("Tornike".GetHashCode());
            Console.WriteLine(student1.GetHashCode());
            

            /*
            foreach (var item in student1)
            {
                Console.WriteLine(item);
            }
            

            while (student1.MoveNext())
            {
                float temp = (float)student1.Current;
                Console.WriteLine(temp);
            }
            */

            /*
            if(student1 > student2)
            {
                Console.WriteLine($"{student1.FirstName}:{student1.GPA} GPA is Greater Than {student2.FirstName}:{student2.GPA}");
            }
            else if(student1 == student2)
            {
                Console.WriteLine($"{student1.FirstName} GPA are the same {student2.FirstName}:{student2.GPA}");
            }
            else
            {
                Console.WriteLine($"{student2.FirstName}:{student2.GPA} GPA is Greater Than {student1.FirstName}:{student1.GPA}");
            }
            
            Console.WriteLine(student1.Age);
            Console.WriteLine((student1++).Age);
            Console.WriteLine();
            Console.WriteLine(student2.Age);
            Console.WriteLine((student2--).Age);
            Console.WriteLine(student1.Stipendy);
            Console.WriteLine(student2.Stipendy);
            Console.WriteLine();
            Console.WriteLine($"+ : {resul1.Stipendy}\n- : {result2.Stipendy}");
            */



            Console.ReadKey();
        }
    }
}
