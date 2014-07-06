using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncKitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 30;

            Chef.MakeTeaAndCarrots();
            AsyncChef.MakeTeaAndCarrotsAsync();

            Console.ReadKey();
        }
    }
}
