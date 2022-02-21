using System;

namespace Labb_18
{
    public class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        public string Name { get; set; }

        public Creature(string name)
        {
            Name = name;
        }
    }
    public class Knight : Creature
    {
        public string Weapon { get; set; }

        public Knight(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }
        public void Attack()
        {
            System.Console.WriteLine($"The knight{Name} attacks with their {Weapon}");
        }
    }
    public class Dragon : Creature
    {
        public string Color { get; set; }
        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }
        public void Attack()
        {
            System.Console.WriteLine($"The {Color} dragon {Name} breathes fire");
        }
    }
}