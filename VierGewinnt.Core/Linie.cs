using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public abstract class Linie
    {
        private readonly IReadOnlyList<Platz> _plaetze;

        protected Linie(IReadOnlyList<Platz> plaetze)
        {
            _plaetze = plaetze ?? throw new ArgumentNullException(nameof(plaetze));
        }

        public string UeberpruefeObEinSpielerVierInEinerReiheHat()
        {
            var counter = 0;
            string aktuellerSpielername = null;

            foreach (var platz in _plaetze)
            {
                var spielstein = platz.Spielstein;
                if (spielstein == null)
                {
                    counter = 0;
                    aktuellerSpielername = null;
                    continue;
                }
                if (aktuellerSpielername != spielstein.SpielerName)
                {
                    aktuellerSpielername = spielstein.SpielerName;
                    counter = 1;
                }
                counter++;

                if (counter >= 4)
                {
                    return aktuellerSpielername;
                }
            }
            return null;
        }

        public IReadOnlyList<Platz> Plaetze
        {
            get { return _plaetze; }
        }
    }
}