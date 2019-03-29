using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.Core
{
    public class Spielbrett
    {
        private readonly IReadOnlyList<IReadOnlyList<Platz>> _plaetze;
        private readonly IReadOnlyList<Reihe> _reihen;
        private readonly IReadOnlyList<ISpalte> _spalten;

    }
   
}
