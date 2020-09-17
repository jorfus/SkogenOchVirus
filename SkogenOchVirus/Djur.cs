using System;
using System.Collections.Generic;
using System.Text;

namespace Skogen
{
    class Djur
    {
        string Djuret { get; set; }
        bool NattDjur { get; set; }
        string VaketBeteende { get; set; }

        public Djur(string djuret, bool nattDjur, string vaketBeteende)
        {
            Djuret = djuret;
            NattDjur = nattDjur;
            VaketBeteende = vaketBeteende;
        }

        public string ToString(ConsoleKey input)
        {
            string beteende;

            if (input == ConsoleKey.N && NattDjur || input == ConsoleKey.D && NattDjur == false)
                beteende = VaketBeteende;
            else
                beteende = "sover";

            return $"{Djuret} {beteende}.";
        }
    }
}
