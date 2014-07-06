using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncKitchen
{
    public class AsyncChef
    {
        public static async void MakeTeaAndCarrotsAsync()
        {
            Console.WriteLine("------------------AsyncChef------------------");
            Stopwatch stopwatch = Stopwatch.StartNew();

            Task makeTea = MakeTea(stopwatch);

            Task bakeCarrots = BakeCarrots(stopwatch);

            await Task.WhenAll(makeTea, bakeCarrots);

            Serve(stopwatch);

            Console.WriteLine("Done: {0}ms", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("---------------------------------------------");

            stopwatch.Stop();
        }

        private static async Task MakeTea(Stopwatch stopwatch)
        {
            await BoilKettle(stopwatch);
            Console.WriteLine("Start: MakingTea");
            await Task.Delay(500);
            Console.WriteLine("End: MakingTea {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static async Task BoilKettle(Stopwatch stopwatch)
        {
            Console.WriteLine("Start: BoilingKettle");
            await Task.Delay(1000);
            Console.WriteLine("End: BoilingKettle {0}ms", stopwatch.ElapsedMilliseconds);
        }

        private static async Task BakeCarrots(Stopwatch stopwatch)
        {
            ChopCarrots(stopwatch);
            Console.WriteLine("Start: BakingCarrots");
            await Task.Delay(500);
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