using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Biluthyrning
{

    class Program
    {
        static List<Avtal> listaAvtal = new List<Avtal>();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till biluthyrningen!");

            string svar = "j";
            while (svar == "j")
            {
                Avtal avtal = new Avtal();

                listaAvtal.Add(avtal);

                System.Console.WriteLine("Vänligen ange ditt personnummer");
                avtal.PersonNr = Console.ReadLine();

                System.Console.WriteLine("Ange bilens registreringsnummer");
                avtal.RegNr = Console.ReadLine();
                System.Console.WriteLine("Ange antal km");
                avtal.Km = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Ange hur länge du vill hyra bilen (i hela dygn)");
                avtal.Tidsram = int.Parse(Console.ReadLine());

                System.Console.WriteLine($"Totala hyran blir {avtal.RäknaKostnad()}:-");
                System.Console.WriteLine($"Återlämningsdatumet är {avtal.RäknaInlämningsdatum()}   ");
            }
        }
    }
    class Avtal
    {
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string PersonNr { get; set; }

        IDictionary<string, int> bilar = new Dictionary<string, int>{
        {"ABC123", 500},
        {"DEF123", 400},
        {"GHI123", 199},
        };

        public bool finnsRegNr()
        {
            if (bilar.ContainsKey(RegNr))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RäknaKostnad()
        {
            //System.Console.WriteLine(bilar["ABC123"]);
            Kostnad = bilar[RegNr] * Tidsram + Km * 2;
            return Kostnad;
        }
        public String RäknaInlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd/mm-yy");
        }
    }
    class Kund
    {
        public string Personnr { get; set; }
        public string Fnamn { get; set; }
        public string Enamn { get; set; }
        public string Mobil { get; set; }

    }
}