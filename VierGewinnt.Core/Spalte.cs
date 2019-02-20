using System.Collections.Generic;
using System;
using System.Linq;

namespace VierGewinnt.Core
{
    public class Spalte : Linie, ISpalte
    {
        //private readonly IReadOnlyList<Platz> _plaetze;

        public Spalte(IReadOnlyList<Platz> plaetze) : base(plaetze)
        {
        }

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            foreach (var platz in Plaetze)
            {
                if (platz.Spielstein ==null)
                {
                    platz.Spielstein = spielstein;
                    return;
                }
            }
            throw new InvalidOperationException("Die Spalte ist bereits voll");
               
        }
        public bool IstSpalteVoll
        {
            get { return Plaetze.All(platz => platz.Spielstein != null); }      
        }
    }
}