using System;

namespace VierGewinnt.Core
{
    public class Spielstein
    {
        public Spielstein(Farbe farbe, string spielerName)
        {
            if (string.IsNullOrEmpty(spielerName)) throw new ArgumentException("message", nameof(spielerName));

            Farbe = farbe ?? throw new ArgumentNullException(nameof(farbe));
            SpielerName = spielerName;
        }

        public Farbe Farbe { get; }

        public string SpielerName { get; }
    }
}