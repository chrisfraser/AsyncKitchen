using System;
using Nito.AsyncEx;

namespace AsyncKitchen
{
    static class Program
    {
        private static void Main()
        {
            AsyncContext.Run(() => MainAsync());
        }

        static async void MainAsync()
        {
            // Setup console
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 30;

            // Synchronous Chef
            var syncChef = new Chef();
            Console.WriteLine(syncChef.MakeTeaAndCarrots());

            Console.WriteLine();

            // Asynchronous Chef
            var asyncChef = new AsyncChef();
            Console.WriteLine(await asyncChef.MakeTeaAndCarrotsAsync());

            Console.ReadKey();
        }
    }
}
