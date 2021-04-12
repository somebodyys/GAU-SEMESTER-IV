using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassWork6_7
{
    public class Student : Person, IEnglish, IMath, IEnumerable, IEnumerator, IComparable, IEquatable<Student>
    {
        private int englishScore;
        private int mathScore;
        private string university;
        private decimal stipendy;
        private decimal gpa;
        private float[] scores = new float[5] { 68.5f, 77.0f, 85.3f, 78.1f, 93.6f};
        private int index = -1;

        public Student(){}

        public Student(string pn,string fName, string lName, int engScore, int mathScore, string university, DateTime birthDate, decimal gpa)
        {
            FirstName = fName;
            LastName = lName;
            BirthDate = birthDate;
            Pn = pn;
            this.englishScore = engScore;
            this.mathScore = mathScore;
            this.university = university;
            this.gpa = gpa;
            this.stipendy = gpa < 2.5m ? 0 : gpa < 3.5m ? 300 : 600;
        }
        public string University { get => university; }
        public int Age { get => DateTime.Now.Year - BirthDate.Year;  }
        public decimal Stipendy { get => stipendy; set => stipendy = value; }
        public decimal GPA { get => gpa; }
        int IEnglish.Points { get => englishScore; }
        int IMath.Points { get => mathScore; }
        

       

        public static Student operator +(Student s1, Student s2)
            => new Student { stipendy = s1.Stipendy + s2.Stipendy };

        public static Student operator -(Student s1, Student s2)
            => new Student { stipendy = s1.Stipendy - s2.Stipendy };

        public static Student operator ++(Student s1)
        {
            s1.BirthDate = s1.BirthDate.AddYears(1);
            return s1;
        }
    

        public static Student operator --(Student s1)
        {
            s1.BirthDate = s1.BirthDate.AddYears(-1);
            return s1;
        }


        
        public static bool operator >(Student s1, Student s2)
            => s1.gpa > s2.gpa;
        public static bool operator <(Student s1, Student s2)
            => s1.gpa < s2.gpa;

        public static bool operator >=(Student s1, Student s2)
            => s1.gpa >= s2.gpa;
        public static bool operator <=(Student s1, Student s2)
            => s1.gpa <= s2.gpa;

        public static bool operator ==(Student s1, Student s2)
            => s1.gpa == s2.gpa;
        public static bool operator !=(Student s1, Student s2)
            => s1.gpa != s2.gpa;
        
        /*
        public static bool operator ==(Student s1, Student s2)
            => s1.University.Equals(s2.University);
        public static bool operator !=(Student s1, Student s2)
            => !s1.University.Equals(s2.University);
        */
    
        public override string ToString()
            => $"{FirstName} {LastName} studies in {University} University!";

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < scores.Length; i++)
            {
                yield return scores[i];
            }
        }

        public bool MoveNext()
        {
            return (++index < scores.Length);
        }

        public void Reset()
        {
            index = -1;
        }

        public int CompareTo(object obj)
        {
            Student stud = (Student)obj;
            if (this == stud) return 0;
            if (this < stud) return -1;
            return 1; 
        }

        public override bool Equals(object obj)
        {
            Student other = (Student)obj;
            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            return $"{this.pn}".GetHashCode();
        }

        
        public bool Equals(Student other)
        {
            return this.pn.Equals(other.pn);
        }

        public object Current => scores[index];
    }  
}
