using System;

namespace IntroArv
{
    class Person
    {
        public string Namn { get; set; }
        public string Mobil { get; set; }

        public Person(string namn, string mobil)
        {
            Namn = namn;
            Mobil = mobil;
        }
        public void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, mobil: {Mobil}");
        }
    }
    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Program { get; set; }

        public Student(string n, string m, string årskurs, string program) : base(n, m)
        {
            Årskurs = årskurs;
            Program = program;
        }

        public void VisaStudentInfo()
        {
            Console.WriteLine($"Namn: {Namn}, mobil: {Mobil}, Årskurs: {Årskurs}, Program: {Program}");

        }
    }
}