using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class Reihe
    {
        private readonly IReadOnlyList<Platz> plaetze;       

        public Reihe(List<Platz> plaetze)
        {
            this.plaetze = plaetze;
        }

        public IReadOnlyList<Platz> Plaetze => plaetze;
    }

}
