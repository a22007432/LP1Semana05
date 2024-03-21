using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(200);
            crono1.Stop();
            crono2.Stop();

            //float  = Convert.ToDecimal(crono1.Elapsed);

            //Console.WriteLine($"{crono1.Elapsed:3f}");
            //Console.WriteLine($"{crono2.Elapsed:3f}");

            TimeSpan tsret1 = crono1.Elapsed;
            TimeSpan tsret2 = crono2.Elapsed;

            string ret1 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tsret1.Hours, tsret1.Minutes, tsret1.Seconds,
            tsret1.Milliseconds / 10);

            string ret2 = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            tsret2.Hours, tsret2.Minutes, tsret2.Seconds,
            tsret2.Milliseconds / 10);

            Console.WriteLine($"crono1: {ret1}");
            Console.WriteLine($"crono2: {ret2}");

            
        }
    }
}
