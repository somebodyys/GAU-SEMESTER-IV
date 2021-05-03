using System;
using System.ComponentModel;
namespace ClassWork10
{
    class Program
    {
        public delegate void delegateName(string message);

        public delegate int delegateNumber();

        //public delegate void Action();

        public delegate Parent covarianceHandler();

        public delegate void contraHandler(Child myChild);

        public event delegateName onMessageEvent;
        static void Main(string[] args)
        {

            #region Events
            
            #endregion
            /*
            #region MyDefinedDelegates
            //delegateName myDel = new delegateName(Display);
            delegateName myDel = Email;
            myDel += Mobile;
            myDel += Fax;

            //myDel("Hello World!");
            myDel.Invoke("Hello World!");

            myDel -= Mobile;
            myDel("Removed Fax!");

            
            delegateNumber myNumDel = RandNum;
            myNumDel += Fee;

            myNumDel();
            foreach (delegateNumber func in myNumDel.GetInvocationList())
            {
                Console.WriteLine(func());
            }

            #endregion


            
            #region BuildInDelegates
            Action myAction = Welcome;
            Action<string> myGenericAction = Email;

            myAction += Exam;
            myAction();

            myGenericAction("Hello From Generic!");

            
            Func<int, int, int> myFunc = Add;
            myFunc += Mult;
            myFunc += Max;

           
            foreach (Func<int, int, int> item in myFunc.GetInvocationList())
            {
                Console.WriteLine(item(5,9));
            }
            
            Predicate<int> myPredicate = IsOdd;
            myPredicate += IsEven;

            foreach (Predicate<int> item in myPredicate.GetInvocationList())
            {
                Console.WriteLine(item(15));
            }

            Predicate<string> myStringPredicate = IsEmptyStr;
            Console.WriteLine(myStringPredicate(""));
            #endregion
            

            covarianceHandler myCovHand = CovarianceMethod;
            myCovHand();

            contraHandler myContrHand = ContraMethod;
            myContrHand(new Child());
            */

            Room myRoom = new Room();
            myRoom.PropertyChanged += OnAlarm;

            myRoom.Temp = 60;
            

            /*
            Action a = delegate ()
            {
                Console.WriteLine("I am anonym!");
            };

            Func<int, int> f = delegate (int num)
            {
                 Console.WriteLine($"Inside Func");
                 return num;
            };
            */

            Action a = () => Console.WriteLine("I am anonym!");

            Func<int, int> f = (num) => num * 2;
            f += (num) => num*3;
            
           
            a();
            Console.WriteLine(f(5));
            Console.ReadKey();
        }

        public static void OnAlarm(object temp)
        {
            Room myRoom = temp as Room;
            Console.WriteLine($"Tempretarure is {myRoom.Temp}");
        }

        public static void OnAlarm(object sender, EventArgs e)
        {
            Room myRoom = sender as Room;
            RoomData data = e as RoomData;
            Console.WriteLine($"EvenTHandler : Tempretarure is {myRoom.Temp}\nInfo : {data.HotelName}, {data.RoomNumber}");
        }

        public static void OnAlarm(object sender, PropertyChangedEventArgs e)
        {
            Room myRoom = sender as Room;
            //RoomData data = e as RoomData;
            Console.WriteLine($"PropertyChangedEvenTHandler : Tempretarure is {myRoom.Temp}\nInfo : {e.PropertyName}");
        }

        public static void Alarm(int temp)
        {
            Console.WriteLine($"Tempretarure({temp}) too high!");
        }

        public static void ContraMethod(Parent input)
        {
            Child myChild = input as Child;
            Console.WriteLine("ContraMerhod!");
        }

        public static Child CovarianceMethod()
        {
            Console.WriteLine("Convariance Method");
            return new Child();
        }

        public static bool IsOdd(int num)
            => num % 2 == 1;
        public static bool IsEven(int num)
            => num % 2 == 0;

        public static bool IsEmptyStr(string text)
            => text == "";

        public static int Add(int num1, int num2)
            => num1 + num2;
        public static int Mult(int num1, int num2)
            => num1 * num2;

        public static int Max(int num1, int num2)
            => num1 >= num2 ? num1 : num2;

        public static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }

        public static void Exam()
        {
            Console.WriteLine("You failed in exam!");
        }

        public static void Email(string text)
        {
            Console.WriteLine($"Email : {text}");
        }

        public static void Mobile(string text)
        {
            Console.WriteLine($"Mobile : {text}");
        }

        public static void Fax(string text)
        {
            Console.WriteLine($"Fax : {text}");
        }

        public static int RandNum()
        {
            int num = new Random().Next();
            Console.WriteLine($"Rand : {num}");
            return num;
        }

        public static int Fee()
        {
            Console.WriteLine("Fee : 20");
            return 20;
        }
    }
}
