using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Reihe
    {
        private readonly IReadOnlyList<Platz> _plaetze;

        public Reihe(List<Platz> plaetze)
        {
            _plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze => _plaetze;
    }
}