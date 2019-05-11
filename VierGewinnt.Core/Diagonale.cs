using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Diagonale :Linie
    {
        private readonly int _startIndexX;
        private readonly int _startIndexY;
        private readonly Diagnoalenrichtung _diagnoalenrichtung;

        public Diagonale(int startIndexX, 
            int startIndexY, 
            Diagnoalenrichtung diagnoalenrichtung, 
            IReadOnlyList<Platz> plaetze) :base(plaetze)
        {
            if (startIndexX < 0 || startIndexY < 0)
            {
                throw new ArgumentOutOfRangeException();
            }


            _startIndexX = startIndexX;
            _startIndexY = startIndexY;
            _diagnoalenrichtung = diagnoalenrichtung;
        }

        public Diagnoalenrichtung Diagnoalenrichtung => _diagnoalenrichtung;

        public int StartIndexY => _startIndexY;

        public int StartIndexX => _startIndexX;
    }
}