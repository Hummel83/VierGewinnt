using System.Collections.Generic;
using System;

namespace VierGewinnt.View
{
    public class Spalte : ISpalte
    {
        private readonly IReadOnlyList<Platz> _plaetze;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            throw new NotImplementedException();
        }

    }
}