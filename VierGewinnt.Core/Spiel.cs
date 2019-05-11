using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spiel
    {
        private readonly Spielbrett _spielbrett;
        private readonly IReadOnlyList<Spieler> _spielerListe;

        public Spiel(IReadOnlyList<Spieler> spielerListe, Spielbrett spielbrett)
        {
            _spielerListe = spielerListe;
            _spielbrett = spielbrett;
        }

        public void StarteSpiel()
        {
            throw new NotImplementedException();
        }
    }
}