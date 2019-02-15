using System;
using System.Collections.Generic;
using System.Text;
using VierGewinnt.View;
using Xunit;

namespace VierGewinnt.Core.Tests
{
    public class SpielerTests
    {
        [Fact]
        public void SpieleZugEntferntAusDenSpielsteinen()
        {
            // Arrange
            var spielsteinDummy = new List<Spielstein>()
                                 {
                                     new Spielstein()
                                 };
            var initalCount = spielsteinDummy.Count;
            var testTarget = new Spieler(spielsteinDummy, "Barwurst");
            var spalteDummy = new SpalteMock();

            // Act
            testTarget.SpieleZug(spalteDummy);

            Assert.Equal(testTarget.Spielsteine.Count, initalCount-1);
            
        }

        [Fact]
        public void SpieleZugLaesstEinenSpielsteinFallen()
        {
            // Arrange
            var spielsteinDummy = new List<Spielstein>()
                                 {
                                     new Spielstein()
                                 };
            
            var testTarget = new Spieler(spielsteinDummy, "Barwurst");
            var spalteMock = new SpalteMock();

            // Act
            testTarget.SpieleZug(spalteMock);

            Assert.True(spalteMock.WurdeLAsseSPielsteinFallenGenauEinmalAufgerufen);
        }

    }
}
