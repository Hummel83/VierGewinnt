using VierGewinnt.View;

namespace VierGewinnt.Core.Tests
{
    public class SpalteMock : ISpalte
    {
        private int _anzahlLasseSpielsteinFallenAufrufe;
        public void LasseSpielsteinFallen(Spielstein spielstein)
        {
            _anzahlLasseSpielsteinFallenAufrufe++;
        }
        public bool WurdeLAsseSPielsteinFallenGenauEinmalAufgerufen
        {
            get { return _anzahlLasseSpielsteinFallenAufrufe == 1; }
        }

    }
}
