using Skogen;
using System;

namespace SkogenOchVirus
{
    class Program
    {
        static void Main(string[] args)
        {
            TheForest forest = new TheForest();

            bool loop = true;
            while (loop)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Ange djurart i bestämd form (ex: Lejonet)");
                    string nyttDjur = Console.ReadLine();

                    ConsoleKeyInfo input;
                    bool nattDjur;
                    while (true)
                    {
                        Console.WriteLine("\nÄr det ett nattdjur? [J/N]: ");
                        input = Console.ReadKey(true);

                        if (input.Key == ConsoleKey.J)
                        {
                            nattDjur = true;
                            break;
                        }
                        else if (input.Key == ConsoleKey.N)
                        {
                            nattDjur = false;
                            break;
                        }
                    }

                    Console.WriteLine("\nVad gör djuret när det är vaket? (ex: springer omkring)");
                    string vaketBeteende = Console.ReadLine();

                    forest.NyttDjur(nyttDjur, nattDjur, vaketBeteende);

                    while (true)
                    {
                        Console.WriteLine("\nLägg till ännu ett djur? [J/N]: ");
                        input = Console.ReadKey(true);

                        if (input.Key == ConsoleKey.J)
                            break;
                        else if (input.Key == ConsoleKey.N)
                        {
                            while (input.Key != ConsoleKey.Escape)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                foreach (Djur djur in forest.Forest)
                                    Console.WriteLine($"{djur.ToString(input.Key)}\n");

                                Console.WriteLine("-------------------------\nVäxla dag/natt: [D/N)\n\n[Escape] för att gå vidare.");
                                input = Console.ReadKey(true);
                            }
                        }
                        if (input.Key == ConsoleKey.Escape)
                            break;
                    }
                    if (input.Key == ConsoleKey.J)
                        break;
                        
                    bool loopTwo = true;
                    while (loopTwo)
                    {
                        Console.Write("\nLägg till fler djur: [D]\nBörja om: Enter\nAvsluta: Escape\n");
                        input = Console.ReadKey(true);

                        switch (input.Key)
                        {
                            case ConsoleKey.D:
                                loopTwo = false;
                                break;
                            case ConsoleKey.Enter:
                                forest.Forest.Clear();
                                loopTwo = false;
                                break;
                            case ConsoleKey.Escape:
                                loop = loopTwo = false;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
