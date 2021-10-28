using System.Security.AccessControl;
using System;
using System.Collections.Generics;

namespace Listor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] städer = {"Berlin", "Paris", "London"};
            
            string[] frukter = new string[3];
            frukter [0] = "Äpple";
            frukter [1] = "Apelsin";
            frukter [2] = "Banan";
        
            List<string> namnen = new list<string>(){"Miriam", "Teo", "Axel"};

            List<string> bären = new List<string>();
            bären.Add("Blåbär");
            bären.Add("Lingon");
            bären.Add("Hallon");
            bären.Add("Björnbär");
            bären.Add("Kråkbär");

            for (int i = 0; i < frukter.Length; i++)
            {
                System.Console.WriteLine(frukter[i]);
            }
            foreach (var frukt in frukter)
            {
                System.Console.WriteLine(frukt);
            }

            for (int i = 0; i < bären.count; i++)
            {
                System.Console.WriteLine(bären[i]);
            }

            foreach (var stad in städer)
            {
               if (stad=="Paris")
               {
                   System.Console.WriteLine("Paris finns i arrayen"); 
               } 
            }
            if (bären.Contains("Blåbär"))
            {
                System.Console.WriteLine("Blåbär finns i listan");
            }

            bären.Remove("Hallon");
            bären.RemoveAt(0);
            bären.Insert(1, "Aroniabär");
        }
    }
}
