using System;
using System.Collections.Generic;
namespace Labb_13
{
    class Namn
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public int Längd { get; set; }
        public int Vikt { get; set; }


        public void HeltNamn()
        {
            System.Console.WriteLine(Förnamn + Efternamn);
        }
        public void BMI()
        {
            System.Console.WriteLine($"BMI = {Vikt / Längd * Längd} ");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Namn> lista = new List<Namn>();
            Namn person = new Namn();
            Console.WriteLine("Skriv in ditt förnamn");
            person.Förnamn = Console.ReadLine();
            System.Console.WriteLine("Skriv in din längd");
            person.Längd = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Skriv in din vikt");
            person.Vikt = int.Parse(Console.ReadLine());
            



        }
    }
}
