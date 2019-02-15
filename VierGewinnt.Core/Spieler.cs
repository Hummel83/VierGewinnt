using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.View
{
   public class Spieler
    {
        private readonly IList<Spielstein> _spielsteine;
        private readonly string _name;

        public Spieler(IList<Spielstein> spielstein, string name)
        {
            if (spielstein == null) throw new ArgumentNullException(nameof(spielstein));
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

            _spielsteine = spielstein;
            _name = name;
        }
        public string Name => _name;

        public IList<Spielstein> Spielsteine => _spielsteine;
      
        public void SpieleZug(Spalte spalte)
        {
            if (spalte == null) throw new ArgumentNullException(nameof(spalte));
           
            var obersterSpielstein = _spielsteine[0];
            _spielsteine.RemoveAt(0);
            
            spalte.LasseSpielsteinFallen(obersterSpielstein);
        }
    }
}
