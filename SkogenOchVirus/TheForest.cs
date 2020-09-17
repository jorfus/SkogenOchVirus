using System;
using System.Collections.Generic;
using System.Text;

namespace Skogen
{
    class TheForest
    {
        public List<Djur> Forest { get; private set; } = new List<Djur>();

        public void NyttDjur(string djurArt, bool nattDjur, string vaketBeteende)
        {
            Djur djur = new Djur(djurArt, nattDjur, vaketBeteende);
            Forest.Add(djur);
        }
    }
}
