using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6_7
{
    class Car : ITransport
    {
        private int wheels = 4;
        private ConsoleColor carColor;
        private string name;
        private string maker;
        private int year;

        public Car(string name, ConsoleColor color, string maker, int year)
        {
            this.name = name;
            this.carColor = color;
            this.maker = maker;
            this.year = year;
        }

        public int Wheels { get => wheels; }

        public ConsoleColor Color
        {
            get => carColor;
            set => carColor = value;
        }

        public string Info()
            => $"Name: {name}\nMaker: {maker}\nYear: {year}\nColor: {carColor}\nWheels: {Wheels}";

    }
}
