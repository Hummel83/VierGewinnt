using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class SpielbrettFactory
    {
        private int _spaltenAnzahl;
        private int _reihenAnzahl;
        private Platz[][] _plaetze;
        private List<Spalte> _spalten;
        private List<Reihe> _reihen;
        private List<Diagonale> _diagonale;

        public Spielbrett Erstelle(int reihenAnzahl, int spaltenAnzahl)
        {
            if (spaltenAnzahl < 2) throw new ArgumentOutOfRangeException("spaltenAnzahl", "Die Spalte ist zu klein.");
            if (reihenAnzahl < 2) throw new ArgumentOutOfRangeException("reihenAnzahl", "Die Reihe ist zu klein.");

            _reihenAnzahl = reihenAnzahl;
            _spaltenAnzahl = spaltenAnzahl;

            ErzeugeSpielbrettArray();
            ErzeugeSpalten();
            ErzeugeReihen();
            ErzeugeDiagonale();

            return new Spielbrett(_plaetze, _reihen, _spalten, _diagonale);
        }

        private Platz[][] ErzeugeSpielbrettArray()
        {
            _plaetze = new Platz[_spaltenAnzahl][];
            for (var i = 0; i < _spaltenAnzahl; i++)
            {
                _plaetze[i] = new Platz[_reihenAnzahl];
                for (var j = 0; j < _reihenAnzahl; j++) _plaetze[i][j] = new Platz(i, j);
            }

            return _plaetze;
        }

        private List<Spalte> ErzeugeSpalten()
        {
            _spalten = new List<Spalte>();
            for (var aktuelleSpalte = 0; aktuelleSpalte < _spaltenAnzahl; aktuelleSpalte++)
            {
                var spaltenplaetze = new List<Platz>();
                for (var aktuelleReihe = 0; aktuelleReihe < _reihenAnzahl; aktuelleReihe++)
                {
                    spaltenplaetze.Add(_plaetze[aktuelleSpalte][aktuelleReihe]);
                }
                    
                _spalten.Add(new Spalte(spaltenplaetze));
            }

            return _spalten;
        }

        private List<Reihe> ErzeugeReihen()
        {
            _reihen = new List<Reihe>();
            for (var aktuelleReihe = 0; aktuelleReihe < _reihenAnzahl; aktuelleReihe++)
            {
                var reihenplaetze = new List<Platz>();
                for (var aktuelleSpalte = 0; aktuelleSpalte < _spaltenAnzahl; aktuelleSpalte++)
                {
                    reihenplaetze.Add(_plaetze[aktuelleSpalte][aktuelleReihe]);
                }
                _reihen.Add(new Reihe(reihenplaetze));
            }

            return _reihen;
        }

        private List<Diagonale> ErzeugeDiagonale()
        {
            // Diagonalen
            _diagonale = new List<Diagonale>();
            var diagnoalenrichtung = Diagnoalenrichtung.RechtsUnten;

            // Diagonalen von links oben nach rechts unten

            for (var aktuelleSpalte = 0; aktuelleSpalte < _spaltenAnzahl; aktuelleSpalte++)
            {
                var spaltenIndex = aktuelleSpalte;
                var reihenIndex = 0;
                var diagonalenPlaetze = new List<Platz>();
                while (spaltenIndex < _spaltenAnzahl && reihenIndex < _reihenAnzahl)
                {
                    diagonalenPlaetze.Add(_plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }

                if (diagonalenPlaetze.Count >= 4) _diagonale.Add(new Diagonale(aktuelleSpalte,0, diagnoalenrichtung, diagonalenPlaetze));
            }

            for (var aktuelleReihe = 1; aktuelleReihe < _reihenAnzahl; aktuelleReihe++)
            {
                var spaltenIndex = 0;
                var reihenIndex = aktuelleReihe;
                var diagonalenPlaetze = new List<Platz>();
                while (spaltenIndex < _spaltenAnzahl && reihenIndex < _reihenAnzahl)
                {
                    diagonalenPlaetze.Add(_plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }

                if (diagonalenPlaetze.Count >= 4) _diagonale.Add(new Diagonale(0, aktuelleReihe, diagnoalenrichtung, diagonalenPlaetze));
            }

            // Diagonalen von rechts oben nach links unten
            diagnoalenrichtung = Diagnoalenrichtung.LinksUnten;
            for (var aktuelleSpalte = 0; aktuelleSpalte < _spaltenAnzahl; aktuelleSpalte++)
            {
                var spaltenIndex = aktuelleSpalte;
                var reihenIndex = 0;

                var diagonalenPlaetze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < _reihenAnzahl)
                {
                    diagonalenPlaetze.Add(_plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }

                if (diagonalenPlaetze.Count >= 4) _diagonale.Add(new Diagonale(aktuelleSpalte,0, diagnoalenrichtung, diagonalenPlaetze));
            }

            for (var aktuelleReihe = 1; aktuelleReihe < _reihenAnzahl; aktuelleReihe++)
            {
                var spaltenIndex = _spaltenAnzahl - 1;
                var reihenIndex = aktuelleReihe;

                var diagonalenPlaetze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < _reihenAnzahl)
                {
                    diagonalenPlaetze.Add(_plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }

                if (diagonalenPlaetze.Count >= 4) _diagonale.Add(new Diagonale(_spaltenAnzahl - 1, aktuelleReihe, diagnoalenrichtung, diagonalenPlaetze));
            }

            return _diagonale;
        }
    }
}