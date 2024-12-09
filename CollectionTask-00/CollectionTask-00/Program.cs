namespace CollectionTask_00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "no.txt");

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Dosya yok : " + filePath);
                return;
            }

            SortedDictionary<string, SortedDictionary<string, string>> phoneDirectory = new SortedDictionary<string, SortedDictionary<string, string>>();

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split('|', StringSplitOptions.TrimEntries);
                if (parts.Length != 3) { continue; }

                string name = parts[0];
                string city = parts[1];
                string phoneNumber = parts[2];

                if (!phoneDirectory.ContainsKey(city))
                {
                    phoneDirectory[city] = new SortedDictionary<string, string>();
                }
                phoneDirectory[city][name] = phoneNumber;
            }

            foreach (var city in phoneDirectory.OrderBy(c => c.Key))
            {
                Console.WriteLine(city.Key + " :");

                foreach (var person in city.Value.OrderBy(p => p.Key))
                {
                    Console.WriteLine("\t" + person.Key + "\t - \t " + person.Value);
                }
                Console.WriteLine();
            }
        }
    }
}

//Not : test için isim eklemesi yapılmıştır.
