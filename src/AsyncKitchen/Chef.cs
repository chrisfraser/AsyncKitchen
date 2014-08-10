using System;
using System.Diagnostics;
using System.Threading;

namespace AsyncKitchen
{
    public class Chef
    {
        private Stopwatch _stopwatch;

        public string MakeTeaAndCarrots()
        {
            Console.WriteLine("--------------------Chef---------------------");

            _stopwatch = Stopwatch.StartNew();

            string tea = MakeTea();
            string bakedCarrots = MakeBakeCarrots();

            var dish = Serve(tea, bakedCarrots);

            Console.WriteLine("Done: {0}ms", _stopwatch.ElapsedMilliseconds);
            Console.WriteLine("---------------------------------------------");

            _stopwatch.Stop();

            return dish;
        }

        private string MakeTea()
        {
            // Boil kettle
            BoilKettle();

            Console.WriteLine("Start: MakingTea");
            Thread.Sleep(500);
            Console.WriteLine("End: MakingTea {0}ms", _stopwatch.ElapsedMilliseconds);

            return "tea";
        }

        private void BoilKettle()
        {
            Console.WriteLine("Start: BoilingKettle");
            Thread.Sleep(1000); // Watch while boiling
            Console.WriteLine("End: BoilingKettle {0}ms", _stopwatch.ElapsedMilliseconds);
        }

        private string MakeBakeCarrots()
        {
            ChopCarrots();

            Console.WriteLine("Start: BakingCarrots");
            Thread.Sleep(1500); // Watch oven
            Console.WriteLine("End: BakingCarrots {0}ms", _stopwatch.ElapsedMilliseconds);

            return "baked carrots";
        }

        private void ChopCarrots()
        {
            Console.WriteLine("Start: ChoppingCarrots");
            Thread.Sleep(500);
            Console.WriteLine("End: ChoppingCarrots {0}ms", _stopwatch.ElapsedMilliseconds);
        }

        private string Serve(string tea, string bakedCarrots)
        {
            Console.WriteLine("Start: Serving");
            Thread.Sleep(500);
            Console.WriteLine("End: Serving {0}ms", _stopwatch.ElapsedMilliseconds);

            return String.Format("Cold {0} and tasty {1}", tea, bakedCarrots);
        }
    }
}