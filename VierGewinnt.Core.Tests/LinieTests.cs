using System;
using System.Collections.Generic;
using System.Text;
using VierGewinnt.Core;

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
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")}
            };

            var testTarget = new LinieMock(plaetze);

            var spielerName = testTarget.UeberpruefeObEinSpielerVierInEinerReiheHat();

            Assert.Equal("Draht", spielerName);
        }

        [Fact]  
        public void  VierInEinerReiheMitUnterbrechnungWerdenKorrektErkannt()
        {
            var plaetze = new List<Platz>
            {
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")}
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
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(0,128,0), "Muh")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz{Spielstein = new Spielstein(new Farbe(128,0,0), "Draht")},
                new Platz(),
                new Platz()
            };

            var testTarget = new LinieMock(plaetze);

            var spielerName = testTarget.UeberpruefeObEinSpielerVierInEinerReiheHat();

            Assert.Null(spielerName);
        }
    }   
}
