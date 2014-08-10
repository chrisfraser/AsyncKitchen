using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncKitchen
{
    public class AsyncChef
    {
        private Stopwatch _stopwatch;

        public async Task<string> MakeTeaAndCarrotsAsync()
        {
            Console.WriteLine("------------------AsyncChef------------------");
            _stopwatch = Stopwatch.StartNew();

            Task<string> makeTea = MakeTea();
            Task<string> bakeCarrots = MakeBakedCarrots();

            string dish = Serve(await makeTea, await bakeCarrots);

            Console.WriteLine("Done: {0}ms", _stopwatch.ElapsedMilliseconds);
            Console.WriteLine("---------------------------------------------");

            _stopwatch.Stop();

            return dish;
        }

        private async Task<string> MakeTea()
        {
            // Put the kettle on then return control to returning method
            await BoilKettle();

            // Make tea once kettle has boiled
            Console.WriteLine("Start: MakingTea");
            Thread.Sleep(500);
            Console.WriteLine("End: MakingTea {0}ms", _stopwatch.ElapsedMilliseconds);

            return "tea";
        }

        private async Task BoilKettle()
        {
            Console.WriteLine("Start: BoilingKettle");
            await Task.Delay(1000); // Return control to calling method
            Console.WriteLine("End: BoilingKettle {0}ms", _stopwatch.ElapsedMilliseconds);
        }

        private async Task<string> MakeBakedCarrots()
        {
            // Chop carrots
            ChopCarrots();

            // Put carrots in the oven
            Console.WriteLine("Start: BakingCarrots");
            await Task.Delay(1500); // Return control to calling method
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

            return String.Format("Hot {0} and tasty {1}", tea, bakedCarrots);
        }
    }
}