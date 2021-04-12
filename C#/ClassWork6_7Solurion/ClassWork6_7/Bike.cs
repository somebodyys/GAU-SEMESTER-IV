using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6_7
{
    class Bike : ITransport
    {
        private bool light;
        private int gears;
        private string name;
        private string maker;
        private int year;
        private int wheels = 2;
        private ConsoleColor bikeColor;

        public Bike(string name, string maker, int year, int gears, bool light, ConsoleColor color)
        {
            this.name = name;
            this.maker = maker;
            this.year = year;
            this.gears = gears;
            this.light = light;
            this.bikeColor = color;
        }
        
        public int Wheels { get => wheels; }
        public string LightStatus { get => light ? "Yes" : "No"; }

        public ConsoleColor Color { 
            get => bikeColor; 
            set => bikeColor = value; 
        }

        public string Info()
            => $"Name: {name}\nMaker: {maker}\nYear: {year}\nColor: {bikeColor}\n" +
            $"Wheels: {Wheels}\nLight: {LightStatus}\nGears: {gears}";
    }
}
