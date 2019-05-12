using System.Linq;
using Xunit;

namespace VierGewinnt.Core.Tests
{
    public class SpielbrettFactoryTests
    {
        public SpielbrettFactoryTests()
        {
            _testTarget = new SpielbrettFactory();
            _spielbrett = _testTarget.Erstelle(6, 7);
        }

        private readonly SpielbrettFactory _testTarget;
        private readonly Spielbrett _spielbrett;

        [Fact]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlReihen()
        {
            Assert.Equal(6, _spielbrett.Reihen.Count);
        }

        [Fact]
        public void ErstelleErzeugtSpielbrettMitKorrekterAnzahlSpalten()
        {
            Assert.Equal(7, _spielbrett.Spalten.Count);
        }

        [Fact]
        public void ErstelleFuegtKorrektPlaetzeZuLinksUntenDiagonaleHinzu()
        {
            var zielDiagonal = _spielbrett.Diagonalen.First(
                diagonale =>
                    diagonale.Diagnoalenrichtung == Diagnoalenrichtung.LinksUnten && diagonale.StartIndexX == 5 &&
                    diagonale.StartIndexY == 0);

            var ersterPlatz = zielDiagonal.Plaetze.First();
            var letzterPlatz = zielDiagonal.Plaetze.Last();

            Assert.True(ersterPlatz.XPostion == 5 && ersterPlatz.YPostion == 0);
            Assert.True(letzterPlatz.XPostion == 0 && letzterPlatz.YPostion == 5);
        }

        [Fact]
        public void ErstelleFuegtKorrektPlaetzeZuRechtsUntenDiagonaleHinzu()
        {
            var zielDiagonal = _spielbrett.Diagonalen.First(
                diagonale =>
                    diagonale.Diagnoalenrichtung == Diagnoalenrichtung.RechtsUnten && diagonale.StartIndexX == 0 &&
                    diagonale.StartIndexY == 2);

            var ersterPlatz = zielDiagonal.Plaetze.First();
            var letzterPlatz = zielDiagonal.Plaetze.Last();

            Assert.True(ersterPlatz.XPostion == 0 && ersterPlatz.YPostion == 2);
            Assert.True(letzterPlatz.XPostion == 3 && letzterPlatz.YPostion == 5);
        }

        [Fact]
        public void ErstelleFuegtKorrektPlaetzeZuReihenHinzu()
        {
            var reihen4 = _spielbrett.Reihen[3];

            Assert.True(reihen4.Plaetze.All(platz => platz.YPostion == 3));
        }

        [Fact]
        public void ErstelleFuegtKorrektPlaetzeZuSpaltenHinzu()
        {
            var spalte3 = _spielbrett.Spalten[2];

            Assert.True(spalte3.Plaetze.All(platz => platz.XPostion == 2));
        }

        [Fact]
        public void ErstelleIgnorierteDiagonalenMitWenigerAlsVierPlaetzen()
        {
            Assert.True(_spielbrett.Diagonalen.All(diagonale => diagonale.Plaetze.Count >= 4));
        }
    }
}