using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Diagonale : Linie
    {
        public Diagonale(int startIndexX,
            int startIndexY,
            Diagnoalenrichtung diagnoalenrichtung,
            IReadOnlyList<Platz> plaetze) : base(plaetze)
        {
            if (startIndexX < 0 || startIndexY < 0) throw new ArgumentOutOfRangeException();


            StartIndexX = startIndexX;
            StartIndexY = startIndexY;
            Diagnoalenrichtung = diagnoalenrichtung;
        }

        public Diagnoalenrichtung Diagnoalenrichtung { get; }

        public int StartIndexY { get; }

        public int StartIndexX { get; }
    }
}