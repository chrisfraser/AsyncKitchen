using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncKitchen
{
    public class Chef
    {
        public static void MakeTeaAndCarrots()
        {
            Console.WriteLine("--------------------Chef---------------------");

            var stopwatch = Stopwatch.StartNew();

            MakeTea(stopwatch);

            BakeCarrots(stopwatch);

            Serve(stopwatch);

            Console.WriteLine("Done: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("---------------------------------------------");

            stopwatch.Stop();
        }

        private static void MakeTea(Stopwatch stopwatch)
        {
            BoilKettle(stopwatch);
            Console.WriteLine("Start: MakingTea");
            Thread.Sleep(500);
            Console.WriteLine("End: MakingTea {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void BoilKettle(Stopwatch stopwatch)
        {
            Console.WriteLine("Start: BoilingKettle");
            Thread.Sleep(1000);
            Console.WriteLine("End: BoilingKettle {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void BakeCarrots(Stopwatch stopwatch)
        {
            ChopCarrots(stopwatch);
            Console.WriteLine("Start: BakingCarrots");
            Thread.Sleep(500);
            Console.WriteLine("End: BakingCarrots {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void ChopCarrots(Stopwatch stopwatch)
        {
            Console.WriteLine("Start: ChoppingCarrots");
            Thread.Sleep(500);
            Console.WriteLine("End: ChoppingCarrots {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static void Serve(Stopwatch stopwatch)
        {
            Console.WriteLine("Start: Serving");
            Thread.Sleep(500);
            Console.WriteLine("End: Serving {0}ms", stopwatch.ElapsedMilliseconds);
        }
    }
}