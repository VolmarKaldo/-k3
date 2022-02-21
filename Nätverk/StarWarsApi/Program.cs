using System;
using System.Text.Json;
using RestSharp;
using System.Collections.Generic;

namespace StarWarsApi
{
    class Karaktär
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    class Karaktärer
    {
        public int count { get; set; }

        public string next { get; set; }
        public List<Karaktär> results { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://swapi.dev/api";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            Karaktärer lista = new Karaktärer();
            lista = JsonSerializer.Deserialize<Karaktärer>(response.Content);

            if (lista != null)
            {
                foreach (var karaktär in lista.results)
                {
                    System.Console.WriteLine(karaktär.name);
                }

            }
            else
            {
                System.Console.WriteLine("Felaktikt svar");
            }


        }
    }
}
