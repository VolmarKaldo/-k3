using System;

namespace Repetition
{
    class PersonInkomst
    {
        public string Namn = "";
        public int Lön = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registrera löner");

            PersonInkomst objekt = new PersonInkomst();
            while (true)
            {
                System.Console.WriteLine("Ange ditt namn:");
                objekt.Namn = Console.ReadLine();
                System.Console.WriteLine("Ange din månadslön");
                objekt.Lön = ReadInt();
            }
        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
