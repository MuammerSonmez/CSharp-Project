namespace EventTask_00
{
    internal class Program
    {
        static Random rnd = new Random();

        public static void kargo_araci_SpeedExceeded(CargoVehicle vehicle)
        {
            double enlem = vehicle.StartLatitude;
            double boylam = vehicle.StartLongitude;

            // enlem ve boy atışı temsilidir!!!
            double enlemArtisi = vehicle.Speed / 100.0;
            double boylamArtisi = vehicle.Speed / 50.0;

            enlem += enlemArtisi;
            boylam += boylamArtisi;
            Console.WriteLine(vehicle.Plaka + " plakalı " + vehicle.Marka + " marka kargo aracı hız limitini aştı.");
            Console.WriteLine("Aracın hız limitini aştığı konum : " + enlem.ToString("0.00") + " enlem ve " + boylam.ToString("0.00") + "° boylam");
            Console.WriteLine(DateTime.Now + " anında aracın hızı = " + vehicle.Speed + " olarak ölçüldü");
            Console.WriteLine("\n\n");


            vehicle.StartLatitude = enlem;
            vehicle.StartLongitude = boylam;
        }

        static void Main(string[] args)
        {
            CargoVehicle kargo_araci1 = new CargoVehicle("42AUE055", "OPEL", rnd.NextDouble() * 90, rnd.NextDouble() * 180);
            CargoVehicle kargo_araci2 = new CargoVehicle("42LB124", "FIAT", rnd.NextDouble() * 90, rnd.NextDouble() * 180);


            kargo_araci1.SpeedExceeded += kargo_araci_SpeedExceeded;
            kargo_araci2.SpeedExceeded += kargo_araci_SpeedExceeded;

            for (byte i = 80; i < 130; i += 5)
            {
                kargo_araci1.Speed = i;
                kargo_araci2.Speed = (byte)(i + 8);

                Console.WriteLine($"{kargo_araci1.Plaka} plakalı aracın hızı = {kargo_araci1.Speed}");
                Console.WriteLine($"{kargo_araci2.Plaka} plakalı aracın hızı = {kargo_araci2.Speed}\n");
                Thread.Sleep(1000);
            }
        }
    }
}
