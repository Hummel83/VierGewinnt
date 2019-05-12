using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Reihe
    {
        public Reihe(List<Platz> plaetze)
        {
            Plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze { get; }
    }
}