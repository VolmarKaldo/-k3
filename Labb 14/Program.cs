using System;

namespace Labb_14
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Vad heter boken?");
            string titel = Console.ReadLine();
            System.Console.WriteLine("Vad heter författaren?");
            string författare = Console.ReadLine();
            System.Console.WriteLine("Hur många sidor är det?");
            int antalSidor = int.Parse(Console.ReadLine());

            //Skapa objekt = bok av typen Bok
            Bok bok = new Bok(titel, författare, antalSidor);

            //Skriv ut sammanfattning
            bok.skrivUt();
        }
    }
}
