using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App00
{
    public class Yazar
    {
        public event Action<string> BookPublished;

        public string Name { get; set; }

        public Yazar(string name)
        {
            Name = name;
        }
        public void PublishBook(string bookName)
        {
            Console.WriteLine($"{Name} '{bookName}' kitabını yayınladı!");


            BookPublished?.Invoke(bookName);
        }
    }
}
