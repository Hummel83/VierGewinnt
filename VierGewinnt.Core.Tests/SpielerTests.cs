using System.Collections.Generic;
using Xunit;

namespace VierGewinnt.Core.Tests
{
    public class SpielerTests
    {
        private List<Spielstein> _spielsteinDummy;
        private const string _spielerName = "Bratwurst";
        public SpielerTests()
        {
           _spielsteinDummy = new List<Spielstein>()
            {
                new Spielstein(new Farbe(120,0,0), _spielerName)
            };

        }
        [Fact]
        public void SpieleZugEntferntAusDenSpielsteinen()
        {
            // Arrange
            
            var initalCount = _spielsteinDummy.Count;
            var testTarget = new Spieler(_spielerName, _spielsteinDummy, new Farbe(120, 0, 0));
            var spalteDummy = new SpalteMock();

            // Act
            testTarget.SpieleZug(spalteDummy);

            // Assert
            Assert.Equal(testTarget.Spielsteine.Count, initalCount - 1);
        }

        [Fact]
        public void SpieleZugLaesstEinenSpielsteinFallen()
        {
            // Arrange
            var testTarget = new Spieler( _spielerName, _spielsteinDummy, new Farbe(120, 0, 0));
            var spalteMock = new SpalteMock();

            // Act
            testTarget.SpieleZug(spalteMock);

            // Assert
            Assert.True(spalteMock.WurdeLasseSpielsteinFallenGenauEinmalAufgerufen);
        }
    }
}