using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTask_00
{
    public class CargoVehicle
    {
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public byte speed { get; set; }
        public double StartLatitude { get; set; }
        public double StartLongitude { get; set; }

        public event Action<CargoVehicle> SpeedExceeded;

        public CargoVehicle(string plaka, string marka, double startLatitude, double startLongitude)
        {
            Plaka = plaka;
            Marka = marka;
            StartLatitude = startLatitude;
            StartLongitude = startLongitude;
        }

        public byte Speed
        {
            get => speed;
            set
            {
                speed = value;
                if (speed > 110)
                {
                    SpeedExceeded?.Invoke(this); 
                }
            }
        }
    }
}
