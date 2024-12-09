namespace Lab_04;

using System;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {

        List<string> semboller = new List<string> { "Maca", "Karo", "Kupa", "Sinek" };
        List<string> sayilar = new List<string> { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        List<string> deste = new List<string>();
        DesteOlustur(semboller, sayilar, deste);
        
    }

    static void DesteOlustur(List<string> _deste, List<string> _semboller , List<string> _sayilar)
    {
        foreach (var simge in _semboller)
        {
            foreach (var numara in _sayilar)
            {
                _deste.Add(numara + simge);
            }
        }
    }

    static void Yazdir(List<string> deste)
    {
        foreach (var kart in deste)
        {
            Console.WriteLine(kart);
        }
    }

    public static List<string> RandomKartSec(List<string> _semboller , List<string> _sayilar)
    {
        List<string> kartlar = new List<string>();
        foreach (var i in _semboller)
        {
            foreach (var j in _sayilar)
            {
                kartlar.Add(i + " " + j);
            }
        }

        Random random = new Random();
        for (int i = 0; i < kartlar.Count; i++)
        {
            int randomIndex = random.Next(kartlar.Count);
            var temp = kartlar[randomIndex];
            kartlar[i] = kartlar[randomIndex];
            kartlar[randomIndex] = temp;
        }

        return kartlar;
    }
    public static String IndexleKartGetir(List<string> Simgeler, List<string> Sayilar, int index)
    {
        string kart = "";

        int deckIndex = index / 13;
        int cardIndex = index != 13 ? (index % 13) - 1 : 12;

        kart += Simgeler[deckIndex];
        kart += " " + Sayilar[cardIndex];

        return kart;
    }

    public

}

