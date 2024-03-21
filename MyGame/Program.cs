using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy loki = new Enemy("Loki");
            loki.SetName("   Grindalokki   ");

            Console.WriteLine
            ($"Name is {loki.GetName()} and Hp is {loki.GetHealth()}");
        }
    }
}
