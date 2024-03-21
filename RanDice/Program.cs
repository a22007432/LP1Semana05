using System;
using System.Linq;



namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            int s = int.Parse(args[1]);

            var rand = new Random(s);

            int[] intarray = new int[n];

            for(int i = 0; i < n; i ++)
            {
                int tmp = rand.Next(1,7);
                Console.WriteLine(tmp);
                intarray[i] = tmp;
            }

            int ret = intarray.Sum();
            Console.WriteLine(ret);


        }
    }
}
