using System;
using Newtonsoft.Json;

namespace JsonTest
{
    class Film
    {
        public string Titel;
        public string Årtal;
        public string Regissör;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skapa Json objekt");
            Film avatar = new Film
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron",
            };
            Film legend = new Film
            {
                Titel = "I am legend",
                Årtal = "2008",
                Regissör = "Francis Lawrence",
            };
            Film interstellar = new Film
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Cristopher Nolan",
            };

            //Skriv ut lite JSON
            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            jsonText += JsonConvert.SerializeObject(legend, Formatting.Indented);
            System.Console.WriteLine(jsonText);
        }
    }
}
