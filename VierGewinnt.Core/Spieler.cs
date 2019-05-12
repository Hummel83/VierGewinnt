using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler
    {
        private readonly IList<Spielstein> _spielsteine;
        private readonly string _spielerName;
        private readonly Farbe _spielerFarbe;

        public Spieler( string spielerName, IList<Spielstein> spielstein, Farbe spielerFarbe)
        {
            if (spielstein == null) throw new ArgumentNullException(nameof(spielstein));
            if (string.IsNullOrWhiteSpace(spielerName)) throw new ArgumentNullException(nameof(spielerName));

            _spielsteine = spielstein;
            _spielerName = spielerName;
            _spielerFarbe = spielerFarbe;
        }

        public string SpielerName => _spielerName;

        public IList<Spielstein> Spielsteine => _spielsteine;

        public Farbe SpielerFarbe => _spielerFarbe;

        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));

            var obersterSpielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);

            spalte.LasseSpielsteinFallen(obersterSpielstein);
        }
    }
}