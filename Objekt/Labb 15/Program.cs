using System;

namespace Labb_15
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ange antal sidor på tärningen:");
            int antalSidor = int.Parse(Console.ReadLine());
            Tärning tärning = new Tärning(antalSidor);
            int sida = tärning.Kasta();
            System.Console.WriteLine($"Du slog tärningen med {antalSidor} sidor och fick resultatet {sida}");
        }
    }
}
