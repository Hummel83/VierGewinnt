using System;

namespace VierGewinnt.Core
{
    public class SpielbrettFactory
    {
        public Spielbrett Erstelle(int reihenAnzahl, int spaltenAnzahl)
        {
            if (spaltenAnzahl < 2) throw new ArgumentOutOfRangeException("spaltenAnzahl", "Die Spalte ist zu klein.");
            if (reihenAnzahl < 2) throw new ArgumentOutOfRangeException("reihenAnzahl", "Die Spalte ist zu klein.");

            //  2-dimensionaler Array aus PLätzen erzeugen
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

            // Reihen       

            // Diagonalen

            // Intialisierung Spielbrett

            return new Spielbrett();
        }
    }
   
}
