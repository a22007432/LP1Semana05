using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Enemy loki = new Enemy("Loki");
            loki.SetName("   Grindalokki   ");

            Console.WriteLine
            ($"Name is {loki.GetName()} and Hp is {loki.GetHealth()}");*/

            int enemy_n = int.Parse(args[0]);

            Enemy[] enemy_array = new Enemy[enemy_n];

            for(int i= 0; i < enemy_n; i ++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string tmp_name = Console.ReadLine();
                
                Enemy rank_and_file = new Enemy(tmp_name);
                enemy_array[i]= rank_and_file;
            }

            foreach(Enemy e in enemy_array)
            {
            Console.WriteLine($"{e.GetName()} {e.GetHealth()} {e.GetShield()}");
            }

        }
    }
}
