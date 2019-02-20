using System;

namespace VierGewinnt.Core.Tests
{
    public class SpalteMock : ISpalte
    {
        private int _anzahlLasseSpielsteinFallenAufrufe;
        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }
        public bool WurdeLasseSPielsteinFallenGenauEinmalAufgerufen
        {
            get { return _anzahlLasseSpielsteinFallenAufrufe == 1; }
        }

        public bool IstSpalteVoll => throw new NotSupportedException();
    }
}
