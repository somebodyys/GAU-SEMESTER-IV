using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task7_5_1
{
    abstract class Figure
    {
        abstract public float Perimeter();
    }

    class Square:Figure
    {
        private float a;
        private float b;
        private float c;
        private float d;

        public Square(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override float Perimeter()
            => a + b + c + d;
    }


    class Triangle : Figure
    {
        private float a;
        private float b;
        private float c;

        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override float Perimeter()
            => a + b + c;
    }
}

namespace Task7_5_2
{
    abstract class Train
    {
        abstract public float Calculate();
    }

    class FirstChild : Train
    {
        private float speed;
        private float time;

        public FirstChild(float speed, float time)
        {
            this.speed = speed;
            this.time = time;
        }

        public override float Calculate()
            => speed * time;
    }

    class SecondChild : Train
    {
        private float energyLoss;
        private float length;

        public SecondChild(float energyLoss, float length)
        {
            this.energyLoss = energyLoss;
            this.length = length;
        }

        public override float Calculate()
            => energyLoss * length;
    }
}

namespace Task7_5_3
{
    abstract class TV
    {
        abstract public float Method();
    }

    class Child:TV
    {
        private float consumption;
        private float workTime;

        public Child(float consumption, float workTime)
        {
            this.workTime = workTime;
            this.consumption = consumption;
        }

        public override float Method()
            => consumption * workTime;
    }
}

namespace Task7_5_4
{
    abstract class Employee
    {
        abstract public float Method();
    }

    class Child : Employee
    {
        private float salary;

        public Child(float salary)
        {
            this.salary = salary;
        }

        public override float Method()
            => salary * 12;

    }
}
namespace ClassWork4
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
