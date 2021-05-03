using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClassWork10
{

    public class RoomData : EventArgs
    {
        public string HotelName { get; set; }
        public int RoomNumber { get; set; }
    }



    public class Room : INotifyPropertyChanged
    {
        private int temp;
        public event PropertyChangedEventHandler PropertyChanged;

        public int Temp { 
            get => temp; 

            set {
                temp = value;
                OnPropertyChanged("temp");
            } 
        }

        private void OnPropertyChanged(string text)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(text));
            }
        }

    }
}
