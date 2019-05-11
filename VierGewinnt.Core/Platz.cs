using System;

namespace VierGewinnt.Core
{
    public class Platz
    {
        private readonly int _xPostion;
        private readonly int _yPostion;

        public Platz(int xPostion, int yPostion)
        {
            if (xPostion < 0 || yPostion < 0)
            {throw new ArgumentOutOfRangeException("Index zu klein");}
            
            this._xPostion = xPostion;
            this._yPostion = yPostion;
        }

        public Spielstein Spielstein { get; set; }

        public int XPostion => this._xPostion;

        public int YPostion => _yPostion;
    }
}