using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        public class Student
        {
            #region Student Vars
            private string fname;
            private string lname;
            private string id;
            private bool stud_status;
            private Dictionary<string, short> scores;
            private string faculty;
            private DateTime birth_date;
            #endregion

            #region Props
            public string FirstName { get => fname; set { fname = value; } }
            public string LastName { get => lname; set { lname = value; } }
            public string ID { get => id; }
            public bool Status { get => stud_status; set { stud_status = value; } }
            public Dictionary<string, short> Scores { get => scores; set { scores = value; } }
            public string Faculty { get => faculty; set { faculty = value; } }
            public DateTime BirthDate { get => birth_date; set { birth_date = value; } }
            #endregion

            #region Constructors
            public Student(string id)
            {
                this.id = id;
            }

            public Student(string id, string fname, string lname, DateTime bdate)
                : this(id)
            {
                this.fname = fname;
                this.lname = lname;
                this.birth_date = bdate;
            }

            public Student(string id, string fname, string lname, DateTime bdate, bool sStatus, string faculty, Dictionary<string, short> scores)
                : this(id, fname, lname, bdate)
            {
                this.stud_status = sStatus;
                this.faculty = faculty;
                this.scores = scores;
            }
            #endregion

            #region Methods
            public override string ToString()
                => $"ID : {id}\nFirst Name : {fname}\nLast Name : {lname}\n";

            public string GetScores()
            { 
               if(scores != null)
               {
                    return scores.Select(sc => $"{sc.Key} : {sc.Value}").Aggregate((a, b) => $"{a}\n{b}");
               }
                return "";
            }
            
            
            public string Info()
                => $"{this}Birth Date : {birth_date}\nStudent Status : {stud_status}\nFaculty : {faculty}\n\nScores -> \n{GetScores()}\n\n******************\n";
         
            #endregion
        }

        static void Main(string[] args)
        {

            #region Loading
            var myStudents = XElement.Load("Students.xml");
            #endregion

            #region Fetching Students
            List<Student> fetchedStudents = myStudents.Descendants("student")
                .Select(st => new Student(st.Element("id").Value)
                {
                    FirstName = st.Element("fname").Value,
                    LastName = st.Element("lname").Value,
                    Status = st.Element("status").Value.Equals("Active"),
                    Faculty = st.Element("faculty").Value,
                    BirthDate = DateTime.Parse(st.Element("birth").Value),
                    Scores = st.Descendants("score").ToDictionary(
                        node => node.Attribute("subject").Value,
                        node =>  Convert.ToInt16(node.Value))
                }).ToList();
            

            foreach (Student student in fetchedStudents)
            {
                Console.WriteLine(student.Info());
            }
            #endregion

            //Divider
            Console.WriteLine("\n<----------------->\n");

            #region Filtering XML
            var filteredStudents = XElement.Load("Students.xml");
            List<Student> myFilteredStudents = filteredStudents.Descendants("student")
                .Where(node => node.Element("faculty").Value.Equals("Polite"))
                .Select(stud => new Student(stud.Element("id").Value) {
                    Faculty = stud.Element("faculty").Value,
                    FirstName = stud.Element("fname").Value,
                    LastName = stud.Element("lname").Value,
                    BirthDate = Convert.ToDateTime(stud.Element("birth").Value)
                }).OrderByDescending(chosen => chosen.BirthDate).ToList();

            foreach (Student myStudent in myFilteredStudents)
            {
                Console.WriteLine($"{myStudent.Info()}");
            }
            #endregion

            Console.ReadLine();

        }
    }
}
