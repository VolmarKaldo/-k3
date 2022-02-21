using System;

namespace IntroArv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Volmar", "123456789");
            /* Console.Write("Vad heter du? ");
            person.Namn = Console.ReadLine();
            Console.Write("Ange din mobil: ");
            person.Mobil = Console.ReadLine();
            person.VisaInfo(); */

            // Vi skapar en elev
            Student elev = new Student("Volmar", "1313123123", "3", "Teknik");

            /*             Console.Write("Vad heter du? ");
                        elev.Namn = Console.ReadLine();
                        Console.Write("Ange din mobil: ");
                        elev.Mobil = Console.ReadLine();
                        Console.Write("Vilken årskurs går du i?");
                        elev.Årskurs = Console.ReadLine();
                        Console.Write("Vilket program går du på?");
                        elev.Program = Console.ReadLine(); */
            elev.VisaInfo();
            elev.VisaStudentInfo();
        }
    }
}
