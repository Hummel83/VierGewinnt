using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spieler
    {
        public Spieler(string spielerName, IList<Spielstein> spielstein, Farbe spielerFarbe)
        {
            if (string.IsNullOrWhiteSpace(spielerName)) throw new ArgumentNullException(nameof(spielerName));

            Spielsteine = spielstein ?? throw new ArgumentNullException(nameof(spielstein));
            SpielerName = spielerName;
            SpielerFarbe = spielerFarbe;
        }

        public string SpielerName { get; }

        public IList<Spielstein> Spielsteine { get; }

        public Farbe SpielerFarbe { get; }

        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));

            var obersterSpielstein = Spielsteine[0];
            Spielsteine.RemoveAt(0);

            spalte.LasseSpielsteinFallen(obersterSpielstein);
        }
    }
}