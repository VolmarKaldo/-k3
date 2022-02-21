using System;
using System.Text.Json;
using RestSharp;

namespace PokeApi
{
    class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }
    }
    class Pokemons
    {
        public int count { get; set; }

        public string next { get; set; }
        public List<Pokemon> results { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hämta alla Pokémon");

            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            Pokemons lista = new Pokemons();
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);


        }
    }
}
