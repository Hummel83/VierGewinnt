using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class SpielbrettFactory
    {
        public Spielbrett Erstelle(int reihenAnzahl, int spaltenAnzahl)
        {
            if (spaltenAnzahl < 2) throw new ArgumentOutOfRangeException("spaltenAnzahl", "Die Spalte ist zu klein.");
            if (reihenAnzahl < 2) throw new ArgumentOutOfRangeException("reihenAnzahl", "Die Spalte ist zu klein.");

            //  2-dimensionaler Array aus Plätzen erzeugen
            var plaetze = new Platz[spaltenAnzahl][];
            for (int i = 0; i < spaltenAnzahl; i++)
            {
                plaetze[i] = new Platz[reihenAnzahl];
                for (int j = 0; j < reihenAnzahl; j++)
                {
                    plaetze[i][j] = new Platz();
                }
            }

            // Spalten
            var spalten = new List<Spalte>();
            for (int i = 0; i < spaltenAnzahl; i++)
            {
                var spaltenplaetze = new List<Platz>();
                for (int j = 0; j < reihenAnzahl; j++)
                {
                    spaltenplaetze.Add(plaetze[i][j]);
                }
                spalten.Add(new Spalte(spaltenplaetze));
            }

            // Reihen
            var reihen = new List<Reihe>();
            for (int i = 0; i < reihenAnzahl; i++)
            {
                var reihenplaetze = new List<Platz>();
                for (int j = 0; j < spaltenAnzahl; j++)
                {
                    reihenplaetze.Add(plaetze[i][j]);
                }
                reihen.Add(new Reihe(reihenplaetze));
            }
            // Diagonalen
            var diagonale = new List<Diagonale>();

            // Diagonalen von links oben nach rechts unten

            for (int i = 0; i < spaltenAnzahl; i++)
            {
                var spaltenIndex = i;
                var reihenIndex = 0;
                var diagonalenPlaetze = new List<Platz>();
                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlaetze.Add(plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }
                if (diagonalenPlaetze.Count >= 4)
                {
                    diagonale.Add(new Diagonale(diagonalenPlaetze));
                }
            }
            for (int j = 1; j < reihenAnzahl; j++)
            {
                var spaltenIndex = 0;
                var reihenIndex = j;
                var diagonalenPlaetze = new List<Platz>();
                while (spaltenIndex < spaltenAnzahl && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlaetze.Add(plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex++;
                    reihenIndex++;
                }
                if (diagonalenPlaetze.Count >= 4)
                {
                    diagonale.Add(new Diagonale(diagonalenPlaetze));
                }
            }

            // Diagonalen von rechts oben nach links unten

            for (int i = 0; i < spaltenAnzahl; i++)
            {
                var spaltenIndex = i;
                var reihenIndex = 0;

                var diagonalenPlaetze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlaetze.Add(plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }
                if (diagonalenPlaetze.Count >= 4)
                {
                    diagonale.Add(new Diagonale(diagonalenPlaetze));
                }
            }
            for (int j = 1; j < reihenAnzahl; j++)
            {
                var spaltenIndex = spaltenAnzahl - 1;
                var reihenIndex = j;

                var diagonalenPlaetze = new List<Platz>();

                while (spaltenIndex >= 0 && reihenIndex < reihenAnzahl)
                {
                    diagonalenPlaetze.Add(plaetze[spaltenIndex][reihenIndex]);
                    spaltenIndex--;
                    reihenIndex++;
                }
                if (diagonalenPlaetze.Count >= 4)
                {
                    diagonale.Add(new Diagonale(diagonalenPlaetze));
                }
            }

            // Intialisierung Spielbrett

            return new Spielbrett(plaetze, reihen, spalten, diagonale);
        }
    }
}