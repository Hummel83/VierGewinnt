using System.Collections.Generic;
using System;

namespace VierGewinnt.Core
{
    public abstract class Linie
    {
        private readonly IReadOnlyList<Platz> _plaetze;

        protected Linie(IReadOnlyList<Platz> plaetze)
        {
            if (plaetze == null) throw new ArgumentException("plaetze");

            _plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze
        {
            get   {return _plaetze;}
        }

        public string UeberpruefeObEinSpielerVierInEinerReiheHat()
        {
            var counter = 0;
            string aktuellerSpielername =null;

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
                counter ++;

                if (counter >= 4)
                {
                    return aktuellerSpielername;
                }
            }
            return null;
        }
    }

   
}
