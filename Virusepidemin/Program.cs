using System;

namespace Virusepidemin
{
    class Program
    {
        static void Main(string[] args)
        {
            Diskotek disko = new Diskotek();
            int timmar = 0;
            int antalSmittade = 1;
            int antalImmuna = 1;

            disko.FyllDisko();

            while (true)
            {
                Console.WriteLine($"{disko}\nTimme: {timmar}\tSmittade: {antalSmittade}\tImmuna: {antalImmuna}\n[Enter] för att stega\n");
                Console.ReadKey();
                timmar++;
                (antalSmittade, antalImmuna) = disko.Smittade(antalSmittade, antalImmuna, timmar);
            }

        }
    }
}
