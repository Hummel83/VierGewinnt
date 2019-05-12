using System;

namespace VierGewinnt.Core.Tests
{
    public class SpalteMock : ISpalte
    {
        private int _anzahlLasseSpielsteinFallenAufrufe;

        public bool WurdeLasseSpielsteinFallenGenauEinmalAufgerufen => _anzahlLasseSpielsteinFallenAufrufe == 1;

        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }

        public bool IstSpalteVoll => throw new NotSupportedException();
    }
}