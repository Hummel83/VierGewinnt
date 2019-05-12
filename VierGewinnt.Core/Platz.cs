using System;

namespace VierGewinnt.Core
{
    public class Platz
    {
        public Platz(int xPostion, int yPostion)
        {
            if (xPostion < 0 || yPostion < 0) throw new ArgumentOutOfRangeException("Index zu klein");

            XPostion = xPostion;
            YPostion = yPostion;
        }

        public Spielstein Spielstein { get; set; }

        public int XPostion { get; }

        public int YPostion { get; }
    }
}