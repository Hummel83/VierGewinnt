using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {
        public Spielbrett(
            IReadOnlyList<IReadOnlyList<Platz>> plaetze,
            IReadOnlyList<Reihe> reihen,
            IReadOnlyList<Spalte> spalten,
            IReadOnlyList<Diagonale> diagonalen)
        {
            Plaetze = plaetze ?? throw new ArgumentNullException(nameof(plaetze));
            Reihen = reihen ?? throw new ArgumentNullException(nameof(reihen));
            Spalten = spalten ?? throw new ArgumentNullException(nameof(spalten));
            Diagonalen = diagonalen ?? throw new ArgumentNullException(nameof(diagonalen));
        }

        #region Properties

        public IReadOnlyList<Diagonale> Diagonalen { get; }

        public IReadOnlyList<Spalte> Spalten { get; }

        public IReadOnlyList<Reihe> Reihen { get; }

        public IReadOnlyList<IReadOnlyList<Platz>> Plaetze { get; }

        #endregion Properties
    }
}