using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App00
{
    public class Takipci
    {
        public event Action<string> Followed;
        public string Name { get; set; }

        public Takipci(string name)
        {
            Name = name;
        }
        public void Follow(Yazar yazar) {
            Console.WriteLine($"{Name}" + "," + $"{yazar.Name}" + "'ı takibe aldı.");
            
            Followed?.Invoke(yazar.Name);
            yazar.BookPublished += Notify;
        }

        public void Notify(string bookName)
        {
            Console.WriteLine($"{Name}, takip ettiğin yazar yeni bir kitap yayınladı: '{bookName}'");
        }
    }
}
