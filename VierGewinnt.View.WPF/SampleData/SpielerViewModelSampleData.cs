using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF.SampleData
{
    public class SpielerViewModelSampleData : ISpielerViewModel
    {
        public SpielerViewModelSampleData()
        {
            var spielerFarbe = new Farbe(0, 0, 254);
            const string spielerName = "Player B";
            var spielstein = new List<Spielstein>();
            for (var i = 0; i < 21; i++) spielstein.Add(new Spielstein(spielerFarbe, spielerName));
            Spieler = new Spieler(spielerName, spielstein, spielerFarbe);

            IstAnDerReihe = true;
        }

        public Spieler Spieler { get; }

        public bool IstAnDerReihe { get; set; }
    }
}