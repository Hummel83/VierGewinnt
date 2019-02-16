using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
   public class Spieler
    {
        private readonly IList<Spielstein> _spielsteine;
        private readonly string _spielerName;

        public Spieler(IList<Spielstein> spielstein, string spielerName)
        {
            if (spielstein == null) throw new ArgumentNullException(nameof(spielstein));
            if (string.IsNullOrWhiteSpace(spielerName)) throw new ArgumentNullException(nameof(spielerName));

            _spielsteine = spielstein;
            _spielerName = spielerName;
        }
        public string SpielerName => _spielerName;

        public IList<Spielstein> Spielsteine => _spielsteine;
      
        public void SpieleZug(ISpalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));
           
            var obersterSpielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);
            
            spalte.LasseSpielsteinFallen(obersterSpielstein);
        }
    }
}
