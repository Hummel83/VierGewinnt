using System;
using System.Collections.Generic;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {
        private readonly IReadOnlyList<Diagonale> diagonalen;
        private readonly IReadOnlyList<IReadOnlyList<Platz>> plaetze;
        private readonly IReadOnlyList<Reihe> reihen;
        private readonly IReadOnlyList<Spalte> spalten;

        public Spielbrett(
            IReadOnlyList<IReadOnlyList<Platz>> plaetze,
            IReadOnlyList<Reihe> reihen,
            IReadOnlyList<Spalte> spalten,
            IReadOnlyList<Diagonale> diagonalen)
        {
            this.plaetze = plaetze ?? throw new ArgumentNullException(nameof(plaetze));
            this.reihen = reihen ?? throw new ArgumentNullException(nameof(reihen));
            this.spalten = spalten ?? throw new ArgumentNullException(nameof(spalten));
            this.diagonalen = diagonalen ?? throw new ArgumentNullException(nameof(diagonalen));
        }

        #region Properties

        public IReadOnlyList<Diagonale> Diagonalen => diagonalen;
        public IReadOnlyList<Spalte> Spalten => spalten;
        public IReadOnlyList<Reihe> Reihen => reihen;
        public IReadOnlyList<IReadOnlyList<Platz>> Plaetze => plaetze;

        #endregion Properties
    }
}