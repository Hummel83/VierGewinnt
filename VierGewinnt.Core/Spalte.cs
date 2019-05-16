using System;
using System.Collections.Generic;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Spalte : Linie, ISpalte

    {
        public Spalte(IReadOnlyList<Platz> plaetze) : base(plaetze)
        {
            Plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze { get; }

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            foreach (var platz in Plaetze)
                if (platz.Spielstein == null)
                {
                    platz.Spielstein = spielstein;
                    return;
                }

            throw new InvalidOperationException("Die Spalte ist bereits voll");
        }

        public bool IstSpalteVoll
        {
            get { return Plaetze.All(platz => platz.Spielstein != null); }
        }
    }
}