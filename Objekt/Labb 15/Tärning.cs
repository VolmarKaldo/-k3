using System.Security.Cryptography;
using System;

namespace Labb_15
{
    public class Tärning
    {
        public int AntalSidor { get; set; }

        public Tärning(int _antalSidor)
        {
            AntalSidor = _antalSidor;
        }

        public int Kasta()
        {
            Random r = new Random();
            int sida = r.Next(1, AntalSidor);
            return sida;
        }
    }
}