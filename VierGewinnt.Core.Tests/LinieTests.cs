using System.Collections.Generic;

using Xunit;

namespace VierGewinnt.Core.Tests
{
    public class LinieTests
    {
        [Fact]
        public void VierInEinerReiheWerdenKorrektErkannt()
        {
            var plaetze = new List<Platz>
            {
                new Platz(0,1){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,2){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,3){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,4){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")}
            };

            var testTarget = new LinieMock(plaetze);

            var spielerName = testTarget.UeberpruefeObEinSpielerVierInEinerReiheHat();

            Assert.Equal("Draht", spielerName);
        }

        [Fact]
        public void VierInEinerReiheMitUnterbrechnungWerdenKorrektErkannt()
        {
            var plaetze = new List<Platz>
            {
                new Platz(0,0){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,1){Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz(0,2){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,3){Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz(1,0){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(1,1){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(1,2){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")}
            };

            var testTarget = new LinieMock(plaetze);

            var spielerName = testTarget.UeberpruefeObEinSpielerVierInEinerReiheHat();

            Assert.Equal("Draht", spielerName);
        }

        [Fact]
        public void KeinGewinnerWirdKorrektErkannt()
        {
            var plaetze = new List<Platz>
            {
                new Platz(0,0){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,1){Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz(0,2){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,3){Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(0,0),
                new Platz(0,1)
            };

            var testTarget = new LinieMock(plaetze);

            var spielerName = testTarget.UeberpruefeObEinSpielerVierInEinerReiheHat();

            Assert.Null(spielerName);
        }
    }
}