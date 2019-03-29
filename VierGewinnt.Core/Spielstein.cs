using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class Spielstein
    {
        private readonly Farbe _farbe;
        private readonly string _spielerName;

        public Spielstein(Farbe farbe, string spielerName)
        {
            if (string.IsNullOrEmpty(spielerName))
            {
                throw new ArgumentException("message", nameof(spielerName));
            }

            _farbe = farbe ?? throw new ArgumentNullException(nameof(farbe));
            _spielerName = spielerName;
        }

        public Farbe Farbe { get { return _farbe; } }

        public string SpielerName { get { return _spielerName; } }
    }
}
