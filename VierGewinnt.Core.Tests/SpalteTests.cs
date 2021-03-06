﻿using System;
using System.Collections.Generic;
using Xunit;

namespace VierGewinnt.Core.Tests
{
    public class SpalteTests
    {
        [Fact]
        public void IstSpalteVollGibtFalseZurueckWennNichtAllePlaetzeVollSind()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Bratwurst");
            var plaetze = new List<Platz>();
            for (var i = 0; i < 6; i++) plaetze.Add(new Platz(0, i));
            plaetze[0].Spielstein = spielstein;
            plaetze[1].Spielstein = spielstein;

            var testTarget = new Spalte(plaetze);

            Assert.False(testTarget.IstSpalteVoll);
        }

        [Fact]
        public void IstSpalteVollGibtTrueZurueckAllePlaetzeVollSind()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Bratwurst");
            var plaetze = new List<Platz>();
            for (var i = 0; i < 6; i++) plaetze.Add(new Platz(0, 0) {Spielstein = spielstein});

            var testTarget = new Spalte(plaetze);

            Assert.True(testTarget.IstSpalteVoll);
        }

        [Fact]
        public void LasseSpielsteinFallenLoestFehlerAus()
        {
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Bratwurst");
            var plaetze = new List<Platz>();
            for (var i = 0; i < 6; i++) plaetze.Add(new Platz(0, 0) {Spielstein = spielstein});

            var testTarget = new Spalte(plaetze);

            Assert.Throws<InvalidOperationException>(() => testTarget.LasseSpielsteinFallen(spielstein));
        }

        [Fact]
        public void SpielsteinWirdKorrektInLeereSpalteEingefügt()
        {
            var plaetze = new List<Platz>();
            for (var i = 0; i < 6; i++) plaetze.Add(new Platz(0, 0));

            var testTarget = new Spalte(plaetze);
            var spielstein = new Spielstein(new Farbe(0, 0, 0), "Bratwurst");
            testTarget.LasseSpielsteinFallen(spielstein);

            for (var i = 0; i < plaetze.Count; i++)
            {
                if (i == 0)
                {
                    Assert.Equal(spielstein, plaetze[i].Spielstein);
                    continue;
                }

                Assert.Null(plaetze[i].Spielstein);
            }
        }
    }
}