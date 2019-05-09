using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Reihe
    {
        private readonly IReadOnlyList<Platz> plaetze;

        public Reihe(List<Platz> plaetze)
        {
            this.plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze => plaetze;
    }
}