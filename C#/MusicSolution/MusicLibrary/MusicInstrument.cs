using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class MusicInstrument
    {

        #region ClassVars
        protected DateTime manufactureDate;
        protected string manufacturer = "Have No Idea!";
        protected string model;
        protected string type;
        protected string material;
        #endregion

        #region Props
        public DateTime MadeDate {
            get => manufactureDate;
            set => manufactureDate = value;
        }

        public string Model { 
            get => model;
            set => model = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public string Manufacturer
        {
            get => manufacturer;
            set => manufacturer = value;
        }
        #endregion

        public MusicInstrument(string type, string model, DateTime manufactureDate)
        {
            this.model = model;
            this.type = type;
            this.manufactureDate = manufactureDate;
        }
    
        public virtual string GetInstrumentInfo()
        {
            return ($"Type: {type}\nModel:{model}\nManufacture Date:{manufactureDate}\nManufacturer:{manufacturer}");
        }

        public virtual async void Tune()
        {
            Console.WriteLine("Tune Started...");
            for(int i = 0; i <= 5; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine($"{i*20}%");
            }
            Console.WriteLine("General Tune Has Finished!");
        }

    }

    public class TileInstuments : MusicInstrument
    {
        protected int tileCount;
        protected bool pedal;

        #region Props
        public int TileCount { 
            get => tileCount;
            set => tileCount = value; 
        }

        public bool Pedal
        {
            get => pedal;
            set => pedal = value;
        }
        #endregion

        public TileInstuments(string type, string model, DateTime manufactureDate, int tileCount, bool pedal)
            :base(type, model, manufactureDate)
        {
            this.tileCount = tileCount;
            this.pedal = pedal;
        }


        public override string GetInstrumentInfo()
        {
            string tempPedal = pedal ? "Yes" : "No";
            return $"{base.GetInstrumentInfo()}\nTile Count : {tileCount}\nPedal : {tempPedal}";
        }
    }


    public class StringInstruments : MusicInstrument
    {

        protected int stringCount;
        protected string stringType;

        #region Props
        public int StringCount{
            get => stringCount;
            set => stringCount = value;        
        }

        public string StringType
        {
            get => stringType;
            set => stringType = value;
        }

        #endregion

        public StringInstruments(string type, string model, DateTime manufactureDate, int stringCount, string stringType)
            :base(type, model, manufactureDate)
        {
            this.stringCount = stringCount;
            this.stringType = stringType;
        }

        public override string GetInstrumentInfo()
        {
            return $"{base.GetInstrumentInfo()}\nStrings Count:{stringCount}\nString Type:{stringType}";
        }

        public override async void Tune()
        {
            Console.WriteLine("Tune Started...");
            await Task.Delay(1000);
            Console.WriteLine($"Brushing strings...");
            await Task.Delay(1000);
            Console.WriteLine($"Finding Perfect Pitch...");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning Along...");
            Console.WriteLine($"All Strings Are Tuned!!");
        }
    }

    public sealed class Guitar : StringInstruments
    {
        private float weight;
        private bool pickguard;
        private float soundHoleSize;


        #region Props
        public float Weight { 
            get => weight;
            set => weight = value;
        }

        public bool PickGuard
        {
            get => pickguard;
            set => pickguard = value;
        }

        public float SoundHoleSize
        {
            get => soundHoleSize;

            set => soundHoleSize = value;

        }
        #endregion

        public Guitar(string type, string model, DateTime manufactureDate, int stringCount, string stringType, float weight, bool pickguard, float soundHoleSize)
            :base(type, model, manufactureDate, stringCount, stringType)
        {
            this.weight = weight;
            this.pickguard = pickguard;
            this.soundHoleSize = soundHoleSize;
        }


        public override string GetInstrumentInfo()
        {
            string tempPick = pickguard ? "Yes" : "No";
            return $"{base.GetInstrumentInfo()}\nWeight: {weight}\nPickGuard: {tempPick}\nSound Hole Size: {soundHoleSize}";
        }

        public override async void Tune()
        {
            Console.WriteLine("Tune Started...");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning E string");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning B string");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning G string");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning D string");
            await Task.Delay(1000);
            Console.WriteLine($"Tuning A string");
            Console.WriteLine($"Guitar is in Tune Now.");
        }
    }
}
