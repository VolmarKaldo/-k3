using System.Net;
using System.Security.Cryptography;
using System;
using System.Text.Json;
using RestSharp;

namespace ChuckNorrisApi
{
    class Joke
    {
        public string icon_url { get; set; }
        public string value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string url = "https://api.chucknorris.io/jokes/random";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            Joke skämtet = new Joke();
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);
        }
    }
}
